namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxFormula1 = new System.Windows.Forms.TextBox();
            this.textBoxFormula2 = new System.Windows.Forms.TextBox();
            this.labelFormula1 = new System.Windows.Forms.Label();
            this.labelFormula2 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFormula1
            // 
            this.textBoxFormula1.Location = new System.Drawing.Point(12, 744);
            this.textBoxFormula1.Name = "textBoxFormula1";
            this.textBoxFormula1.Size = new System.Drawing.Size(1007, 26);
            this.textBoxFormula1.TabIndex = 0;
            // 
            // textBoxFormula2
            // 
            this.textBoxFormula2.Location = new System.Drawing.Point(12, 811);
            this.textBoxFormula2.Name = "textBoxFormula2";
            this.textBoxFormula2.Size = new System.Drawing.Size(1007, 26);
            this.textBoxFormula2.TabIndex = 1;
            // 
            // labelFormula1
            // 
            this.labelFormula1.AutoSize = true;
            this.labelFormula1.Location = new System.Drawing.Point(12, 717);
            this.labelFormula1.Name = "labelFormula1";
            this.labelFormula1.Size = new System.Drawing.Size(92, 20);
            this.labelFormula1.TabIndex = 2;
            this.labelFormula1.Text = "Формула 1";
            // 
            // labelFormula2
            // 
            this.labelFormula2.AutoSize = true;
            this.labelFormula2.Location = new System.Drawing.Point(12, 784);
            this.labelFormula2.Name = "labelFormula2";
            this.labelFormula2.Size = new System.Drawing.Size(92, 20);
            this.labelFormula2.TabIndex = 3;
            this.labelFormula2.Text = "Формула 2";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(386, 850);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(206, 44);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Нарисовать графики";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.ButtonDrawClick);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 24);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1007, 649);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 902);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelFormula2);
            this.Controls.Add(this.labelFormula1);
            this.Controls.Add(this.textBoxFormula2);
            this.Controls.Add(this.textBoxFormula1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFormula1;
        private System.Windows.Forms.TextBox textBoxFormula2;
        private System.Windows.Forms.Label labelFormula1;
        private System.Windows.Forms.Label labelFormula2;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

