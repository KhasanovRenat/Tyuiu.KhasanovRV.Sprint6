using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KhasanovRV.Sprint6.Task0.V6.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRun_KRV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            
            try
            {
                textBoxOutput_KRV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_KRV.Text)));
            }
            catch 
            { 
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxX_KRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 ||  e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Хасанов Ренат Владиславович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
