namespace Tyuiu.KhasanovRV.Sprint6.Task5.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutPut_KRV = new System.Windows.Forms.GroupBox();
            this.buttonWiki_KRV = new System.Windows.Forms.Button();
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonOpen_KRV = new System.Windows.Forms.Button();
            this.groupBoxInfo_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_KRV = new System.Windows.Forms.TextBox();
            this.chartDiagr_KRV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewOutPut_KRV = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_KRV.SuspendLayout();
            this.groupBoxInfo_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagr_KRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_KRV
            // 
            this.groupBoxOutPut_KRV.Controls.Add(this.dataGridViewOutPut_KRV);
            this.groupBoxOutPut_KRV.Location = new System.Drawing.Point(8, 102);
            this.groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            this.groupBoxOutPut_KRV.Size = new System.Drawing.Size(249, 476);
            this.groupBoxOutPut_KRV.TabIndex = 8;
            this.groupBoxOutPut_KRV.TabStop = false;
            this.groupBoxOutPut_KRV.Text = "Вывод данных";
            // 
            // buttonWiki_KRV
            // 
            this.buttonWiki_KRV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonWiki_KRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.buttonWiki_KRV.Location = new System.Drawing.Point(773, 21);
            this.buttonWiki_KRV.Name = "buttonWiki_KRV";
            this.buttonWiki_KRV.Size = new System.Drawing.Size(69, 69);
            this.buttonWiki_KRV.TabIndex = 5;
            this.buttonWiki_KRV.Text = "?";
            this.buttonWiki_KRV.UseVisualStyleBackColor = false;
            this.buttonWiki_KRV.Click += new System.EventHandler(this.buttonWiki_KRV_Click);
            // 
            // buttonDone_KRV
            // 
            this.buttonDone_KRV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KRV.Location = new System.Drawing.Point(519, 21);
            this.buttonDone_KRV.Name = "buttonDone_KRV";
            this.buttonDone_KRV.Size = new System.Drawing.Size(121, 69);
            this.buttonDone_KRV.TabIndex = 6;
            this.buttonDone_KRV.Text = "Выполнить";
            this.buttonDone_KRV.UseVisualStyleBackColor = false;
            this.buttonDone_KRV.Click += new System.EventHandler(this.buttonDone_KRV_Click);
            // 
            // buttonOpen_KRV
            // 
            this.buttonOpen_KRV.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_KRV.Location = new System.Drawing.Point(646, 21);
            this.buttonOpen_KRV.Name = "buttonOpen_KRV";
            this.buttonOpen_KRV.Size = new System.Drawing.Size(121, 69);
            this.buttonOpen_KRV.TabIndex = 7;
            this.buttonOpen_KRV.Text = " Открыть файл";
            this.buttonOpen_KRV.UseVisualStyleBackColor = false;
            this.buttonOpen_KRV.Click += new System.EventHandler(this.buttonOpen_KRV_Click);
            // 
            // groupBoxInfo_KRV
            // 
            this.groupBoxInfo_KRV.Controls.Add(this.textBoxInfo_KRV);
            this.groupBoxInfo_KRV.Location = new System.Drawing.Point(8, 5);
            this.groupBoxInfo_KRV.Name = "groupBoxInfo_KRV";
            this.groupBoxInfo_KRV.Size = new System.Drawing.Size(505, 91);
            this.groupBoxInfo_KRV.TabIndex = 4;
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
            this.textBoxInfo_KRV.Size = new System.Drawing.Size(493, 67);
            this.textBoxInfo_KRV.TabIndex = 0;
            this.textBoxInfo_KRV.Text = "Прочитать данные из файла InPutFileTask5V6.txt. Вывести в dataGridView.\r\nВывести " +
    "все числа, кратные 3. Построить диаграмму по этим значениям.";
            // 
            // chartDiagr_KRV
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiagr_KRV.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartDiagr_KRV.Legends.Add(legend4);
            this.chartDiagr_KRV.Location = new System.Drawing.Point(263, 111);
            this.chartDiagr_KRV.Name = "chartDiagr_KRV";
            this.chartDiagr_KRV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiagr_KRV.Series.Add(series4);
            this.chartDiagr_KRV.Size = new System.Drawing.Size(575, 467);
            this.chartDiagr_KRV.TabIndex = 9;
            this.chartDiagr_KRV.Text = "Diagrama";
            // 
            // dataGridViewOutPut_KRV
            // 
            this.dataGridViewOutPut_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_KRV.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewOutPut_KRV.Name = "dataGridViewOutPut_KRV";
            this.dataGridViewOutPut_KRV.ReadOnly = true;
            this.dataGridViewOutPut_KRV.RowHeadersWidth = 51;
            this.dataGridViewOutPut_KRV.RowTemplate.Height = 24;
            this.dataGridViewOutPut_KRV.Size = new System.Drawing.Size(237, 449);
            this.dataGridViewOutPut_KRV.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 590);
            this.Controls.Add(this.chartDiagr_KRV);
            this.Controls.Add(this.groupBoxOutPut_KRV);
            this.Controls.Add(this.buttonWiki_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Controls.Add(this.buttonOpen_KRV);
            this.Controls.Add(this.groupBoxInfo_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 10 | Хасанов Р. В.";
            this.groupBoxOutPut_KRV.ResumeLayout(false);
            this.groupBoxInfo_KRV.ResumeLayout(false);
            this.groupBoxInfo_KRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagr_KRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut_KRV;
        private System.Windows.Forms.Button buttonWiki_KRV;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonOpen_KRV;
        private System.Windows.Forms.GroupBox groupBoxInfo_KRV;
        private System.Windows.Forms.TextBox textBoxInfo_KRV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagr_KRV;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_KRV;
    }
}

