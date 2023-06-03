using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using org.mariuszgromada.math.mxparser;


namespace lab_kalkulator
{
    public partial class Form1 : Form
    {
        string ans; 
        public Form1()
        {
            InitializeComponent();
            comboBox1.Hide();
            button24.Hide();
            button28.Hide();
            button29.Hide();
            button30.Hide();
            button25.Hide();
            button32.Hide();
            button23.Hide();
            button21.Hide();
            button22.Hide();
            button27.Hide();
            button26.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Show();
                button24.Show();
                button28.Show();
                button29.Show();
                button30.Show();
                button25.Show();
                button32.Show();
                button23.Show();
                button21.Show();
                button22.Show();
                button27.Show();
                button26.Show();
            }
            else
            {
                comboBox1.Hide();
                button24.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();
                button25.Hide();
                button32.Hide();
                button23.Hide();
                button21.Hide();
                button22.Hide();
                button27.Hide();
                button26.Hide();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ln(";

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "lg(";

        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '!';

        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sin(";

        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "cos(";

        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "tg(";

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "exp(";

        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "pi";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '^';

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ans;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 'e';

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                mXparser.setRadiansMode();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                mXparser.setDegreesMode();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text + '=';
            Expression wynik = new Expression(textBox1.Text);
            textBox1.Text = wynik.calculate().ToString();
            n = n + textBox1.Text;
            ans = textBox1.Text;
            listBox1.Items.Add(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '+';

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '-';

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '*';

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '/';

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sqrt(";

        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '(';

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ')';

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '%';

        }
    }
}
