using System;

namespace Tyuiu.KhasanovRV.Sprint6.Task0.V6
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
            this.buttonRun_KRV = new System.Windows.Forms.Button();
            this.groupBoxInput_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxX_KRV = new System.Windows.Forms.TextBox();
            this.labelX_KRV = new System.Windows.Forms.Label();
            this.groupBoxOutput_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_KRV = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_KRV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KRV = new System.Windows.Forms.PictureBox();
            this.richTextBoxInfo_KRV = new System.Windows.Forms.RichTextBox();
            this.buttonInfo_KRV = new System.Windows.Forms.Button();
            this.groupBoxInput_KRV.SuspendLayout();
            this.groupBoxOutput_KRV.SuspendLayout();
            this.groupBoxInfo_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun_KRV
            // 
            this.buttonRun_KRV.Location = new System.Drawing.Point(605, 368);
            this.buttonRun_KRV.Name = "buttonRun_KRV";
            this.buttonRun_KRV.Size = new System.Drawing.Size(184, 72);
            this.buttonRun_KRV.TabIndex = 6;
            this.buttonRun_KRV.Text = "Запуск";
            this.buttonRun_KRV.UseVisualStyleBackColor = true;
            this.buttonRun_KRV.Click += new System.EventHandler(this.buttonRun_KRV_Click);
            // 
            // groupBoxInput_KRV
            // 
            this.groupBoxInput_KRV.Controls.Add(this.textBoxX_KRV);
            this.groupBoxInput_KRV.Controls.Add(this.labelX_KRV);
            this.groupBoxInput_KRV.Location = new System.Drawing.Point(12, 360);
            this.groupBoxInput_KRV.Name = "groupBoxInput_KRV";
            this.groupBoxInput_KRV.Size = new System.Drawing.Size(511, 78);
            this.groupBoxInput_KRV.TabIndex = 3;
            this.groupBoxInput_KRV.TabStop = false;
            this.groupBoxInput_KRV.Text = "Ввод данных";
            // 
            // textBoxX_KRV
            // 
            this.textBoxX_KRV.Location = new System.Drawing.Point(6, 47);
            this.textBoxX_KRV.Name = "textBoxX_KRV";
            this.textBoxX_KRV.Size = new System.Drawing.Size(499, 22);
            this.textBoxX_KRV.TabIndex = 2;
            this.textBoxX_KRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_KRV_KeyPress);
            // 
            // labelX_KRV
            // 
            this.labelX_KRV.AutoSize = true;
            this.labelX_KRV.Location = new System.Drawing.Point(6, 28);
            this.labelX_KRV.Name = "labelX_KRV";
            this.labelX_KRV.Size = new System.Drawing.Size(77, 16);
            this.labelX_KRV.TabIndex = 1;
            this.labelX_KRV.Text = "Введите X:";
            // 
            // groupBoxOutput_KRV
            // 
            this.groupBoxOutput_KRV.Controls.Add(this.textBoxOutput_KRV);
            this.groupBoxOutput_KRV.Location = new System.Drawing.Point(604, 12);
            this.groupBoxOutput_KRV.Name = "groupBoxOutput_KRV";
            this.groupBoxOutput_KRV.Size = new System.Drawing.Size(184, 342);
            this.groupBoxOutput_KRV.TabIndex = 5;
            this.groupBoxOutput_KRV.TabStop = false;
            this.groupBoxOutput_KRV.Text = "Вывод данных";
            // 
            // textBoxOutput_KRV
            // 
            this.textBoxOutput_KRV.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutput_KRV.Name = "textBoxOutput_KRV";
            this.textBoxOutput_KRV.ReadOnly = true;
            this.textBoxOutput_KRV.Size = new System.Drawing.Size(172, 22);
            this.textBoxOutput_KRV.TabIndex = 1;
            // 
            // groupBoxInfo_KRV
            // 
            this.groupBoxInfo_KRV.Controls.Add(this.pictureBoxFormula_KRV);
            this.groupBoxInfo_KRV.Controls.Add(this.richTextBoxInfo_KRV);
            this.groupBoxInfo_KRV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_KRV.Name = "groupBoxInfo_KRV";
            this.groupBoxInfo_KRV.Size = new System.Drawing.Size(586, 342);
            this.groupBoxInfo_KRV.TabIndex = 4;
            this.groupBoxInfo_KRV.TabStop = false;
            this.groupBoxInfo_KRV.Text = "Условие";
            // 
            // pictureBoxFormula_KRV
            // 
            this.pictureBoxFormula_KRV.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFormula_KRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxFormula_KRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFormula_KRV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KRV.Image")));
            this.pictureBoxFormula_KRV.Location = new System.Drawing.Point(9, 62);
            this.pictureBoxFormula_KRV.Name = "pictureBoxFormula_KRV";
            this.pictureBoxFormula_KRV.Size = new System.Drawing.Size(189, 88);
            this.pictureBoxFormula_KRV.TabIndex = 1;
            this.pictureBoxFormula_KRV.TabStop = false;
            // 
            // richTextBoxInfo_KRV
            // 
            this.richTextBoxInfo_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxInfo_KRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo_KRV.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxInfo_KRV.Name = "richTextBoxInfo_KRV";
            this.richTextBoxInfo_KRV.Size = new System.Drawing.Size(574, 44);
            this.richTextBoxInfo_KRV.TabIndex = 0;
            this.richTextBoxInfo_KRV.Text = "Дано выражение вычислить его значение при x = 3. Округлить до трёх знаков после з" +
    "апятой.";
            // 
            // buttonInfo_KRV
            // 
            this.buttonInfo_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KRV.Location = new System.Drawing.Point(529, 368);
            this.buttonInfo_KRV.Name = "buttonInfo_KRV";
            this.buttonInfo_KRV.Size = new System.Drawing.Size(70, 70);
            this.buttonInfo_KRV.TabIndex = 7;
            this.buttonInfo_KRV.Text = "INFO";
            this.buttonInfo_KRV.UseVisualStyleBackColor = true;
            this.buttonInfo_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_KRV);
            this.Controls.Add(this.buttonRun_KRV);
            this.Controls.Add(this.groupBoxInput_KRV);
            this.Controls.Add(this.groupBoxOutput_KRV);
            this.Controls.Add(this.groupBoxInfo_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 6 | Хасанов Р. В.";
            this.groupBoxInput_KRV.ResumeLayout(false);
            this.groupBoxInput_KRV.PerformLayout();
            this.groupBoxOutput_KRV.ResumeLayout(false);
            this.groupBoxOutput_KRV.PerformLayout();
            this.groupBoxInfo_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRV)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button buttonRun_KRV;
        private System.Windows.Forms.GroupBox groupBoxInput_KRV;
        private System.Windows.Forms.Label labelX_KRV;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRV;
        private System.Windows.Forms.GroupBox groupBoxInfo_KRV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KRV;
        private System.Windows.Forms.RichTextBox richTextBoxInfo_KRV;
        private System.Windows.Forms.TextBox textBoxOutput_KRV;
        private System.Windows.Forms.TextBox textBoxX_KRV;
        private System.Windows.Forms.Button buttonInfo_KRV;
    }
}

