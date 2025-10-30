namespace lab1;

public class Polygon(Graphics graphics, Color backColor)
{
    public Point Center {get; set;}

    public int Sides { get; set; } = 5;

    public PointF[] Points { get; set; }

    public Color OutlineColor { get; set; } = Color.Black;

    public Color FillColor { get; set; } = Color.Yellow;

    public float Width { get; set; } = 2f;

    public void Draw(PolygonType type = PolygonType.Regular, int radius = 50)
    {
        PointF[] pts;
        if (type == PolygonType.Arbitrary && Points.Length > 0)
        {
            pts = Points;
        }
        else
        {
            pts = new PointF[Sides];
            var angle = 2 * Math.PI / Sides;
            for (var i = 0; i < Sides; i++)
            {
                var rad = angle * i;
                pts[i] = new PointF(
                    (float)(Center.X + radius * Math.Cos(rad)),
                    (float)(Center.Y + radius * Math.Sin(rad))
                );
            }
        }

        using var pen = new Pen(OutlineColor, Width);
        using var brush = new SolidBrush(FillColor);
        graphics.DrawPolygon(pen, pts);
        graphics.FillPolygon(brush, pts);
    }

    public void Hide(PolygonType type = PolygonType.Regular, int radius = 50)
    {
        PointF[] pts;
        if (type == PolygonType.Arbitrary && Points.Length > 0)
        {
            pts = Points;
        }
        else
        {
            pts = new PointF[Sides];
            var angle = 2 * Math.PI / Sides;
            for (var i = 0; i < Sides; i++)
            {
                var rad = angle * i;
                pts[i] = new PointF(
                    (float)(Center.X + radius * Math.Cos(rad)),
                    (float)(Center.Y + radius * Math.Sin(rad))
                );
            }
        }

        using var brush = new SolidBrush(backColor);
        graphics.FillPolygon(brush, pts);
    }
}

public enum PolygonType
{
    Regular,
    Arbitrary
}
