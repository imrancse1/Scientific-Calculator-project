using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator_3
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float icelsius, ifahrenheit, ikelvin;
        char ioperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Width = 318;
        }

        private void standeredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360;
            textBox1.Width = 318;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 711;
            textBox1.Width = 667;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1037;
            textBox1.Width = 667;
            txtConvert.Focus();

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox1.Location = new Point(714, 38);
            groupBox1.Width = 292;
            groupBox1.Height =430;
        }

        private void unitConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1037;
            textBox1.Width = 667;
        }

        private void timesTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1037;
            textBox1.Width = 667;
            tblmultiply.Focus();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point (714, 38);
            groupBox3.Width = 246;
            groupBox3.Height = 417;
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void del_click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            if (textBox1.Text =="")
                 {
                     textBox1.Text = "0";
                 }
        }

        private void arithmetic_operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(results) + "" + operation;

        }

        private void equal(object sender, EventArgs e)
        {
            label1.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;

                default:
                    break;
                       

            }
        }

        private void exp_mod(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(results) + "" + operation;
        }

        private void pie_click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265358979323846";
        }

        private void log_click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text )+ ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
           

        }

        private void sqrt_click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("√" + "(" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void sinh_click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Sinh" + "(" + (textBox1.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);
        }

        private void sin_click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Sin" + "(" + (textBox1.Text) + ")");
            qSin = Math.Sin(qSin);
            textBox1.Text = System.Convert.ToString(qSin);
        }

        private void cosh_click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cosh" + "(" + (textBox1.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = System.Convert.ToString(qCosh);
        }

        private void Cos(object sender, EventArgs e)
        {
            double qCos = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Cos" + "(" + (textBox1.Text) + ")");
            qCos = Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);
        }

        private void tanh_click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Tanh" + "(" + (textBox1.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = System.Convert.ToString(qTanh);
        }

        private void tan_click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("Tan" + "(" + (textBox1.Text) + ")");
            qTan = Math.Tan(qTan);
            textBox1.Text = System.Convert.ToString(qTan);
        }

        private void bin_click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void hex_click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void oct_click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void sqr_click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void cube_click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void one_by_x_click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0/Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void convert_click(object sender, EventArgs e)
        {
            switch(ioperation)
            {
                case 'C':
                //Celsius to Fahrenheit
                icelsius = float.Parse(txtConvert.Text);
            lblConvert.Text = ((((9 * icelsius) / 5) + 32).ToString());
            break;

                case 'F':
                    // Fahrenheit to Celsius
                    ifahrenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((ifahrenheit-32) * 5) / 9).ToString());
                    break;

                case 'K':
                    // Kelvin
                    ikelvin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9*ikelvin) / 5) + 32)+273.15).ToString());
                    break;
            }

        }

        private void celToFah_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'C';
        }

        private void fahTocel_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'F';
        }

        private void kelvin_CheckedChanged(object sender, EventArgs e)
        {
            ioperation = 'K';
        }

        private void reset_click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            celToFah.Checked = false;
            fahTocel.Checked = false;
            kelvin.Checked = false;
        }

        private void times_click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(tblmultiply.Text);
            for (int i=1; i < 13; i++ )
            {
                listmultiply.Items.Add( i + "x" + a + "=" + a * i);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreset_click(object sender, EventArgs e)
        {
            listmultiply.Items.Clear();
            tblmultiply.Clear();
        }

        private void listmultiply_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConvert_TextChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void tblmultiply_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnx_click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("ln" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void percent_click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

    }
}
