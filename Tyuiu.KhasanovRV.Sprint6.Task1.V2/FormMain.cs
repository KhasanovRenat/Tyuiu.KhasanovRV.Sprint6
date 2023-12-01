using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhasanovRV.Sprint6.Task1.V2.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRun_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KRV.Text);
                int endStep = Convert.ToInt32(textBoxEnd_KRV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, endStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, endStep);

                textBoxOutput_KRV.Text = "";
                textBoxOutput_KRV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutput_KRV.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textBoxOutput_KRV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(" | {0,5:d}    |   {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxOutput_KRV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxOutput_KRV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Хасанов Ренат Владиславович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBoxStart_KRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
