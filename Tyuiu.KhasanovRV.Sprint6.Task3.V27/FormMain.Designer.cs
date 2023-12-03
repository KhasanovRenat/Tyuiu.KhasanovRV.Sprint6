namespace Tyuiu.KhasanovRV.Sprint6.Task3.V27
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
            this.buttonInfo_KRV = new System.Windows.Forms.Button();
            this.buttonRun_KRV = new System.Windows.Forms.Button();
            this.groupBoxOutput_KRV = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo_KRV = new System.Windows.Forms.GroupBox();
            this.richTextBox_KRV = new System.Windows.Forms.RichTextBox();
            this.dataGridViewInfo_KRV = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_KRV = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_KRV.SuspendLayout();
            this.groupBoxInfo_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_KRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo_KRV
            // 
            this.buttonInfo_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KRV.Location = new System.Drawing.Point(13, 359);
            this.buttonInfo_KRV.Name = "buttonInfo_KRV";
            this.buttonInfo_KRV.Size = new System.Drawing.Size(66, 70);
            this.buttonInfo_KRV.TabIndex = 22;
            this.buttonInfo_KRV.Text = "INFO";
            this.buttonInfo_KRV.UseVisualStyleBackColor = true;
            this.buttonInfo_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // buttonRun_KRV
            // 
            this.buttonRun_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun_KRV.Location = new System.Drawing.Point(95, 359);
            this.buttonRun_KRV.Name = "buttonRun_KRV";
            this.buttonRun_KRV.Size = new System.Drawing.Size(184, 72);
            this.buttonRun_KRV.TabIndex = 21;
            this.buttonRun_KRV.Text = "Запуск";
            this.buttonRun_KRV.UseVisualStyleBackColor = true;
            this.buttonRun_KRV.Click += new System.EventHandler(this.buttonRun_KRV_Click);
            // 
            // groupBoxOutput_KRV
            // 
            this.groupBoxOutput_KRV.Controls.Add(this.dataGridViewResult_KRV);
            this.groupBoxOutput_KRV.Location = new System.Drawing.Point(706, 11);
            this.groupBoxOutput_KRV.Name = "groupBoxOutput_KRV";
            this.groupBoxOutput_KRV.Size = new System.Drawing.Size(277, 342);
            this.groupBoxOutput_KRV.TabIndex = 20;
            this.groupBoxOutput_KRV.TabStop = false;
            this.groupBoxOutput_KRV.Text = "Вывод данных";
            // 
            // groupBoxInfo_KRV
            // 
            this.groupBoxInfo_KRV.Controls.Add(this.dataGridViewInfo_KRV);
            this.groupBoxInfo_KRV.Controls.Add(this.richTextBox_KRV);
            this.groupBoxInfo_KRV.Location = new System.Drawing.Point(10, 11);
            this.groupBoxInfo_KRV.Name = "groupBoxInfo_KRV";
            this.groupBoxInfo_KRV.Size = new System.Drawing.Size(690, 342);
            this.groupBoxInfo_KRV.TabIndex = 19;
            this.groupBoxInfo_KRV.TabStop = false;
            this.groupBoxInfo_KRV.Text = "Условие";
            // 
            // richTextBox_KRV
            // 
            this.richTextBox_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox_KRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_KRV.Location = new System.Drawing.Point(3, 18);
            this.richTextBox_KRV.Name = "richTextBox_KRV";
            this.richTextBox_KRV.Size = new System.Drawing.Size(266, 318);
            this.richTextBox_KRV.TabIndex = 0;
            this.richTextBox_KRV.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в четвертом стол" +
    "бце.\n\n  9  13 -14  23   1\n  15 -17  21  25  23\n  -4  29 -20 -10  14\n  27  33  12" +
    "  33 -12\n  18  -9  -5   6   3";
            // 
            // dataGridViewInfo_KRV
            // 
            this.dataGridViewInfo_KRV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo_KRV.ColumnHeadersVisible = false;
            this.dataGridViewInfo_KRV.Location = new System.Drawing.Point(419, 18);
            this.dataGridViewInfo_KRV.Name = "dataGridViewInfo_KRV";
            this.dataGridViewInfo_KRV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewInfo_KRV.RowHeadersVisible = false;
            this.dataGridViewInfo_KRV.RowHeadersWidth = 51;
            this.dataGridViewInfo_KRV.RowTemplate.Height = 24;
            this.dataGridViewInfo_KRV.Size = new System.Drawing.Size(265, 318);
            this.dataGridViewInfo_KRV.TabIndex = 4;
            // 
            // dataGridViewResult_KRV
            // 
            this.dataGridViewResult_KRV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KRV.ColumnHeadersVisible = false;
            this.dataGridViewResult_KRV.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewResult_KRV.Name = "dataGridViewResult_KRV";
            this.dataGridViewResult_KRV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewResult_KRV.RowHeadersVisible = false;
            this.dataGridViewResult_KRV.RowHeadersWidth = 51;
            this.dataGridViewResult_KRV.RowTemplate.Height = 24;
            this.dataGridViewResult_KRV.Size = new System.Drawing.Size(265, 318);
            this.dataGridViewResult_KRV.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 439);
            this.Controls.Add(this.buttonInfo_KRV);
            this.Controls.Add(this.buttonRun_KRV);
            this.Controls.Add(this.groupBoxOutput_KRV);
            this.Controls.Add(this.groupBoxInfo_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 27 | Хасанов Р. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOutput_KRV.ResumeLayout(false);
            this.groupBoxInfo_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_KRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo_KRV;
        private System.Windows.Forms.Button buttonRun_KRV;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRV;
        private System.Windows.Forms.GroupBox groupBoxInfo_KRV;
        private System.Windows.Forms.DataGridView dataGridViewInfo_KRV;
        private System.Windows.Forms.RichTextBox richTextBox_KRV;
        private System.Windows.Forms.DataGridView dataGridViewResult_KRV;
    }
}

