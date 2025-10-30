using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;

namespace lab2
{
    internal class Game : GameWindow
    {
        private Vector3 centre = new Vector3(0f, 0f, 4f);
        private float scale = 1.0f;
        private float rotationAngle = 0.0f;
        private int direction = 1;
        private float dx = 0.05f;

        public Game() : base(800, 600, GraphicsMode.Default, "OpenGL Lab")
        {
            VSync = VSyncMode.On;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            if (Keyboard[Key.Escape]) Exit();

            centre.X += dx * direction;
            centre.Y = Fun(centre.X);

            if (centre.X < -1.5f || centre.X > 1.5f)
            {
                direction = -direction;
                centre.X += dx * direction;
            }

            scale = 0.8f + (float)Math.Sin(e.Time * 2.0) * 0.4f;
            rotationAngle += 1.5f;
            if (rotationAngle >= 360.0f) rotationAngle -= 360.0f;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            OnRenderFrameTask2(e);
        }

        private void OnRenderFrameTask2(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            
            GL.PushMatrix();
            GL.Translate(centre.X, centre.Y, 0.0f);
            GL.Scale(scale, scale, 1.0f);
            
            var rotationCenter = new Vector3(0.0f, 0.0f, 4.0f);
            GL.Translate(rotationCenter.X, rotationCenter.Y, rotationCenter.Z);
            GL.Rotate(rotationAngle, 0.0f, 0.0f, 1.0f);
            GL.Translate(-rotationCenter.X, -rotationCenter.Y, -rotationCenter.Z);
            
            DrawCircle();

            GL.PopMatrix();

            SwapBuffers();
        }

        private float Fun(float x)
        {
            return x * x * 0.5f;
        }

        private void OnRenderFrameTask1(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            /*DrawTriangle();
            DrawSquare();*/
            DrawCircle();

            SwapBuffers();
        }

        private void DrawCircle()
        {
            var sides = 50;
            var center = new Vector3(0.0f, 0.0f, 4.0f);
            var radius = 1.0f;
            var colors = new Vector3[sides];
            for (var i = 0; i < sides; i++) 
                colors[i] = new Vector3(1.0f, (float)i / sides, 0.0f);

            DrawPolygon(center, radius, colors, sides, BeginMode.Polygon);
        }

        private void DrawPolygon(Vector3 center, float radius, Vector3[] colors, int sides, BeginMode mode)
        {
            GL.Begin(mode);
            for (var i = 0; i < sides; i++)
            {
                var angle = 2.0f * (float)Math.PI * i / sides;
                Vector3 vertex = new Vector3(
                    center.X + radius * (float)Math.Cos(angle),
                    center.Y + radius * (float)Math.Sin(angle),
                    center.Z
                );
                GL.Color3(colors[i % colors.Length]);
                GL.Vertex3(vertex);
            }
            GL.End();
        }

        private void DrawSquare()
        {
            var n = 4;
            var clr = new Vector3[n];
            clr[0] = new Vector3(1.0f, 1.0f, 0.0f);
            clr[1] = new Vector3(1.0f, 0.0f, 0.0f);
            clr[2] = new Vector3(0.2f, 0.9f, 1.0f);
            clr[3] = new Vector3(0.0f, 1.0f, 0.0f);

            var p = new Vector3[n];
            var z = 4.0f;
            p[0] = new Vector3(-1.0f, -1.0f, z);
            p[1] = new Vector3(1.0f, -1.0f, z);
            p[2] = new Vector3(1.0f, 1.0f, z);
            p[3] = new Vector3(-1.0f, 1.0f, z);

            DrawSimpleObject(p, clr, n, BeginMode.Polygon);
        }

        private void DrawTriangle()
        {
            var n = 4;
            var clr = new Vector3[n];
            clr[0] = new Vector3(1.0f, 1.0f, 0.0f);
            clr[1] = new Vector3(1.0f, 0.0f, 0.0f);
            clr[2] = new Vector3(0.2f, 0.9f, 1.0f);

            var p = new Vector3[n];
            var z = 4.0f;
            p[0] = new Vector3(-1.0f, -1.0f, z);
            p[1] = new Vector3(1.0f, -1.0f, z);
            p[2] = new Vector3(0.0f, 1.0f, z);

            DrawSimpleObject(p, clr, n, BeginMode.Triangles);
        }

        private void DrawSimpleObject(Vector3[] p, Vector3[] clr, int n, BeginMode bm)
        {
            GL.Begin(bm);
            for (var i = 0; i < n; i++)
            {
                GL.Color3(clr[i]);
                GL.Vertex3(p[i]);
            }
            GL.End();
        }

        [STAThread]
        static void Main()
        {
            using (var game = new Game())
            {
                game.Run(60.0);
            }
        }
    }
}

