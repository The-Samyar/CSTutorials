namespace CapitalForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = ReturnCapitals.Run(textBox1.Text);
        }
    }
}
