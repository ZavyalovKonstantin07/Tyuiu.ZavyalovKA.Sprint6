namespace Tyuiu.ZavyalovKA.Sprint6.Task7.V1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            textBoxCondition = new TextBox();
            textBox1 = new TextBox();
            panel4 = new Panel();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            panel2 = new Panel();
            dataGridViewInMatrix = new DataGridView();
            textBox2 = new TextBox();
            panel3 = new Panel();
            dataGridViewOutMatrix = new DataGridView();
            textBox3 = new TextBox();
            toolTip1 = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(textBoxCondition);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1392, 226);
            panel1.TabIndex = 1;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCondition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition.Location = new Point(12, 157);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.ScrollBars = ScrollBars.Vertical;
            textBoxCondition.Size = new Size(1292, 63);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 119);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(181, 29);
            textBox1.TabIndex = 1;
            textBox1.Text = "Условие:";
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonOpenFile);
            panel4.Controls.Add(buttonDone);
            panel4.Controls.Add(buttonSave);
            panel4.Controls.Add(buttonHelp);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1392, 113);
            panel4.TabIndex = 2;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(124, 83);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(189, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(122, 83);
            buttonDone.TabIndex = 1;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(353, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(122, 83);
            buttonSave.TabIndex = 2;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Dock = DockStyle.Right;
            buttonHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp.Location = new Point(1270, 0);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(122, 113);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.Click += buttonHelp_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(panel2, 0, 0);
            tableLayoutPanel.Controls.Add(panel3, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 226);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1392, 366);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewInMatrix);
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 360);
            panel2.TabIndex = 0;
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.Dock = DockStyle.Fill;
            dataGridViewInMatrix.Location = new Point(0, 35);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.Size = new Size(690, 325);
            dataGridViewInMatrix.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(690, 35);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ввод:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewOutMatrix);
            panel3.Controls.Add(textBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(699, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 360);
            panel3.TabIndex = 1;
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.Dock = DockStyle.Fill;
            dataGridViewOutMatrix.Location = new Point(0, 35);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.Size = new Size(690, 325);
            dataGridViewOutMatrix.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Top;
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(0, 0);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(690, 35);
            textBox3.TabIndex = 1;
            textBox3.Text = "Вывод:";
            // 
            // FormMain
            // 
            ClientSize = new Size(1392, 592);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обработка матрицы";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
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
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel;
        private TextBox textBox1;
        private TextBox textBoxCondition;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
