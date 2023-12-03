using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhasanovRV.Sprint6.Task3.V27.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = { { 9 , 13, -14,  23,   1 },
                              {15, -17,  21,  25,  23 },
                              {-4,  29, -20, -10,  14 },
                              {27,  33,  12 , 33, -12 },
                              {18,  -9,  -5,   6,   3 } };




        private void buttonRun_KRV_Click(object sender, EventArgs e)
        {
            int[,] valueArray = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            dataGridViewResult_KRV.RowCount = rows;
            dataGridViewResult_KRV.ColumnCount = cols;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_KRV.Rows[i].Cells[j].Value = (Convert.ToString(valueArray[i,j]));
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            dataGridViewInfo_KRV.RowCount = rows;
            dataGridViewInfo_KRV.ColumnCount = cols;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewInfo_KRV.Rows[i].Cells[j].Value = (Convert.ToString(matrix[i, j]));
                }
            }
        }
        private void buttonInfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Хасанов Ренат Владиславович", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
