using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhasanovRV.Sprint6.Task4.V10.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task4.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KRV.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_KRV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGraph_KRV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraph_KRV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut_KRV.Text = "";

                chartGraph_KRV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartGraph_KRV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPut_KRV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonWiki_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-23-1 Хасанов Ренат Владиславович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxOutPut_KRV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
