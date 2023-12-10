namespace Tyuiu.KhasanovRV.Sprint6.Task7.V22
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_KRV = new System.Windows.Forms.Button();
            this.richTextBoxInfo_KRV = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonOK_KRV
            // 
            this.buttonOK_KRV.Location = new System.Drawing.Point(282, 177);
            this.buttonOK_KRV.Name = "buttonOK_KRV";
            this.buttonOK_KRV.Size = new System.Drawing.Size(97, 34);
            this.buttonOK_KRV.TabIndex = 3;
            this.buttonOK_KRV.Text = "Ок";
            this.buttonOK_KRV.UseVisualStyleBackColor = true;
            this.buttonOK_KRV.Click += new System.EventHandler(this.buttonOK_KRV_Click);
            // 
            // richTextBoxInfo_KRV
            // 
            this.richTextBoxInfo_KRV.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxInfo_KRV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo_KRV.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxInfo_KRV.Name = "richTextBoxInfo_KRV";
            this.richTextBoxInfo_KRV.ReadOnly = true;
            this.richTextBoxInfo_KRV.Size = new System.Drawing.Size(371, 159);
            this.richTextBoxInfo_KRV.TabIndex = 2;
            this.richTextBoxInfo_KRV.Text = resources.GetString("richTextBoxInfo_KRV.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 223);
            this.Controls.Add(this.buttonOK_KRV);
            this.Controls.Add(this.richTextBoxInfo_KRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KRV;
        private System.Windows.Forms.RichTextBox richTextBoxInfo_KRV;
    }
}