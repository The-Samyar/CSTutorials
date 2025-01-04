namespace SortForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = string.Join(", ", Tools.BubbleSort(Tools.CleanInput(textBox.Text)));
        }

    }
}
