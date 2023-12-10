using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KhasanovRV.Sprint6.Task6.V24.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonFileOpen_KRV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRV.ShowDialog();
            openFilePath = openFileDialogTask_KRV.FileName;
            textBoxInPut_KRV.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KRV.Text = groupBoxOutPut_KRV.Text + " " + openFileDialogTask_KRV.FileName; ;
            buttonSaveFile_KRV.Enabled = true;
        }

        private void buttonSaveFile_KRV_Click(object sender, EventArgs e)
        {
            textBoxOutPut_KRV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
