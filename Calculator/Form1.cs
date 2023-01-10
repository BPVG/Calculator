using System.Linq.Expressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class var
        {
            public static double? a = null;
            public static double? b = null;
            public static string? c = null;
            public static double? ans = null;
        }
        void equals()
        {
            try
            {
                var.b = double.Parse(textBox1.Text);
                textBox1.Text = string.Empty;
            }
            catch (FormatException)
            {
                textBox1.Text = "Error!";
            }

            switch (var.c)
            {
                case "add":
                    textBox1.Text = Convert.ToString(var.a + var.b);
                    break;
                case "subtract":
                    textBox1.Text = Convert.ToString(var.a - var.b);
                    break;
                case "multiply":
                    textBox1.Text = Convert.ToString(var.a * var.b);
                    break;
                case "devide":
                    textBox1.Text = Convert.ToString(var.a / var.b);
                    break;
                case "power":
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(var.a), Convert.ToDouble(var.b)));
                    break;
                case "squareroot":
                    textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(var.a)));
                    break;
                case "binary":
                    textBox1.Text = Convert.ToString(Convert.ToInt32(var.a), 2);
                    break;
            }
        }
        void addtoc(string y)
        {
            var.c = y;
            try
            {
                var.a = Double.Parse(textBox1.Text);
                textBox1.Text = string.Empty;
            }
            catch (FormatException)
            {
                textBox1.Text = "Error!";
            }
        }
        void addtoab(string x)
        {
            textBox1.Text = textBox1.Text + x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addtoab("0");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addtoab("1");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            addtoab("2");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            addtoab("3");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            equals();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            addtoab("4");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            addtoab("5");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            addtoab("6");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            addtoab("7");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            addtoab("8");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            addtoab("9");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            addtoab(",");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            addtoc("add");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            addtoc("subtract");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            addtoc("multiply");
        }
        private void button16_Click(object sender, EventArgs e)
        {
            var.a = var.b = null;
            var.c = null;
            textBox1.Text = string.Empty;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            addtoc("power");
        }
        private void button18_Click(object sender, EventArgs e)
        {
            addtoc("squareroot");
            equals();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            addtoc("devide");
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            addtoc("binary");
            equals();
        }
    }
}