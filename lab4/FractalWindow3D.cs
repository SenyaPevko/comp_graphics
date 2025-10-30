using System;
using System.Globalization;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace lab4
{
    public class FractalWindow3D : GameWindow
    {
        private float cameraAngleX = 0.5f;
        private float cameraAngleY = 0.5f;

        private float cameraDistance = 8.0f;
        private Vector2 lastMousePos;
        private bool mouseLeftPressed;
        private int recursionDepth;
        private float reductionFactor;

        public FractalWindow3D(int width, int height)
            : base(width, height, GraphicsMode.Default, "3D Fractal", GameWindowFlags.Default,
                DisplayDevice.Default)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.LineSmooth);
            GL.Hint(HintTarget.LineSmoothHint, HintMode.Nicest);
            GL.LineWidth(1.2f);

            ReadInputs();
            base.OnLoad(e);
        }

        private void ReadInputs()
        {
            Console.WriteLine("\nГлубина рекурсии (например 2): ");
            recursionDepth = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nКоэффициент уменьшения (например, 0.5): ");
            reductionFactor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            var aspectRatio = (float)Width / Height;
            var perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspectRatio, 0.1f, 100.0f);
            GL.LoadMatrix(ref perspective);

            GL.MatrixMode(MatrixMode.Modelview);
            base.OnResize(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SetupCamera();
            Draw3DFractal();

            SwapBuffers();
            base.OnRenderFrame(e);
        }

        private void SetupCamera()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            
            var cameraPosition = new Vector3(0, 0, cameraDistance);
            cameraPosition = Vector3.Transform(cameraPosition,
                Matrix4.CreateRotationY(cameraAngleY) * Matrix4.CreateRotationX(cameraAngleX));

            var lookAt = Matrix4.LookAt(cameraPosition, Vector3.Zero, Vector3.UnitY);
            GL.LoadMatrix(ref lookAt);
        }

        private void Draw3DFractal()
        {
            GL.Color3(0.8f, 0.8f, 1.0f);
            DrawCubeFractal(Vector3.Zero, 2.0f, recursionDepth);
        }

        private void DrawCubeFractal(Vector3 center, float size, int depth)
        {
            if (depth < 0) 
                return;
            
            DrawCube(center, size);

            if (depth > 0)
            {
                var newSize = size * reductionFactor;
                var offset = (size + newSize) * 0.5f;
                
                DrawCubeFractal(center + new Vector3(offset, 0, 0), newSize, depth - 1);
                DrawCubeFractal(center + new Vector3(-offset, 0, 0), newSize, depth - 1);
                DrawCubeFractal(center + new Vector3(0, offset, 0), newSize, depth - 1);
                DrawCubeFractal(center + new Vector3(0, -offset, 0), newSize, depth - 1);
                DrawCubeFractal(center + new Vector3(0, 0, offset), newSize, depth - 1);
                DrawCubeFractal(center + new Vector3(0, 0, -offset), newSize, depth - 1);
            }
        }

        private void DrawCube(Vector3 center, float size)
        {
            var s = size * 0.5f;
            
            Vector3[] vertices =
            {
                new Vector3(-s, -s, -s), new Vector3(s, -s, -s), new Vector3(s, s, -s),
                new Vector3(-s, s, -s),
                new Vector3(-s, -s, s), new Vector3(s, -s, s), new Vector3(s, s, s),
                new Vector3(-s, s, s)
            };
            
            for (var i = 0; i < vertices.Length; i++) vertices[i] += center;

            int[] indices =
            {
                0, 1, 1, 2, 2, 3, 3, 0,
                4, 5, 5, 6, 6, 7, 7, 4,
                0, 4, 1, 5, 2, 6, 3, 7
            };

            GL.Begin(BeginMode.Lines);
            for (var i = 0; i < indices.Length; i += 2)
            {
                GL.Vertex3(vertices[indices[i]]);
                GL.Vertex3(vertices[indices[i + 1]]);
            }

            GL.End();
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            if (e.Button == MouseButton.Left)
            {
                mouseLeftPressed = true;
                lastMousePos = new Vector2(e.X, e.Y);
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            if (e.Button == MouseButton.Left) mouseLeftPressed = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            if (mouseLeftPressed)
            {
                var deltaX = (e.X - lastMousePos.X) * 0.01f;
                var deltaY = (e.Y - lastMousePos.Y) * 0.01f;

                cameraAngleY += deltaX;
                cameraAngleX += deltaY;

                cameraAngleX = MathHelper.Clamp(cameraAngleX, -MathHelper.PiOver2, MathHelper.PiOver2);

                lastMousePos = new Vector2(e.X, e.Y);
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            cameraDistance -= e.Delta * 0.1f;
            cameraDistance = MathHelper.Clamp(cameraDistance, 2.0f, 20.0f);
            base.OnMouseWheel(e);
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Exit();
            }
            else if (e.Key == Key.R)
            {
                cameraDistance = 8.0f;
                cameraAngleX = 0.5f;
                cameraAngleY = 0.5f;
            }

            base.OnKeyDown(e);
        }
    }
}