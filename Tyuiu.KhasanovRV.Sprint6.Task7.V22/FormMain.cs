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
using Tyuiu.KhasanovRV.Sprint6.Task7.V22.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KRV.Filter = "Значения, разделённый запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KRV.Filter = "Значения, разделённый запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows, cols;
        static string openFilePath;

        DataService ds = new DataService();

        private void buttonFileOpen_KRV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRV.ShowDialog();
            openFilePath = openFileDialogTask_KRV.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInPut_KRV.ColumnCount = cols;
            dataGridViewInPut_KRV.RowCount = rows;
            dataGridViewOutPut_KRV.ColumnCount = cols;
            dataGridViewOutPut_KRV.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewInPut_KRV.Columns[i].Width = 25;
                dataGridViewOutPut_KRV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewInPut_KRV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KRV.Enabled = true;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_KRV.ColumnCount = 50;
            dataGridViewOutPut_KRV.ColumnCount = 50;

            dataGridViewInPut_KRV.RowCount = 50;
            dataGridViewOutPut_KRV.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_KRV.Columns[i].Width = 25;
                dataGridViewOutPut_KRV.Columns[i].Width = 25;
            }
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOutPut_KRV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            buttonSaveFile_KRV.Enabled = true;
        }

        private void buttonSaveFile_KRV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KRV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KRV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KRV.ShowDialog();

            string path = saveFileDialogMatrix_KRV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_KRV.RowCount;
            int columns = dataGridViewOutPut_KRV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_KRV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_KRV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonFileOpen_KRV_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KRV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KRV_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KRV.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KRV_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KRV.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_KRV_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KRV.ToolTipTitle = "О программе";
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileDta = File.ReadAllText(filePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;

        }
    }
}
