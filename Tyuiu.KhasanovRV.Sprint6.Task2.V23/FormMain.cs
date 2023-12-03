using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhasanovRV.Sprint6.Task2.V23.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task2.V23
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

                this.chartFunction_KRV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KRV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KRV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KRV.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void buttonInfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-23-1 Хасанов Ренат Владиславович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
