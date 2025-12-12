namespace Tyuiu.ZavyalovKA.Sprint6.Task7.V1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBoxCondition = new TextBox();
            panel4 = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panel2 = new Panel();
            dataGridViewInMatrix = new DataGridView();
            textBox2 = new TextBox();
            splitter1 = new Splitter();
            panel3 = new Panel();
            dataGridViewOutMatrix = new DataGridView();
            textBox3 = new TextBox();
            toolTip1 = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBoxCondition);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1392, 226);
            panel1.TabIndex = 0;
            panel1.MouseEnter += buttonOpenFile_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 119);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(181, 35);
            textBox1.TabIndex = 2;
            textBox1.Text = "Условие: ";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition.Location = new Point(12, 157);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.ScrollBars = ScrollBars.Vertical;
            textBoxCondition.Size = new Size(1335, 63);
            textBoxCondition.TabIndex = 1;
            textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonHelp);
            panel4.Controls.Add(buttonSave);
            panel4.Controls.Add(buttonDone);
            panel4.Controls.Add(buttonOpenFile);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1392, 113);
            panel4.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(1206, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(122, 83);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            toolTip1.SetToolTip(buttonHelp, "Сведения о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(353, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(122, 83);
            buttonSave.TabIndex = 2;
            toolTip1.SetToolTip(buttonSave, "Сохранить");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(189, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(122, 83);
            buttonDone.TabIndex = 1;
            toolTip1.SetToolTip(buttonDone, "Выполнить");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(124, 83);
            buttonOpenFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewInMatrix);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 366);
            panel2.TabIndex = 1;
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(9, 47);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.Size = new Size(654, 299);
            dataGridViewInMatrix.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(12, 6);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(107, 35);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ввод:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 366);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewOutMatrix);
            panel3.Controls.Add(textBox3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(702, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 366);
            panel3.TabIndex = 2;
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(3, 47);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.Size = new Size(684, 299);
            dataGridViewOutMatrix.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(3, 6);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(120, 35);
            textBox3.TabIndex = 0;
            textBox3.Text = "Вывод:";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 592);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обработка матрицы";
            MouseEnter += buttonOpenFile_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private TextBox textBoxCondition;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonOpenFile;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
    }
}