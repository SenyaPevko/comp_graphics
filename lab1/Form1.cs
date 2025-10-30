namespace lab1;

public partial class Form1 : Form
{
    private Line line;
    private Ellipse ellipse;
    private Polygon polygon;
    private Color backColor;

    public Form1()
    {
        InitializeComponent();
        backColor = panelDraw.BackColor;
        listBoxPoints.Items.Clear();
    }

    private void ButtonEnableGraphicsClick(object sender, EventArgs e)
    {
        g = panelDraw.CreateGraphics();
        line = new Line(g, backColor);
        ellipse = new Ellipse(g, backColor);
        polygon = new Polygon(g, backColor);
        buttonEnableGraphics.Enabled = false;
        labelMessage.Text = "Графика включена";
    }

    private void ButtonDrawClick(object sender, EventArgs e)
    {
        if (g == null)
            return;

        var selectedType = comboBox1.SelectedItem?.ToString() ?? "Line";
        switch (selectedType)
        {
            case "Line":
                var x1 = GetIntFromTextBox(textBoxX1, 0);
                var y1 = GetIntFromTextBox(textBoxY1, 0);
                var x2 = GetIntFromTextBox(textBoxX2, panelDraw.Width);
                var y2 = GetIntFromTextBox(textBoxY2, panelDraw.Height);
                line.LineColor = Color.Red;
                line.Width = GetFloatFromTextBox(textBoxWidth, 2f);
                line.Draw(x1, y1, x2, y2);
                break;
            case "Ellipse":
                var centerX = GetIntFromTextBox(textBoxCenterX, 100);
                var centerY = GetIntFromTextBox(textBoxCenterY, 100);
                ellipse.Center = new Point(centerX, centerY);
                ellipse.RadiusX = GetIntFromTextBox(textBoxRadiusX, 50);
                ellipse.RadiusY = GetIntFromTextBox(textBoxRadiusY, 50);
                ellipse.OutlineColor = Color.Green;
                ellipse.FillColor = Color.Blue;
                ellipse.Text = textBoxText.Text ?? "";
                ellipse.Draw();
                break;
            case "Polygon":
                var polyCenterX = GetIntFromTextBox(textBoxCenterX, 200);
                var polyCenterY = GetIntFromTextBox(textBoxCenterY, 200);
                polygon.Center = new Point(polyCenterX, polyCenterY);
                polygon.Sides = GetIntFromTextBox(textBoxSides, 5);
                polygon.Width = GetFloatFromTextBox(textBoxWidth, 2f);
                polygon.OutlineColor = Color.Black;
                polygon.FillColor = Color.Yellow;
                var polyRadius = GetIntFromTextBox(textBoxRadiusX, 50);
                if (radioButtonArbitrary.Checked)
                {
                    var count = listBoxPoints.Items.Count;
                    if (count > 2)
                    {
                        polygon.Points = new PointF[count];
                        for (var i = 0; i < count; i++)
                        {
                            var s = listBoxPoints.Items[i].ToString();
                            var a = s.Split(' ');
                            polygon.Points[i] = new PointF(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]));
                        }
                        polygon.Draw(PolygonType.Arbitrary);
                    }
                }
                else
                {
                    polygon.Draw(PolygonType.Regular, polyRadius);
                }
                break;
        }
        labelMessage.Text = $"{selectedType} нарисован";
    }

    private void ButtonEraseClick(object sender, EventArgs e)
    {
        if (g == null)
            return;

        var selectedType = comboBox1.SelectedItem?.ToString() ?? "Line";
        switch (selectedType)
        {
            case "Line":
                var x1 = GetIntFromTextBox(textBoxX1, 0);
                var y1 = GetIntFromTextBox(textBoxY1, 0);
                var x2 = GetIntFromTextBox(textBoxX2, panelDraw.Width);
                var y2 = GetIntFromTextBox(textBoxY2, panelDraw.Height);
                line.Hide(x1, y1, x2, y2);
                break;
            case "Ellipse":
                var centerX = GetIntFromTextBox(textBoxCenterX, 100);
                var centerY = GetIntFromTextBox(textBoxCenterY, 100);
                ellipse.Center = new Point(centerX, centerY);
                ellipse.RadiusX = GetIntFromTextBox(textBoxRadiusX, 50);
                ellipse.RadiusY = GetIntFromTextBox(textBoxRadiusY, 50);
                ellipse.Hide();
                break;
            case "Polygon":
                var polyCenterX = GetIntFromTextBox(textBoxCenterX, 200);
                var polyCenterY = GetIntFromTextBox(textBoxCenterY, 200);
                polygon.Center = new Point(polyCenterX, polyCenterY);
                polygon.Sides = GetIntFromTextBox(textBoxSides, 5);
                var polyRadius = GetIntFromTextBox(textBoxRadiusX, 50);
                if (radioButtonArbitrary.Checked)
                {
                    var count = listBoxPoints.Items.Count;
                    if (count > 2)
                    {
                        polygon.Points = new PointF[count];
                        for (var i = 0; i < count; i++)
                        {
                            var s = listBoxPoints.Items[i].ToString();
                            var a = s.Split(' ');
                            polygon.Points[i] = new PointF(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]));
                        }
                        polygon.Hide(PolygonType.Arbitrary);
                    }
                }
                else
                {
                    polygon.Hide(PolygonType.Regular, polyRadius);
                }
                break;
        }
        labelMessage.Text = $"{selectedType} стерт";
    }

    private void ButtonAddPointClick(object sender, EventArgs e)
    {
        if (g == null) 
            return;

        var px = GetIntFromTextBox(textBoxPointX, 0);
        var py = GetIntFromTextBox(textBoxPointY, 0);
        listBoxPoints.Items.Add($"{px} {py}");
        labelMessage.Text = "Точка добавлена";
    }

    private void ButtonClearAllClick(object sender, EventArgs e)
    {
        if (g == null) 
            return;

        using var brush = new SolidBrush(backColor);
        g.FillRectangle(brush, 0, 0, panelDraw.Width, panelDraw.Height);
        labelMessage.Text = "Все очищено";
    }

    private int GetIntFromTextBox(TextBox tb, int defaultVal)
    {
        return int.TryParse(tb.Text, out int val) ? val : defaultVal;
    }

    private float GetFloatFromTextBox(TextBox tb, float defaultVal)
    {
        return float.TryParse(tb.Text, out var val) ? val : defaultVal;
    }
}