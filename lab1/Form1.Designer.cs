namespace lab1;

partial class Form1
{
    Graphics g;

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonsGroupBox = new GroupBox();
        buttonClearAll = new Button();
        buttonDraw = new Button();
        buttonErase = new Button();
        buttonEnableGraphics = new Button();
        comboBox1 = new ComboBox();
        messageGroupBox = new GroupBox();
        labelMessage = new Label();
        pictureGroupBox = new GroupBox();
        panelDraw = new Panel();
        paramsGroupBox = new GroupBox();
        lblLine = new Label();
        textBoxX1 = new TextBox();
        textBoxY1 = new TextBox();
        textBoxX2 = new TextBox();
        textBoxY2 = new TextBox();
        lblCenter = new Label();
        textBoxCenterX = new TextBox();
        textBoxCenterY = new TextBox();
        lblRadius = new Label();
        textBoxRadiusX = new TextBox();
        textBoxRadiusY = new TextBox();
        lblSides = new Label();
        textBoxSides = new TextBox();
        lblWidth = new Label();
        textBoxWidth = new TextBox();
        lblText = new Label();
        textBoxText = new TextBox();
        radioButtonRegular = new RadioButton();
        radioButtonArbitrary = new RadioButton();
        listBoxPoints = new ListBox();
        buttonAddPoint = new Button();
        lblPoint = new Label();
        textBoxPointX = new TextBox();
        textBoxPointY = new TextBox();
        buttonsGroupBox.SuspendLayout();
        messageGroupBox.SuspendLayout();
        pictureGroupBox.SuspendLayout();
        paramsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // buttonsGroupBox
        // 
        buttonsGroupBox.Controls.Add(buttonClearAll);
        buttonsGroupBox.Controls.Add(buttonDraw);
        buttonsGroupBox.Controls.Add(buttonErase);
        buttonsGroupBox.Controls.Add(buttonEnableGraphics);
        buttonsGroupBox.Controls.Add(comboBox1);
        buttonsGroupBox.Location = new Point(12, 12);
        buttonsGroupBox.Name = "buttonsGroupBox";
        buttonsGroupBox.Size = new Size(300, 257);
        buttonsGroupBox.TabIndex = 0;
        buttonsGroupBox.TabStop = false;
        buttonsGroupBox.Text = "Кнопки";
        // 
        // buttonClearAll
        // 
        buttonClearAll.Location = new Point(54, 202);
        buttonClearAll.Name = "buttonClearAll";
        buttonClearAll.Size = new Size(182, 34);
        buttonClearAll.TabIndex = 3;
        buttonClearAll.Text = "Очистить все";
        buttonClearAll.UseVisualStyleBackColor = true;
        buttonClearAll.Click += ButtonClearAllClick;
        // 
        // buttonDraw
        // 
        buttonDraw.Location = new Point(54, 114);
        buttonDraw.Name = "buttonDraw";
        buttonDraw.Size = new Size(182, 34);
        buttonDraw.TabIndex = 2;
        buttonDraw.Text = "Рисовать";
        buttonDraw.UseVisualStyleBackColor = true;
        buttonDraw.Click += ButtonDrawClick;
        // 
        // buttonErase
        // 
        buttonErase.Location = new Point(54, 158);
        buttonErase.Name = "buttonErase";
        buttonErase.Size = new Size(182, 34);
        buttonErase.TabIndex = 1;
        buttonErase.Text = "Стереть";
        buttonErase.UseVisualStyleBackColor = true;
        buttonErase.Click += ButtonEraseClick;
        // 
        // buttonEnableGraphics
        // 
        buttonEnableGraphics.Location = new Point(54, 72);
        buttonEnableGraphics.Name = "buttonEnableGraphics";
        buttonEnableGraphics.Size = new Size(182, 34);
        buttonEnableGraphics.TabIndex = 0;
        buttonEnableGraphics.Text = "Вкл графику";
        buttonEnableGraphics.UseVisualStyleBackColor = true;
        buttonEnableGraphics.Click += ButtonEnableGraphicsClick;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Line", "Ellipse", "Polygon" });
        comboBox1.Location = new Point(54, 27);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(182, 33);
        comboBox1.TabIndex = 0;
        // 
        // messageGroupBox
        // 
        messageGroupBox.Controls.Add(labelMessage);
        messageGroupBox.Location = new Point(12, 734);
        messageGroupBox.Name = "messageGroupBox";
        messageGroupBox.Size = new Size(1124, 161);
        messageGroupBox.TabIndex = 2;
        messageGroupBox.TabStop = false;
        messageGroupBox.Text = "Сообщения";
        // 
        // labelMessage
        // 
        labelMessage.AutoSize = true;
        labelMessage.Location = new Point(33, 27);
        labelMessage.Name = "labelMessage";
        labelMessage.Size = new Size(59, 25);
        labelMessage.TabIndex = 0;
        labelMessage.Text = "label1";
        // 
        // pictureGroupBox
        // 
        pictureGroupBox.Controls.Add(panelDraw);
        pictureGroupBox.Location = new Point(489, 39);
        pictureGroupBox.Name = "pictureGroupBox";
        pictureGroupBox.Size = new Size(647, 676);
        pictureGroupBox.TabIndex = 1;
        pictureGroupBox.TabStop = false;
        pictureGroupBox.Text = "Картинка";
        // 
        // panelDraw
        // 
        panelDraw.BorderStyle = BorderStyle.FixedSingle;
        panelDraw.Location = new Point(34, 59);
        panelDraw.Name = "panelDraw";
        panelDraw.Size = new Size(585, 591);
        panelDraw.TabIndex = 0;
        // 
        // paramsGroupBox
        // 
        paramsGroupBox.Controls.Add(lblLine);
        paramsGroupBox.Controls.Add(textBoxX1);
        paramsGroupBox.Controls.Add(textBoxY1);
        paramsGroupBox.Controls.Add(textBoxX2);
        paramsGroupBox.Controls.Add(textBoxY2);
        paramsGroupBox.Controls.Add(lblCenter);
        paramsGroupBox.Controls.Add(textBoxCenterX);
        paramsGroupBox.Controls.Add(textBoxCenterY);
        paramsGroupBox.Controls.Add(lblRadius);
        paramsGroupBox.Controls.Add(textBoxRadiusX);
        paramsGroupBox.Controls.Add(textBoxRadiusY);
        paramsGroupBox.Controls.Add(lblSides);
        paramsGroupBox.Controls.Add(textBoxSides);
        paramsGroupBox.Controls.Add(lblWidth);
        paramsGroupBox.Controls.Add(textBoxWidth);
        paramsGroupBox.Controls.Add(lblText);
        paramsGroupBox.Controls.Add(textBoxText);
        paramsGroupBox.Controls.Add(radioButtonRegular);
        paramsGroupBox.Controls.Add(radioButtonArbitrary);
        paramsGroupBox.Controls.Add(listBoxPoints);
        paramsGroupBox.Controls.Add(buttonAddPoint);
        paramsGroupBox.Controls.Add(lblPoint);
        paramsGroupBox.Controls.Add(textBoxPointX);
        paramsGroupBox.Controls.Add(textBoxPointY);
        paramsGroupBox.Location = new Point(12, 288);
        paramsGroupBox.Name = "paramsGroupBox";
        paramsGroupBox.Size = new Size(343, 427);
        paramsGroupBox.TabIndex = 3;
        paramsGroupBox.TabStop = false;
        paramsGroupBox.Text = "Параметры";
        // 
        // lblLine
        // 
        lblLine.Location = new Point(10, 21);
        lblLine.Name = "lblLine";
        lblLine.Size = new Size(125, 23);
        lblLine.TabIndex = 0;
        lblLine.Text = "(x1,y1)-(x2,y2)";
        // 
        // textBoxX1
        // 
        textBoxX1.Location = new Point(10, 48);
        textBoxX1.Name = "textBoxX1";
        textBoxX1.Size = new Size(50, 31);
        textBoxX1.TabIndex = 1;
        textBoxX1.Text = "0";
        // 
        // textBoxY1
        // 
        textBoxY1.Location = new Point(63, 48);
        textBoxY1.Name = "textBoxY1";
        textBoxY1.Size = new Size(50, 31);
        textBoxY1.TabIndex = 2;
        textBoxY1.Text = "0";
        // 
        // textBoxX2
        // 
        textBoxX2.Location = new Point(117, 47);
        textBoxX2.Name = "textBoxX2";
        textBoxX2.Size = new Size(50, 31);
        textBoxX2.TabIndex = 3;
        textBoxX2.Text = "200";
        // 
        // textBoxY2
        // 
        textBoxY2.Location = new Point(174, 47);
        textBoxY2.Name = "textBoxY2";
        textBoxY2.Size = new Size(50, 31);
        textBoxY2.TabIndex = 4;
        textBoxY2.Text = "200";
        // 
        // lblCenter
        // 
        lblCenter.Location = new Point(136, 118);
        lblCenter.Name = "lblCenter";
        lblCenter.Size = new Size(100, 23);
        lblCenter.TabIndex = 5;
        lblCenter.Text = "Центр (x,y)";
        // 
        // textBoxCenterX
        // 
        textBoxCenterX.Location = new Point(10, 127);
        textBoxCenterX.Name = "textBoxCenterX";
        textBoxCenterX.Size = new Size(50, 31);
        textBoxCenterX.TabIndex = 6;
        textBoxCenterX.Text = "100";
        // 
        // textBoxCenterY
        // 
        textBoxCenterY.Location = new Point(70, 127);
        textBoxCenterY.Name = "textBoxCenterY";
        textBoxCenterY.Size = new Size(50, 31);
        textBoxCenterY.TabIndex = 7;
        textBoxCenterY.Text = "100";
        // 
        // lblRadius
        // 
        lblRadius.Location = new Point(136, 160);
        lblRadius.Name = "lblRadius";
        lblRadius.Size = new Size(100, 23);
        lblRadius.TabIndex = 8;
        lblRadius.Text = "Радиусы (rx,ry)";
        // 
        // textBoxRadiusX
        // 
        textBoxRadiusX.Location = new Point(10, 157);
        textBoxRadiusX.Name = "textBoxRadiusX";
        textBoxRadiusX.Size = new Size(50, 31);
        textBoxRadiusX.TabIndex = 9;
        textBoxRadiusX.Text = "50";
        // 
        // textBoxRadiusY
        // 
        textBoxRadiusY.Location = new Point(70, 157);
        textBoxRadiusY.Name = "textBoxRadiusY";
        textBoxRadiusY.Size = new Size(50, 31);
        textBoxRadiusY.TabIndex = 10;
        textBoxRadiusY.Text = "50";
        // 
        // lblSides
        // 
        lblSides.Location = new Point(70, 187);
        lblSides.Name = "lblSides";
        lblSides.Size = new Size(100, 23);
        lblSides.TabIndex = 11;
        lblSides.Text = "Стороны n";
        // 
        // textBoxSides
        // 
        textBoxSides.Location = new Point(10, 187);
        textBoxSides.Name = "textBoxSides";
        textBoxSides.Size = new Size(50, 31);
        textBoxSides.TabIndex = 12;
        textBoxSides.Text = "5";
        // 
        // lblWidth
        // 
        lblWidth.Location = new Point(70, 217);
        lblWidth.Name = "lblWidth";
        lblWidth.Size = new Size(100, 23);
        lblWidth.TabIndex = 13;
        lblWidth.Text = "Толщина";
        // 
        // textBoxWidth
        // 
        textBoxWidth.Location = new Point(10, 217);
        textBoxWidth.Name = "textBoxWidth";
        textBoxWidth.Size = new Size(50, 31);
        textBoxWidth.TabIndex = 14;
        textBoxWidth.Text = "2";
        // 
        // lblText
        // 
        lblText.Location = new Point(117, 257);
        lblText.Name = "lblText";
        lblText.Size = new Size(139, 23);
        lblText.TabIndex = 15;
        lblText.Text = "Текст подписи";
        // 
        // textBoxText
        // 
        textBoxText.Location = new Point(10, 254);
        textBoxText.Name = "textBoxText";
        textBoxText.Size = new Size(100, 31);
        textBoxText.TabIndex = 16;
        textBoxText.Text = "Ellipse";
        // 
        // radioButtonRegular
        // 
        radioButtonRegular.Checked = true;
        radioButtonRegular.Location = new Point(6, 298);
        radioButtonRegular.Name = "radioButtonRegular";
        radioButtonRegular.Size = new Size(143, 28);
        radioButtonRegular.TabIndex = 17;
        radioButtonRegular.TabStop = true;
        radioButtonRegular.Text = "Правильный";
        // 
        // radioButtonArbitrary
        // 
        radioButtonArbitrary.Location = new Point(147, 298);
        radioButtonArbitrary.Name = "radioButtonArbitrary";
        radioButtonArbitrary.Size = new Size(147, 28);
        radioButtonArbitrary.TabIndex = 18;
        radioButtonArbitrary.Text = "Произвольный";
        // 
        // listBoxPoints
        // 
        listBoxPoints.Location = new Point(6, 353);
        listBoxPoints.Name = "listBoxPoints";
        listBoxPoints.Size = new Size(118, 29);
        listBoxPoints.TabIndex = 19;
        // 
        // buttonAddPoint
        // 
        buttonAddPoint.Location = new Point(130, 352);
        buttonAddPoint.Name = "buttonAddPoint";
        buttonAddPoint.Size = new Size(164, 30);
        buttonAddPoint.TabIndex = 20;
        buttonAddPoint.Text = "Добавить точку";
        buttonAddPoint.Click += ButtonAddPointClick;
        // 
        // lblPoint
        // 
        lblPoint.Location = new Point(124, 385);
        lblPoint.Name = "lblPoint";
        lblPoint.Size = new Size(100, 23);
        lblPoint.TabIndex = 21;
        lblPoint.Text = "(px,py)";
        // 
        // textBoxPointX
        // 
        textBoxPointX.Location = new Point(-2, 385);
        textBoxPointX.Name = "textBoxPointX";
        textBoxPointX.Size = new Size(50, 31);
        textBoxPointX.TabIndex = 22;
        textBoxPointX.Text = "0";
        // 
        // textBoxPointY
        // 
        textBoxPointY.Location = new Point(54, 385);
        textBoxPointY.Name = "textBoxPointY";
        textBoxPointY.Size = new Size(50, 31);
        textBoxPointY.TabIndex = 23;
        textBoxPointY.Text = "0";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1179, 907);
        Controls.Add(paramsGroupBox);
        Controls.Add(messageGroupBox);
        Controls.Add(pictureGroupBox);
        Controls.Add(buttonsGroupBox);
        Name = "Form1";
        Text = "Form1";
        buttonsGroupBox.ResumeLayout(false);
        messageGroupBox.ResumeLayout(false);
        messageGroupBox.PerformLayout();
        pictureGroupBox.ResumeLayout(false);
        paramsGroupBox.ResumeLayout(false);
        paramsGroupBox.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox buttonsGroupBox;
    private Button buttonDraw;
    private Button buttonErase;
    private Button buttonEnableGraphics;
    private GroupBox messageGroupBox;
    private Label labelMessage;
    private GroupBox pictureGroupBox;
    private Panel panelDraw;
    private ComboBox comboBox1;
    private Button buttonClearAll;
    private GroupBox paramsGroupBox;

    private TextBox textBoxX1, textBoxY1, textBoxX2, textBoxY2;
    private TextBox textBoxCenterX, textBoxCenterY, textBoxRadiusX, textBoxRadiusY, textBoxSides;
    private TextBox textBoxWidth, textBoxText;
    private TextBox textBoxPointX, textBoxPointY;
    private RadioButton radioButtonRegular, radioButtonArbitrary;
    private ListBox listBoxPoints;
    private Button buttonAddPoint;
    private Label lblLine;
    private Label lblCenter;
    private Label lblRadius;
    private Label lblSides;
    private Label lblWidth;
    private Label lblText;
    private Label lblPoint;
}