using System;
using System.Windows.Forms;
namespace Tyuiu.ZavyalovKA.Sprint6.Task0.V29
using Tyuiu.ZavyalovKA.Sprint6.Task0.V29.Lib;
{
    public partial class FormMain : Form
{
    private object textBoxResult;

    public FormMain()
    {
        InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {

    }
    private void buttonDone_Click(object sender, EventArgs e)
    {
        DataService ds = new DataService();
        try
        {
            textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text);
        catch
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        {
            e.Handled = true;
        }
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 0 выполнил студент группы РППб-25-1 Завьялов Константин Андреевич");
    }
}
}






