namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double radius;
            double area;
            double circumference;
            double diameter;


             diameter = Convert.ToDouble(textBox1.Text);

            circumference = diameter * Math.PI;

            textBox2.Text = circumference.ToString("n");

            radius = circumference / (2 * Math.PI);


            area = radius * radius * Math.PI;

            textBox3.Text = area.ToString("n");

        }
    }
}