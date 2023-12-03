namespace Tyuiu.KhasanovRV.Sprint6.Task2.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonInfo_KRV = new System.Windows.Forms.Button();
            this.buttonRun_KRV = new System.Windows.Forms.Button();
            this.groupBoxInput_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_KRV = new System.Windows.Forms.TextBox();
            this.labelEnd_KRV = new System.Windows.Forms.Label();
            this.textBoxStart_KRV = new System.Windows.Forms.TextBox();
            this.labelStart_KRV = new System.Windows.Forms.Label();
            this.groupBoxOutput_KRV = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_KRV = new System.Windows.Forms.DataGridView();
            this.ColumnX_KRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY_KRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_KRV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInfo_KRV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KRV = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_KRV.SuspendLayout();
            this.groupBoxOutput_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRV)).BeginInit();
            this.groupBoxInfo_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo_KRV
            // 
            this.buttonInfo_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KRV.Location = new System.Drawing.Point(446, 367);
            this.buttonInfo_KRV.Name = "buttonInfo_KRV";
            this.buttonInfo_KRV.Size = new System.Drawing.Size(66, 70);
            this.buttonInfo_KRV.TabIndex = 17;
            this.buttonInfo_KRV.Text = "INFO";
            this.buttonInfo_KRV.UseVisualStyleBackColor = true;
            this.buttonInfo_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // buttonRun_KRV
            // 
            this.buttonRun_KRV.Location = new System.Drawing.Point(518, 366);
            this.buttonRun_KRV.Name = "buttonRun_KRV";
            this.buttonRun_KRV.Size = new System.Drawing.Size(184, 72);
            this.buttonRun_KRV.TabIndex = 16;
            this.buttonRun_KRV.Text = "Запуск";
            this.buttonRun_KRV.UseVisualStyleBackColor = true;
            this.buttonRun_KRV.Click += new System.EventHandler(this.buttonRun_KRV_Click);
            // 
            // groupBoxInput_KRV
            // 
            this.groupBoxInput_KRV.Controls.Add(this.textBoxEnd_KRV);
            this.groupBoxInput_KRV.Controls.Add(this.labelEnd_KRV);
            this.groupBoxInput_KRV.Controls.Add(this.textBoxStart_KRV);
            this.groupBoxInput_KRV.Controls.Add(this.labelStart_KRV);
            this.groupBoxInput_KRV.Location = new System.Drawing.Point(12, 359);
            this.groupBoxInput_KRV.Name = "groupBoxInput_KRV";
            this.groupBoxInput_KRV.Size = new System.Drawing.Size(428, 78);
            this.groupBoxInput_KRV.TabIndex = 13;
            this.groupBoxInput_KRV.TabStop = false;
            this.groupBoxInput_KRV.Text = "Ввод данных";
            // 
            // textBoxEnd_KRV
            // 
            this.textBoxEnd_KRV.Location = new System.Drawing.Point(185, 47);
            this.textBoxEnd_KRV.Name = "textBoxEnd_KRV";
            this.textBoxEnd_KRV.Size = new System.Drawing.Size(161, 22);
            this.textBoxEnd_KRV.TabIndex = 4;
            this.textBoxEnd_KRV.Text = "5";
            this.textBoxEnd_KRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_KRV_KeyPress);
            // 
            // labelEnd_KRV
            // 
            this.labelEnd_KRV.AutoSize = true;
            this.labelEnd_KRV.Location = new System.Drawing.Point(185, 28);
            this.labelEnd_KRV.Name = "labelEnd_KRV";
            this.labelEnd_KRV.Size = new System.Drawing.Size(84, 16);
            this.labelEnd_KRV.TabIndex = 3;
            this.labelEnd_KRV.Text = "Конец шага:";
            // 
            // textBoxStart_KRV
            // 
            this.textBoxStart_KRV.Location = new System.Drawing.Point(6, 47);
            this.textBoxStart_KRV.Name = "textBoxStart_KRV";
            this.textBoxStart_KRV.Size = new System.Drawing.Size(161, 22);
            this.textBoxStart_KRV.TabIndex = 2;
            this.textBoxStart_KRV.Text = "-5";
            this.textBoxStart_KRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_KRV_KeyPress);
            // 
            // labelStart_KRV
            // 
            this.labelStart_KRV.AutoSize = true;
            this.labelStart_KRV.Location = new System.Drawing.Point(6, 28);
            this.labelStart_KRV.Name = "labelStart_KRV";
            this.labelStart_KRV.Size = new System.Drawing.Size(83, 16);
            this.labelStart_KRV.TabIndex = 1;
            this.labelStart_KRV.Text = "Старт шага:";
            // 
            // groupBoxOutput_KRV
            // 
            this.groupBoxOutput_KRV.Controls.Add(this.dataGridViewFunction_KRV);
            this.groupBoxOutput_KRV.Controls.Add(this.chartFunction_KRV);
            this.groupBoxOutput_KRV.Location = new System.Drawing.Point(708, 12);
            this.groupBoxOutput_KRV.Name = "groupBoxOutput_KRV";
            this.groupBoxOutput_KRV.Size = new System.Drawing.Size(625, 426);
            this.groupBoxOutput_KRV.TabIndex = 15;
            this.groupBoxOutput_KRV.TabStop = false;
            this.groupBoxOutput_KRV.Text = "Вывод данных";
            // 
            // dataGridViewFunction_KRV
            // 
            this.dataGridViewFunction_KRV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFunction_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KRV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_KRV,
            this.ColumnY_KRV});
            this.dataGridViewFunction_KRV.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewFunction_KRV.Name = "dataGridViewFunction_KRV";
            this.dataGridViewFunction_KRV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFunction_KRV.RowHeadersVisible = false;
            this.dataGridViewFunction_KRV.RowHeadersWidth = 51;
            this.dataGridViewFunction_KRV.RowTemplate.Height = 24;
            this.dataGridViewFunction_KRV.Size = new System.Drawing.Size(213, 399);
            this.dataGridViewFunction_KRV.TabIndex = 4;
            // 
            // ColumnX_KRV
            // 
            this.ColumnX_KRV.HeaderText = "X";
            this.ColumnX_KRV.MinimumWidth = 6;
            this.ColumnX_KRV.Name = "ColumnX_KRV";
            this.ColumnX_KRV.ReadOnly = true;
            // 
            // ColumnY_KRV
            // 
            this.ColumnY_KRV.HeaderText = "F(X)";
            this.ColumnY_KRV.MinimumWidth = 6;
            this.ColumnY_KRV.Name = "ColumnY_KRV";
            this.ColumnY_KRV.ReadOnly = true;
            // 
            // chartFunction_KRV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KRV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_KRV.Legends.Add(legend1);
            this.chartFunction_KRV.Location = new System.Drawing.Point(225, 26);
            this.chartFunction_KRV.Name = "chartFunction_KRV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KRV.Series.Add(series1);
            this.chartFunction_KRV.Size = new System.Drawing.Size(394, 399);
            this.chartFunction_KRV.TabIndex = 3;
            this.chartFunction_KRV.Text = "chart1";
            // 
            // groupBoxInfo_KRV
            // 
            this.groupBoxInfo_KRV.Controls.Add(this.pictureBoxFormula_KRV);
            this.groupBoxInfo_KRV.Location = new System.Drawing.Point(12, 11);
            this.groupBoxInfo_KRV.Name = "groupBoxInfo_KRV";
            this.groupBoxInfo_KRV.Size = new System.Drawing.Size(690, 342);
            this.groupBoxInfo_KRV.TabIndex = 14;
            this.groupBoxInfo_KRV.TabStop = false;
            this.groupBoxInfo_KRV.Text = "Условие";
            // 
            // pictureBoxFormula_KRV
            // 
            this.pictureBoxFormula_KRV.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFormula_KRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxFormula_KRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFormula_KRV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KRV.Image")));
            this.pictureBoxFormula_KRV.Location = new System.Drawing.Point(9, 21);
            this.pictureBoxFormula_KRV.Name = "pictureBoxFormula_KRV";
            this.pictureBoxFormula_KRV.Size = new System.Drawing.Size(675, 315);
            this.pictureBoxFormula_KRV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_KRV.TabIndex = 1;
            this.pictureBoxFormula_KRV.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 450);
            this.Controls.Add(this.buttonInfo_KRV);
            this.Controls.Add(this.buttonRun_KRV);
            this.Controls.Add(this.groupBoxInput_KRV);
            this.Controls.Add(this.groupBoxOutput_KRV);
            this.Controls.Add(this.groupBoxInfo_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Хасанов Р. В.";
            this.groupBoxInput_KRV.ResumeLayout(false);
            this.groupBoxInput_KRV.PerformLayout();
            this.groupBoxOutput_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRV)).EndInit();
            this.groupBoxInfo_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo_KRV;
        private System.Windows.Forms.Button buttonRun_KRV;
        private System.Windows.Forms.GroupBox groupBoxInput_KRV;
        private System.Windows.Forms.TextBox textBoxEnd_KRV;
        private System.Windows.Forms.Label labelEnd_KRV;
        private System.Windows.Forms.TextBox textBoxStart_KRV;
        private System.Windows.Forms.Label labelStart_KRV;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRV;
        private System.Windows.Forms.GroupBox groupBoxInfo_KRV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KRV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRV;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_KRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY_KRV;
    }
}

