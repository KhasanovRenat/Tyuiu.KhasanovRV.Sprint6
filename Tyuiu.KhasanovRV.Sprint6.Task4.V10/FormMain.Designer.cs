namespace Tyuiu.KhasanovRV.Sprint6.Task4.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxInfo_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_KRV = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_KRV = new System.Windows.Forms.TextBox();
            this.textBoxStart_KRV = new System.Windows.Forms.TextBox();
            this.labelStart_KRV = new System.Windows.Forms.Label();
            this.labelEnd_KRV = new System.Windows.Forms.Label();
            this.buttonSave_KRV = new System.Windows.Forms.Button();
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonWiki_KRV = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KRV = new System.Windows.Forms.GroupBox();
            this.chartGraph_KRV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxOutPut_KRV = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_KRV.SuspendLayout();
            this.groupBoxInPut_KRV.SuspendLayout();
            this.groupBoxOutPut_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_KRV
            // 
            this.groupBoxInfo_KRV.Controls.Add(this.textBoxInfo_KRV);
            this.groupBoxInfo_KRV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_KRV.Name = "groupBoxInfo_KRV";
            this.groupBoxInfo_KRV.Size = new System.Drawing.Size(505, 91);
            this.groupBoxInfo_KRV.TabIndex = 0;
            this.groupBoxInfo_KRV.TabStop = false;
            this.groupBoxInfo_KRV.Text = "Условие";
            // 
            // textBoxInfo_KRV
            // 
            this.textBoxInfo_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInfo_KRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_KRV.Location = new System.Drawing.Point(6, 18);
            this.textBoxInfo_KRV.Multiline = true;
            this.textBoxInfo_KRV.Name = "textBoxInfo_KRV";
            this.textBoxInfo_KRV.ReadOnly = true;
            this.textBoxInfo_KRV.Size = new System.Drawing.Size(496, 67);
            this.textBoxInfo_KRV.TabIndex = 0;
            this.textBoxInfo_KRV.Text = resources.GetString("textBoxInfo_KRV.Text");
            // 
            // groupBoxInPut_KRV
            // 
            this.groupBoxInPut_KRV.Controls.Add(this.labelEnd_KRV);
            this.groupBoxInPut_KRV.Controls.Add(this.labelStart_KRV);
            this.groupBoxInPut_KRV.Controls.Add(this.textBoxEnd_KRV);
            this.groupBoxInPut_KRV.Controls.Add(this.textBoxStart_KRV);
            this.groupBoxInPut_KRV.Location = new System.Drawing.Point(523, 12);
            this.groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            this.groupBoxInPut_KRV.Size = new System.Drawing.Size(331, 91);
            this.groupBoxInPut_KRV.TabIndex = 0;
            this.groupBoxInPut_KRV.TabStop = false;
            this.groupBoxInPut_KRV.Text = "Ввод данных";
            // 
            // textBoxEnd_KRV
            // 
            this.textBoxEnd_KRV.Location = new System.Drawing.Point(135, 48);
            this.textBoxEnd_KRV.Name = "textBoxEnd_KRV";
            this.textBoxEnd_KRV.Size = new System.Drawing.Size(123, 22);
            this.textBoxEnd_KRV.TabIndex = 0;
            this.textBoxEnd_KRV.Text = "5";
            // 
            // textBoxStart_KRV
            // 
            this.textBoxStart_KRV.Location = new System.Drawing.Point(6, 48);
            this.textBoxStart_KRV.Name = "textBoxStart_KRV";
            this.textBoxStart_KRV.Size = new System.Drawing.Size(123, 22);
            this.textBoxStart_KRV.TabIndex = 0;
            this.textBoxStart_KRV.Text = "-5";
            // 
            // labelStart_KRV
            // 
            this.labelStart_KRV.AutoSize = true;
            this.labelStart_KRV.Location = new System.Drawing.Point(6, 29);
            this.labelStart_KRV.Name = "labelStart_KRV";
            this.labelStart_KRV.Size = new System.Drawing.Size(83, 16);
            this.labelStart_KRV.TabIndex = 1;
            this.labelStart_KRV.Text = "Старт шага:";
            // 
            // labelEnd_KRV
            // 
            this.labelEnd_KRV.AutoSize = true;
            this.labelEnd_KRV.Location = new System.Drawing.Point(132, 29);
            this.labelEnd_KRV.Name = "labelEnd_KRV";
            this.labelEnd_KRV.Size = new System.Drawing.Size(84, 16);
            this.labelEnd_KRV.TabIndex = 1;
            this.labelEnd_KRV.Text = "Конец шага:";
            // 
            // buttonSave_KRV
            // 
            this.buttonSave_KRV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_KRV.Location = new System.Drawing.Point(987, 30);
            this.buttonSave_KRV.Name = "buttonSave_KRV";
            this.buttonSave_KRV.Size = new System.Drawing.Size(121, 69);
            this.buttonSave_KRV.TabIndex = 1;
            this.buttonSave_KRV.Text = "Сохранить";
            this.buttonSave_KRV.UseVisualStyleBackColor = false;
            this.buttonSave_KRV.Click += new System.EventHandler(this.buttonSave_KRV_Click);
            // 
            // buttonDone_KRV
            // 
            this.buttonDone_KRV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KRV.Location = new System.Drawing.Point(860, 30);
            this.buttonDone_KRV.Name = "buttonDone_KRV";
            this.buttonDone_KRV.Size = new System.Drawing.Size(121, 69);
            this.buttonDone_KRV.TabIndex = 1;
            this.buttonDone_KRV.Text = "Выполнить";
            this.buttonDone_KRV.UseVisualStyleBackColor = false;
            this.buttonDone_KRV.Click += new System.EventHandler(this.buttonDone_KRV_Click);
            // 
            // buttonWiki_KRV
            // 
            this.buttonWiki_KRV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonWiki_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.buttonWiki_KRV.Location = new System.Drawing.Point(1114, 29);
            this.buttonWiki_KRV.Name = "buttonWiki_KRV";
            this.buttonWiki_KRV.Size = new System.Drawing.Size(69, 69);
            this.buttonWiki_KRV.TabIndex = 1;
            this.buttonWiki_KRV.Text = "?";
            this.buttonWiki_KRV.UseVisualStyleBackColor = false;
            this.buttonWiki_KRV.Click += new System.EventHandler(this.buttonWiki_KRV_Click);
            // 
            // groupBoxOutPut_KRV
            // 
            this.groupBoxOutPut_KRV.Controls.Add(this.textBoxOutPut_KRV);
            this.groupBoxOutPut_KRV.Location = new System.Drawing.Point(12, 109);
            this.groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            this.groupBoxOutPut_KRV.Size = new System.Drawing.Size(505, 647);
            this.groupBoxOutPut_KRV.TabIndex = 2;
            this.groupBoxOutPut_KRV.TabStop = false;
            this.groupBoxOutPut_KRV.Text = "Вывод данных";
            // 
            // chartGraph_KRV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph_KRV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartGraph_KRV.Legends.Add(legend1);
            this.chartGraph_KRV.Location = new System.Drawing.Point(523, 109);
            this.chartGraph_KRV.Name = "chartGraph_KRV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph_KRV.Series.Add(series1);
            this.chartGraph_KRV.Size = new System.Drawing.Size(660, 647);
            this.chartGraph_KRV.TabIndex = 3;
            this.chartGraph_KRV.Text = "График функции F(x)";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.MediumBlue;
            title1.Name = "TitleFunc_KRV";
            title1.Text = "График функции F(x)";
            this.chartGraph_KRV.Titles.Add(title1);
            // 
            // textBoxOutPut_KRV
            // 
            this.textBoxOutPut_KRV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxOutPut_KRV.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutPut_KRV.Multiline = true;
            this.textBoxOutPut_KRV.Name = "textBoxOutPut_KRV";
            this.textBoxOutPut_KRV.ReadOnly = true;
            this.textBoxOutPut_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_KRV.Size = new System.Drawing.Size(493, 633);
            this.textBoxOutPut_KRV.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 770);
            this.Controls.Add(this.chartGraph_KRV);
            this.Controls.Add(this.groupBoxOutPut_KRV);
            this.Controls.Add(this.buttonWiki_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Controls.Add(this.buttonSave_KRV);
            this.Controls.Add(this.groupBoxInPut_KRV);
            this.Controls.Add(this.groupBoxInfo_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 10 | Хасанов Р. В.";
            this.groupBoxInfo_KRV.ResumeLayout(false);
            this.groupBoxInfo_KRV.PerformLayout();
            this.groupBoxInPut_KRV.ResumeLayout(false);
            this.groupBoxInPut_KRV.PerformLayout();
            this.groupBoxOutPut_KRV.ResumeLayout(false);
            this.groupBoxOutPut_KRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_KRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_KRV;
        private System.Windows.Forms.TextBox textBoxInfo_KRV;
        private System.Windows.Forms.GroupBox groupBoxInPut_KRV;
        private System.Windows.Forms.TextBox textBoxStart_KRV;
        private System.Windows.Forms.TextBox textBoxEnd_KRV;
        private System.Windows.Forms.Label labelStart_KRV;
        private System.Windows.Forms.Label labelEnd_KRV;
        private System.Windows.Forms.Button buttonSave_KRV;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonWiki_KRV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KRV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_KRV;
        private System.Windows.Forms.TextBox textBoxOutPut_KRV;
    }
}

