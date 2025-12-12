using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Tyuiu.ZavyalovKA.Sprint6.Task7.V1.Lib;

namespace Tyuiu.ZavyalovKA.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            rows = arrayValues.GetLength(0);
            columns = arrayValues.GetLength(1);

            dataGridViewInMatrix.ColumnCount = columns;
            dataGridViewInMatrix.RowCount = rows;

            dataGridViewOutMatrix.ColumnCount = columns;
            dataGridViewOutMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 25;
                dataGridViewOutMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonDone.Enabled = true;
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            int Rows = arrayValues.GetLength(0);
            int Columns = arrayValues.GetLength(1);
            dataGridViewOutMatrix.ColumnCount = Columns;
            dataGridViewOutMatrix.RowCount = Rows;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    dataGridViewOutMatrix.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists) { File.Delete(path); }
            int rows = dataGridViewOutMatrix.RowCount;
            int columns = dataGridViewOutMatrix.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutMatrix.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}