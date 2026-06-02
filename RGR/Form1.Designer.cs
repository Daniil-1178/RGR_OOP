namespace RGR
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbFunctions = new System.Windows.Forms.ComboBox();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numXMin = new System.Windows.Forms.NumericUpDown();
            this.numXMax = new System.Windows.Forms.NumericUpDown();
            this.lblEquation = new System.Windows.Forms.Label();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFunctions
            // 
            this.cmbFunctions.FormattingEnabled = true;
            this.cmbFunctions.Location = new System.Drawing.Point(12, 25);
            this.cmbFunctions.Name = "cmbFunctions";
            this.cmbFunctions.Size = new System.Drawing.Size(181, 21);
            this.cmbFunctions.TabIndex = 0;
            this.cmbFunctions.SelectedIndexChanged += new System.EventHandler(this.cmbFunctions_SelectedIndexChanged);
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(12, 112);
            this.numA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(120, 20);
            this.numA.TabIndex = 1;
            this.numA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numA.ValueChanged += new System.EventHandler(this.numValues_ValueChanged);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(12, 164);
            this.numB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(120, 20);
            this.numB.TabIndex = 2;
            this.numB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numB.ValueChanged += new System.EventHandler(this.numValues_ValueChanged);
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(12, 219);
            this.numC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(120, 20);
            this.numC.TabIndex = 3;
            this.numC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numC.ValueChanged += new System.EventHandler(this.numValues_ValueChanged);
            // 
            // numXMin
            // 
            this.numXMin.Location = new System.Drawing.Point(12, 277);
            this.numXMin.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numXMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numXMin.Name = "numXMin";
            this.numXMin.Size = new System.Drawing.Size(120, 20);
            this.numXMin.TabIndex = 4;
            this.numXMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numXMin.ValueChanged += new System.EventHandler(this.numValues_ValueChanged);
            // 
            // numXMax
            // 
            this.numXMax.Location = new System.Drawing.Point(15, 337);
            this.numXMax.Name = "numXMax";
            this.numXMax.Size = new System.Drawing.Size(120, 20);
            this.numXMax.TabIndex = 5;
            this.numXMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numXMax.ValueChanged += new System.EventHandler(this.numValues_ValueChanged);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEquation.Location = new System.Drawing.Point(12, 63);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(0, 16);
            this.lblEquation.TabIndex = 6;
            // 
            // chartGraph
            // 
            this.chartGraph.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartGraph.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chartGraph.BorderlineColor = System.Drawing.Color.Black;
            this.chartGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph.Legends.Add(legend1);
            this.chartGraph.Location = new System.Drawing.Point(245, 27);
            this.chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(697, 439);
            this.chartGraph.TabIndex = 7;
            this.chartGraph.Text = "chart1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(162, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Оберіть математичну функцію:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Коефіцієнт a";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 148);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(70, 13);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Коефіцієнт b";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(12, 203);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(70, 13);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "Коефіцієнт c";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(12, 261);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(130, 13);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "Інтервал побудови X min";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(12, 321);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(133, 13);
            this.lbl6.TabIndex = 13;
            this.lbl6.Text = "Інтервал побудови X max";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7.Location = new System.Drawing.Point(559, 5);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(57, 16);
            this.lbl7.TabIndex = 14;
            this.lbl7.Text = "Графік";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(972, 493);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.numXMax);
            this.Controls.Add(this.numXMin);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.cmbFunctions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графіки";
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFunctions;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numXMin;
        private System.Windows.Forms.NumericUpDown numXMax;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
    }
}

