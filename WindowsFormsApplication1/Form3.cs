using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {

        public double min = 0;
        public double max = 0;
        public double mem = 0;
        public double r = 0;
        public double each = 0;

        public Form3()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fa = comboBox1.SelectedItem.ToString();


            

            switch (fa)
            {
                case "AFA":
                    falabel.Text = "Afternoon FA";
                    min = double.Parse(label77.Text);
                    max = double.Parse(label85.Text);
                    mem = double.Parse(label93.Text);
                    break;
                case "AMFA":
                    falabel.Text = "Ante Meridiem FA";
                    min = double.Parse(label78.Text);
                    max = double.Parse(label86.Text);
                    mem = double.Parse(label94.Text);
                    break;
                case "EEFA":
                    falabel.Text = "Early Evening FA";
                    min = double.Parse(label79.Text);
                    max = double.Parse(label87.Text);
                    mem = double.Parse(label95.Text);
                    break;
                case "EFA":
                    falabel.Text = "Evening FA";
                    min = double.Parse(label80.Text);
                    max = double.Parse(label88.Text);
                    mem = double.Parse(label96.Text);
                    break;
                case "LEFA":
                    falabel.Text = "Late Evening FA";
                    min = double.Parse(label81.Text);
                    max = double.Parse(label89.Text);
                    mem = double.Parse(label97.Text);
                    break;
                case "PFA":
                    falabel.Text = "Perpetual FA";
                    min = double.Parse(label82.Text);
                    max = double.Parse(label90.Text);
                    mem = double.Parse(label98.Text);
                    break;
                case "PTFA":
                    falabel.Text = "Prime Time FA";
                    min = double.Parse(label83.Text);
                    max = double.Parse(label91.Text);
                    mem = double.Parse(label99.Text);
                    break;
                case "TFA":
                    falabel.Text = "Timeless FA";
                    min = double.Parse(label84.Text);
                    max = double.Parse(label92.Text);
                    mem = double.Parse(label100.Text);
                    break;
                default:
                    falabel.Text = "Please select an FA";
                    break;
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String x = textBox1.Text;

            int pos;
            if (!int.TryParse(x, out pos))
            {
                pos = 1; // Default on parsing failure
            }


            if (pos.Equals(""))
            {
                label4.Text = "Please enter position.";
            }
            else if (pos == 1)
            {
                label4.Text = "" + pos + "st";
            }
            else if (pos == 2)
            {
                label4.Text = "" + pos + "nd";
            }
            else if (pos == 3)
            {
                label4.Text = "" + pos + "rd";
            }
            else
            {
                label4.Text = "" + pos + "th";
            }

            r = max - min;

            each = r / mem;


            String div = comboBox2.Text;

            int minpos = 0;
            double maxpos = 0;

            switch (div)
            {
                case "Div 1":
                    minpos = 0;
                    maxpos = 20;
                    break;
                case "Div 2":
                    minpos = 21;
                    maxpos = 40;
                    break;
                case "Div 3":
                    minpos = 41;
                    maxpos = 60;
                    break;
                case "Div 4":
                    minpos = 61;
                    maxpos = 80;
                    break;
                case "Div 5":
                    minpos = 81;
                    maxpos = 100;
                    break;
                default:
                    break;
            }

            String text = textBox1.Text;
            int p = Int32.Parse(text);

            double ps =(minpos + p - 1);

            double minrep = ((mem - minpos) * each) + min;

            if (mem < maxpos)
            {
                maxpos = mem;
            }

            double maxrep = ((mem - maxpos) * each) + min;

            label101.Text = "The maximum possible rep for finishing 1st = " + minrep.ToString();
            label102.Text = "The minimum possible rep for finishing last = " + maxrep.ToString();

            double rep = (mem - ps) * each + min;

            label43.Text = rep.ToString("#.##");

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String div = comboBox2.SelectedItem.ToString();

            switch (div)
            {
                case "Div 1":
                    label5.Text = "Division 1";
                    break;
                case "Div 2":
                    label5.Text = "Division 2";
                    break;
                case "Div 3":
                    label5.Text = "Division 3";
                    break;
                case "Div 4":
                    label5.Text = "Division 4";
                    break;
                case "Div 5":
                    label5.Text = "Division 5";
                    break;
                default:
                    label5.Text = "Please select a Div";
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label25.Text = textBox2.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label29.Text = textBox6.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label26.Text = textBox3.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label30.Text = textBox7.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label27.Text = textBox4.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label31.Text = textBox8.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label28.Text = textBox5.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            label32.Text = textBox9.Text;
        }

        private void label25_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;


            if (label29.Text == "0")
            {
                label33.Text = label25.Text;
            }
            else
            {
                double l = double.Parse(label25.Text);
                double c = double.Parse(label29.Text);

                l = l / 2;
                c = c / 2;

                if (l >= c)
                {
                    b = l / 2;
                    l = l + b;
                }
                else
                {
                    b = c / 2;
                    c = c + b;
                }

                r = l + c;
                String x = r.ToString();
                label33.Text = x;
            }
        }


        private void label29_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;

            if (label25.Text == "0")
            {
                label33.Text = label29.Text;
            }
            else
            {
                double l = double.Parse(label25.Text);
                double c = double.Parse(label29.Text);
                c = c / 2;
                l = l / 2;

                if (c >= l)
                {
                    b = c / 2;
                    c = c + b;
                }
                else
                {
                    b = l / 2;
                    l = l + b;
                }

                r = l + c;
                String x = r.ToString();
                label33.Text = x;

            }
        }

        private void label26_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;

            if (label30.Text == "0")
            {
                label34.Text = label26.Text;
            }
            else
            {
                double l = double.Parse(label26.Text);
                double c = double.Parse(label30.Text);

                l = l / 2;
                c = c / 2;

                if (l >= c)
                {
                    b = l / 2;
                    l = l + b;
                }
                else
                {
                    b = c / 2;
                    c = c + b;
                }

                r = l + c;
                String x = r.ToString();
                label34.Text = x;
            }
        }

        private void label30_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;

            if (label26.Text == "0")
            {
                label34.Text = label30.Text;
            }
            else
            {
                double l = double.Parse(label26.Text);
                double c = double.Parse(label30.Text);
                c = c / 2;
                l = l / 2;

                if (c >= l)
                {
                    b = c / 2;
                    c = c + b;
                }
                else
                {
                    b = l / 2;
                    l = l + b;
                }

                r = l + c;
                String x = r.ToString();
                label34.Text = x;

            }
        }

        private void label27_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;


            if (label31.Text == "0")
            {
                label35.Text = label27.Text;
            }
            else
            {
                double l = double.Parse(label27.Text);
                double c = double.Parse(label31.Text);

                l = l / 2;
                c = c / 2;

                if (l >= c)
                {
                    b = l / 2;
                    l = l + b;
                }
                else
                {
                    b = c / 2;
                    c = c + b;
                }

                r = l + c;
                String x = r.ToString();
                label35.Text = x;
            }
        }

        private void label31_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;

            if (label27.Text == "0")
            {
                label35.Text = label31.Text;
            }
            else
            {
                double l = double.Parse(label27.Text);
                double c = double.Parse(label31.Text);
                c = c / 2;
                l = l / 2;

                if (c >= l)
                {
                    b = c / 2;
                    c = c + b;
                }
                else
                {
                    b = l / 2;
                    l = l + b;
                }

                r = l + c;
                String x = r.ToString();
                label35.Text = x;

            }
        }

        private void label28_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;


            if (label32.Text == "0")
            {
                label36.Text = label28.Text;
            }
            else
            {
                double l = double.Parse(label28.Text);
                double c = double.Parse(label32.Text);

                l = l / 2;
                c = c / 2;

                if (l >= c)
                {
                    b = l / 2;
                    l = l + b;
                }
                else
                {
                    b = c / 2;
                    c = c + b;
                }

                r = l + c;
                String x = r.ToString();
                label36.Text = x;
            }
        }

        private void label32_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;

            if (label28.Text == "0")
            {
                label36.Text = label32.Text;
            }
            else
            {
                double l = double.Parse(label28.Text);
                double c = double.Parse(label32.Text);
                c = c / 2;
                l = l / 2;

                if (c >= l)
                {
                    b = c / 2;
                    c = c + b;
                }
                else
                {
                    b = l / 2;
                    l = l + b;
                }

                r = l + c;
                String x = r.ToString();
                label36.Text = x;

            }
        }

        private void label24_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label24.Text);
            r = r * 30 / 100;

            String x = r.ToString();
            label37.Text = x;
        }

        private void label33_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label33.Text);
            r = r * 25 / 100;

            String x = r.ToString();
            label38.Text = x;
        }

        private void label34_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label34.Text);
            r = r * 20 / 100;

            String x = r.ToString();
            label39.Text = x;
        }

        private void label35_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label35.Text);
            r = r * 15 / 100;

            String x = r.ToString();
            label40.Text = x;
        }

        private void label36_TextChanged(object sender, EventArgs e)
        {
            double r = double.Parse(label36.Text);
            r = r * 10 / 100;

            String x = r.ToString();
            label41.Text = x;
        }

        private void label37_TextChanged(object sender, EventArgs e)
        {
            //adds rep from seasons to calculate total projected rep
            double a = double.Parse(label37.Text);
            double b = double.Parse(label38.Text);
            double c = double.Parse(label39.Text);
            double d = double.Parse(label40.Text);
            double f = double.Parse(label41.Text);

            double r = a + b + c + d + f;
            String x = r.ToString();
            label57.Text = x;
        }
    }
}
    


