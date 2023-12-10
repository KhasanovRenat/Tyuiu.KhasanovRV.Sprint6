namespace Tyuiu.KhasanovRV.Sprint6.Task7.V22
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_KRV = new System.Windows.Forms.Button();
            this.buttonDone_KRV = new System.Windows.Forms.Button();
            this.buttonFileOpen_KRV = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KRV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_KRV = new System.Windows.Forms.DataGridView();
            this.groupBoxInPut_KRV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_KRV = new System.Windows.Forms.DataGridView();
            this.groupBoxUslov_KRV = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSaveFile_KRV = new System.Windows.Forms.Button();
            this.openFileDialogTask_KRV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_KRV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_KRV = new System.Windows.Forms.SaveFileDialog();
            this.panelLeft_KRV = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRight_KRV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KRV)).BeginInit();
            this.groupBoxInPut_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KRV)).BeginInit();
            this.groupBoxUslov_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panelLeft_KRV.SuspendLayout();
            this.panelRight_KRV.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_KRV
            // 
            this.buttonHelp_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KRV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KRV.Image")));
            this.buttonHelp_KRV.Location = new System.Drawing.Point(911, 12);
            this.buttonHelp_KRV.Name = "buttonHelp_KRV";
            this.buttonHelp_KRV.Size = new System.Drawing.Size(86, 86);
            this.buttonHelp_KRV.TabIndex = 6;
            this.toolTipTask_KRV.SetToolTip(this.buttonHelp_KRV, "Информация о программе");
            this.buttonHelp_KRV.UseVisualStyleBackColor = true;
            this.buttonHelp_KRV.Click += new System.EventHandler(this.buttonHelp_KRV_Click);
            this.buttonHelp_KRV.MouseEnter += new System.EventHandler(this.buttonHelp_KRV_MouseEnter);
            // 
            // buttonDone_KRV
            // 
            this.buttonDone_KRV.Enabled = false;
            this.buttonDone_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KRV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KRV.Image")));
            this.buttonDone_KRV.Location = new System.Drawing.Point(110, 12);
            this.buttonDone_KRV.Name = "buttonDone_KRV";
            this.buttonDone_KRV.Size = new System.Drawing.Size(86, 86);
            this.buttonDone_KRV.TabIndex = 7;
            this.toolTipTask_KRV.SetToolTip(this.buttonDone_KRV, "Выполнить\r\nИзменяет в шестом столбце положительные четные элементы на 111");
            this.buttonDone_KRV.UseVisualStyleBackColor = true;
            this.buttonDone_KRV.Click += new System.EventHandler(this.buttonDone_KRV_Click);
            this.buttonDone_KRV.MouseEnter += new System.EventHandler(this.buttonDone_KRV_MouseEnter);
            // 
            // buttonFileOpen_KRV
            // 
            this.buttonFileOpen_KRV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFileOpen_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileOpen_KRV.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileOpen_KRV.Image")));
            this.buttonFileOpen_KRV.Location = new System.Drawing.Point(18, 12);
            this.buttonFileOpen_KRV.Name = "buttonFileOpen_KRV";
            this.buttonFileOpen_KRV.Size = new System.Drawing.Size(86, 86);
            this.buttonFileOpen_KRV.TabIndex = 8;
            this.toolTipTask_KRV.SetToolTip(this.buttonFileOpen_KRV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonFileOpen_KRV.UseVisualStyleBackColor = false;
            this.buttonFileOpen_KRV.Click += new System.EventHandler(this.buttonFileOpen_KRV_Click);
            this.buttonFileOpen_KRV.MouseEnter += new System.EventHandler(this.buttonFileOpen_KRV_MouseEnter);
            // 
            // groupBoxOutPut_KRV
            // 
            this.groupBoxOutPut_KRV.Controls.Add(this.dataGridViewOutPut_KRV);
            this.groupBoxOutPut_KRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KRV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            this.groupBoxOutPut_KRV.Size = new System.Drawing.Size(342, 341);
            this.groupBoxOutPut_KRV.TabIndex = 4;
            this.groupBoxOutPut_KRV.TabStop = false;
            this.groupBoxOutPut_KRV.Text = "Вывод";
            // 
            // dataGridViewOutPut_KRV
            // 
            this.dataGridViewOutPut_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_KRV.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_KRV.Location = new System.Drawing.Point(9, 21);
            this.dataGridViewOutPut_KRV.Name = "dataGridViewOutPut_KRV";
            this.dataGridViewOutPut_KRV.ReadOnly = true;
            this.dataGridViewOutPut_KRV.RowHeadersVisible = false;
            this.dataGridViewOutPut_KRV.RowHeadersWidth = 51;
            this.dataGridViewOutPut_KRV.RowTemplate.Height = 24;
            this.dataGridViewOutPut_KRV.Size = new System.Drawing.Size(321, 313);
            this.dataGridViewOutPut_KRV.TabIndex = 0;
            // 
            // groupBoxInPut_KRV
            // 
            this.groupBoxInPut_KRV.Controls.Add(this.dataGridViewInPut_KRV);
            this.groupBoxInPut_KRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_KRV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            this.groupBoxInPut_KRV.Size = new System.Drawing.Size(643, 341);
            this.groupBoxInPut_KRV.TabIndex = 5;
            this.groupBoxInPut_KRV.TabStop = false;
            this.groupBoxInPut_KRV.Text = "Ввод";
            // 
            // dataGridViewInPut_KRV
            // 
            this.dataGridViewInPut_KRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KRV.ColumnHeadersVisible = false;
            this.dataGridViewInPut_KRV.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewInPut_KRV.Name = "dataGridViewInPut_KRV";
            this.dataGridViewInPut_KRV.ReadOnly = true;
            this.dataGridViewInPut_KRV.RowHeadersVisible = false;
            this.dataGridViewInPut_KRV.RowHeadersWidth = 51;
            this.dataGridViewInPut_KRV.RowTemplate.Height = 24;
            this.dataGridViewInPut_KRV.Size = new System.Drawing.Size(631, 313);
            this.dataGridViewInPut_KRV.TabIndex = 0;
            // 
            // groupBoxUslov_KRV
            // 
            this.groupBoxUslov_KRV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxUslov_KRV.Controls.Add(this.splitContainer1);
            this.groupBoxUslov_KRV.Controls.Add(this.richTextBox1);
            this.groupBoxUslov_KRV.Location = new System.Drawing.Point(18, 104);
            this.groupBoxUslov_KRV.Name = "groupBoxUslov_KRV";
            this.groupBoxUslov_KRV.Size = new System.Drawing.Size(973, 100);
            this.groupBoxUslov_KRV.TabIndex = 3;
            this.groupBoxUslov_KRV.TabStop = false;
            this.groupBoxUslov_KRV.Text = "Условие";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(203, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(961, 73);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // buttonSaveFile_KRV
            // 
            this.buttonSaveFile_KRV.Enabled = false;
            this.buttonSaveFile_KRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_KRV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_KRV.Image")));
            this.buttonSaveFile_KRV.Location = new System.Drawing.Point(202, 12);
            this.buttonSaveFile_KRV.Name = "buttonSaveFile_KRV";
            this.buttonSaveFile_KRV.Size = new System.Drawing.Size(86, 86);
            this.buttonSaveFile_KRV.TabIndex = 7;
            this.toolTipTask_KRV.SetToolTip(this.buttonSaveFile_KRV, "Сохранить файл\r\nВыберите путь, куда сохранить файл");
            this.buttonSaveFile_KRV.UseVisualStyleBackColor = true;
            this.buttonSaveFile_KRV.Click += new System.EventHandler(this.buttonSaveFile_KRV_Click);
            this.buttonSaveFile_KRV.MouseEnter += new System.EventHandler(this.buttonSaveFile_KRV_MouseEnter);
            // 
            // openFileDialogTask_KRV
            // 
            this.openFileDialogTask_KRV.FileName = "openFileDialog1";
            // 
            // toolTipTask_KRV
            // 
            this.toolTipTask_KRV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panelLeft_KRV
            // 
            this.panelLeft_KRV.Controls.Add(this.panel2);
            this.panelLeft_KRV.Controls.Add(this.groupBoxInPut_KRV);
            this.panelLeft_KRV.Location = new System.Drawing.Point(12, 213);
            this.panelLeft_KRV.Name = "panelLeft_KRV";
            this.panelLeft_KRV.Size = new System.Drawing.Size(643, 341);
            this.panelLeft_KRV.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(649, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 344);
            this.panel2.TabIndex = 9;
            // 
            // panelRight_KRV
            // 
            this.panelRight_KRV.Controls.Add(this.groupBoxOutPut_KRV);
            this.panelRight_KRV.Location = new System.Drawing.Point(655, 213);
            this.panelRight_KRV.Name = "panelRight_KRV";
            this.panelRight_KRV.Size = new System.Drawing.Size(342, 341);
            this.panelRight_KRV.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 559);
            this.Controls.Add(this.panelRight_KRV);
            this.Controls.Add(this.panelLeft_KRV);
            this.Controls.Add(this.buttonHelp_KRV);
            this.Controls.Add(this.buttonSaveFile_KRV);
            this.Controls.Add(this.buttonDone_KRV);
            this.Controls.Add(this.buttonFileOpen_KRV);
            this.Controls.Add(this.groupBoxUslov_KRV);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOutPut_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KRV)).EndInit();
            this.groupBoxInPut_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KRV)).EndInit();
            this.groupBoxUslov_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLeft_KRV.ResumeLayout(false);
            this.panelRight_KRV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_KRV;
        private System.Windows.Forms.Button buttonDone_KRV;
        private System.Windows.Forms.Button buttonFileOpen_KRV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KRV;
        private System.Windows.Forms.GroupBox groupBoxInPut_KRV;
        private System.Windows.Forms.GroupBox groupBoxUslov_KRV;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSaveFile_KRV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KRV;
        private System.Windows.Forms.ToolTip toolTipTask_KRV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_KRV;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_KRV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KRV;
        private System.Windows.Forms.Panel panelLeft_KRV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRight_KRV;
    }
}

