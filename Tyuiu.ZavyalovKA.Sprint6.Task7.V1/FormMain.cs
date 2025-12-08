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

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
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

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix.Rows[r].Cells[c].Value = arrayValues[r, c];
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
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix.RowCount;
            int columns = dataGridViewOutMatrix.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}