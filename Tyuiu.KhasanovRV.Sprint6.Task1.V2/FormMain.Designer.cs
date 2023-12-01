namespace Tyuiu.KhasanovRV.Sprint6.Task1.V2
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
            this.buttonInfo_KRV = new System.Windows.Forms.Button();
            this.buttonRun_KRV = new System.Windows.Forms.Button();
            this.groupBoxInput_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_KRV = new System.Windows.Forms.TextBox();
            this.labelEnd_KRV = new System.Windows.Forms.Label();
            this.textBoxStart_KRV = new System.Windows.Forms.TextBox();
            this.labelStart_KRV = new System.Windows.Forms.Label();
            this.groupBoxOutput_KRV = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_KRV = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_KRV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KRV = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_KRV.SuspendLayout();
            this.groupBoxOutput_KRV.SuspendLayout();
            this.groupBoxInfo_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo_KRV
            // 
            this.buttonInfo_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KRV.Location = new System.Drawing.Point(529, 367);
            this.buttonInfo_KRV.Name = "buttonInfo_KRV";
            this.buttonInfo_KRV.Size = new System.Drawing.Size(70, 70);
            this.buttonInfo_KRV.TabIndex = 12;
            this.buttonInfo_KRV.Text = "INFO";
            this.buttonInfo_KRV.UseVisualStyleBackColor = true;
            this.buttonInfo_KRV.Click += new System.EventHandler(this.buttonInfo_KRV_Click);
            // 
            // buttonRun_KRV
            // 
            this.buttonRun_KRV.Location = new System.Drawing.Point(605, 367);
            this.buttonRun_KRV.Name = "buttonRun_KRV";
            this.buttonRun_KRV.Size = new System.Drawing.Size(184, 72);
            this.buttonRun_KRV.TabIndex = 11;
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
            this.groupBoxInput_KRV.Size = new System.Drawing.Size(511, 78);
            this.groupBoxInput_KRV.TabIndex = 8;
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
            this.groupBoxOutput_KRV.Controls.Add(this.textBoxOutput_KRV);
            this.groupBoxOutput_KRV.Location = new System.Drawing.Point(452, 11);
            this.groupBoxOutput_KRV.Name = "groupBoxOutput_KRV";
            this.groupBoxOutput_KRV.Size = new System.Drawing.Size(336, 342);
            this.groupBoxOutput_KRV.TabIndex = 10;
            this.groupBoxOutput_KRV.TabStop = false;
            this.groupBoxOutput_KRV.Text = "Вывод данных";
            // 
            // textBoxOutput_KRV
            // 
            this.textBoxOutput_KRV.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxOutput_KRV.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutput_KRV.Multiline = true;
            this.textBoxOutput_KRV.Name = "textBoxOutput_KRV";
            this.textBoxOutput_KRV.ReadOnly = true;
            this.textBoxOutput_KRV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_KRV.Size = new System.Drawing.Size(321, 315);
            this.textBoxOutput_KRV.TabIndex = 2;
            this.textBoxOutput_KRV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxInfo_KRV
            // 
            this.groupBoxInfo_KRV.Controls.Add(this.pictureBoxFormula_KRV);
            this.groupBoxInfo_KRV.Location = new System.Drawing.Point(12, 11);
            this.groupBoxInfo_KRV.Name = "groupBoxInfo_KRV";
            this.groupBoxInfo_KRV.Size = new System.Drawing.Size(434, 342);
            this.groupBoxInfo_KRV.TabIndex = 9;
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
            this.pictureBoxFormula_KRV.Size = new System.Drawing.Size(419, 292);
            this.pictureBoxFormula_KRV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_KRV.TabIndex = 1;
            this.pictureBoxFormula_KRV.TabStop = false;
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
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 2 | Хасанов Р. В.";
            this.groupBoxInput_KRV.ResumeLayout(false);
            this.groupBoxInput_KRV.PerformLayout();
            this.groupBoxOutput_KRV.ResumeLayout(false);
            this.groupBoxOutput_KRV.PerformLayout();
            this.groupBoxInfo_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo_KRV;
        private System.Windows.Forms.Button buttonRun_KRV;
        private System.Windows.Forms.GroupBox groupBoxInput_KRV;
        private System.Windows.Forms.TextBox textBoxStart_KRV;
        private System.Windows.Forms.Label labelStart_KRV;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRV;
        private System.Windows.Forms.GroupBox groupBoxInfo_KRV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KRV;
        private System.Windows.Forms.TextBox textBoxEnd_KRV;
        private System.Windows.Forms.Label labelEnd_KRV;
        private System.Windows.Forms.TextBox textBoxOutput_KRV;
    }
}

