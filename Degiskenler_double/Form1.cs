namespace Degiskenler_double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 4.25;
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            double s1, s2, s3, ort;
            s1 = 70;
            s2 = 45;
            s3 = 43;
            ort = (s1 + s2 + s3) / 3;
            label6.Text = ort.ToString("0.00");
            */

            double s1, s2, s3, ort;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            s3 = Convert.ToDouble(textBox3.Text);
            ort = (s1 + s2 + s3) / 3;
            label6.Text = ort.ToString("0.000");
        }
    }
}