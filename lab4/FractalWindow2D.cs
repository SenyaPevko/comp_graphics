using System;
using System.Globalization;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace lab4
{
    public class FractalWindow : GameWindow
    {
        private float fact;
        private int recursionDepth;
        private float reductionFactor;
        private float totalScale;
        private float xMax, yMax;

        public FractalWindow(int width, int height)
            : base(width, height, GraphicsMode.Default, "2D Fractal", GameWindowFlags.Default,
                DisplayDevice.Default)
        {
            xMax = width;
            yMax = height;
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            GL.Enable(EnableCap.LineSmooth);
            GL.Hint(HintTarget.LineSmoothHint, HintMode.Nicest);
            GL.LineWidth(1.0f);
            ReadInputs();
            base.OnLoad(e);
        }

        private void ReadInputs()
        {
            Console.WriteLine("\nГлубина рекурсии (например, 5): ");
            recursionDepth = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nКоэффициент уменьшения (например, 0.4): ");
            reductionFactor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalScale = 1.0f;
            for (var l = 0; l < recursionDepth; l++) totalScale *= reductionFactor;

            fact = 0.5f * (1.0f - reductionFactor);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Width, 0, Height, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
            xMax = Width;
            yMax = Height;
            base.OnResize(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            var R = xMax / 2.2f * (1.0f - reductionFactor) / (1.0f - totalScale);
            var r = R / (1.0f + reductionFactor);
            var xC = xMax / 2.0f;
            var yC = yMax / 2.0f;
            var xl = xC - r;
            var yl = yC - r;
            var xr = xC + r;
            var yr = yC + r;

            GL.Begin(BeginMode.LineStrip);
            GL.Vertex2(xl, yl);

            Side(xl, yl, xr, yl, recursionDepth);
            Side(xr, yl, xr, yr, recursionDepth);
            Side(xr, yr, xl, yr, recursionDepth);
            Side(xl, yr, xl, yl, recursionDepth);

            GL.End();

            SwapBuffers();
            base.OnRenderFrame(e);
        }

        private void Side(float xA, float yA, float xB, float yB, int n)
        {
            if (n == 0)
            {
                GL.Vertex2(xB, yB);
            }
            else
            {
                var dx = xB - xA;
                var dy = yB - yA;
                var fdx = fact * dx;
                var fdy = fact * dy;
                var xP = xA + fdx;
                var yP = yA + fdy;
                var xS = xB - fdx;
                var yS = yB - fdy;
                var xQ = xP + (yS - yP);
                var yQ = yP - (xS - xP);
                var xR = xQ + (xS - xP);
                var yR = yQ + (yS - yP);

                GL.Vertex2(xP, yP);
                Side(xP, yP, xQ, yQ, n - 1);
                Side(xQ, yQ, xR, yR, n - 1);
                Side(xR, yR, xS, yS, n - 1);
                GL.Vertex2(xB, yB);
            }
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape) Exit();
            base.OnKeyDown(e);
        }
    }
}