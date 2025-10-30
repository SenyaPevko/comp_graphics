namespace lab1;

public class Ellipse(Graphics graphics, Color backColor)
{
    public Point Center { get; set; }
    public int RadiusX { get; set; }

    public int RadiusY { get; set; }

    public Color OutlineColor { get; set; } = Color.Green;

    public Color FillColor { get; set; } = Color.Blue;

    public string Text { get; set; } = "";

    public Font Font { get; set; } = new("Arial", 8);

    public void Draw()
    {
        var left = Center.X - RadiusX;
        var top = Center.Y - RadiusY;
        
        using var pen = new Pen(OutlineColor, 2);
        using var brush = new SolidBrush(FillColor);
        graphics.DrawEllipse(pen, left, top, RadiusX * 2, RadiusY * 2);
        graphics.FillEllipse(brush, left, top, RadiusX * 2, RadiusY * 2);
        graphics.DrawString(Text, Font, new SolidBrush(Color.Black), new PointF(Center.X - 20, Center.Y - 10));
    }

    public void Hide()
    {
        var left = Center.X - RadiusX;
        var top = Center.Y - RadiusY;
        
        using var brush = new SolidBrush(backColor);
        graphics.FillRectangle(brush, left, top, RadiusX * 2, RadiusY * 2); 
    }
}