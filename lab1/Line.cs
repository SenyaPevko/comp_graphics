using System.Drawing.Drawing2D;

namespace lab1;

public class Line(Graphics graphics, Color backColor)
{
    public Color LineColor { get; set; } = Color.Red;

    public float Width { get; set; } = 2f;

    public DashStyle DashStyleProp { get; set; } = DashStyle.Solid;

    public LineCap StartCap { get; set; } = LineCap.Round;

    public LineCap EndCap { get; set; } = LineCap.ArrowAnchor;

    public void Draw(int x1, int y1, int x2, int y2)
    {
        using var pen = new Pen(LineColor, Width);
        pen.DashStyle = DashStyleProp;
        pen.StartCap = StartCap;
        pen.EndCap = EndCap;
        graphics.DrawLine(pen, x1, y1, x2, y2);
    }

    public void Hide(int x1, int y1, int x2, int y2)
    {
        using var pen = new Pen(backColor, Width);
        pen.DashStyle = DashStyleProp;
        pen.StartCap = StartCap;
        pen.EndCap = EndCap;
        graphics.DrawLine(pen, x1, y1, x2, y2);
    }
}
