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
    public partial class repCalc : Form
    {

        public double min = 0;
        public double max = 0;
        public double mem = 0;
        public double r = 0;
        public double each = 0;
        public double maxmon = 0;
        public double ps = 0;
        public int p = 0;
        public double maxcup = 0;
        public int rounds = 1;
        public double comrounds = 0;
        public double comrep = 0;

        public repCalc()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;



        }

        //main menu button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //fa combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox8.SelectedItem = comboBox1.SelectedItem;

            String fa = comboBox1.SelectedItem.ToString();

            
            
            switch (fa)
            {
                case "AFA":
                    falabel.Text = "Afternoon FA";
                    min = double.Parse(label77.Text);
                    max = double.Parse(label85.Text);
                    mem = double.Parse(label93.Text);
                    maxmon = 4125357;
                    maxcup = max * 90 / 100;
                    comrounds = 4;
                    comrep = max * 85 / 100;
                    break;
                case "AMFA":
                    falabel.Text = "Ante Meridiem FA";
                    min = double.Parse(label78.Text);
                    max = double.Parse(label86.Text);
                    mem = double.Parse(label94.Text);
                    maxmon = 4380446;
                    maxcup = max * 90 / 100;
                    comrounds = 5;
                    comrep = max * 85 / 100;
                    break;
                case "EEFA":
                    falabel.Text = "Early Evening FA";
                    min = double.Parse(label79.Text);
                    max = double.Parse(label87.Text);
                    mem = double.Parse(label95.Text);
                    maxmon = 5557589;
                    maxcup = max * 90 / 100;
                    comrounds = 5;
                    comrep = max * 85 / 100;
                    break;
                case "EFA":
                    falabel.Text = "Evening FA";
                    min = double.Parse(label80.Text);
                    max = double.Parse(label88.Text);
                    mem = double.Parse(label96.Text);
                    maxmon = 6061964;
                    maxcup = max * 90 / 100;
                    comrounds = 7;
                    comrep = max * 85 / 100;
                    break;
                case "LEFA":
                    falabel.Text = "Late Evening FA";
                    min = double.Parse(label81.Text);
                    max = double.Parse(label89.Text);
                    mem = double.Parse(label97.Text);
                    maxmon = 4590803;
                    maxcup = max * 90 / 100;
                    comrounds = 5;
                    comrep = max * 85 / 100;
                    break;
                case "PFA":
                    falabel.Text = "Perpetual FA";
                    min = double.Parse(label82.Text);
                    max = double.Parse(label90.Text);
                    mem = double.Parse(label98.Text);
                    maxmon = 6206160;
                    maxcup = max * 90 / 100;
                    comrounds = 7;
                    comrep = max * 85 / 100;
                    break;
                case "PTFA":
                    falabel.Text = "Prime Time FA";
                    min = double.Parse(label83.Text);
                    max = double.Parse(label91.Text);
                    mem = double.Parse(label99.Text);
                    maxmon = 5024017;
                    maxcup = max * 90 / 100;
                    comrounds = 4;
                    comrep = max * 85 / 100;
                    break;
                case "TFA":
                    falabel.Text = "Timeless FA";
                    min = double.Parse(label84.Text);
                    max = double.Parse(label92.Text);
                    mem = double.Parse(label100.Text);
                    maxmon = 4801250;
                    maxcup = max * 90 / 100;
                    comrounds = 4;
                    comrep = max * 85 / 100;
                    break;
                default:
                    falabel.Text = "Please select an FA";
                    break;
            }
             
            
           
        }

        //position text box
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
            p = Int32.Parse(text);

            ps =(minpos + p - 1);

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


        //division combo box
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

        //copys values form textboxes to labels
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


        //calcs to change labels to user inputs
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

        private void label43_TextChanged(object sender, EventArgs e)
        {
            label22.Text = label43.Text;
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;


            if (label23.Text == "0")
            {
                label24.Text = label22.Text;
            }
            else
            {
                double l = double.Parse(label22.Text);
                double c = double.Parse(label23.Text);

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
                label24.Text = x;
            }
        }

        private void label23_TextChanged(object sender, EventArgs e)
        {
            double r = 0;
            double b = 0;

            if (label22.Text == "0")
            {
                label24.Text = label23.Text;
            }
            else
            {
                double l = double.Parse(label22.Text);
                double c = double.Parse(label23.Text);
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
                label24.Text = x;

            }

        }

        private void label41_TextChanged(object sender, EventArgs e)
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

        private void label40_TextChanged(object sender, EventArgs e)
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

        private void label39_TextChanged(object sender, EventArgs e)
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

        private void label38_TextChanged(object sender, EventArgs e)
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

        private void label57_TextChanged(object sender, EventArgs e)
        {
            double monper = maxmon / (mem-1);
            double perpos = (mem - ps) * monper;
            label103.Text = " Estimated Prizemoney = £" + perpos.ToString("#");
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cuptext = comboBox3.SelectedItem.ToString(); ;
            double cup = 0;
            
            double cupeach = maxcup / rounds - 1;

            switch (cuptext)
            {
                case "1st":
                    cup = 0;
                    break;
                case "2nd":
                    cup = cupeach;
                    break;
                case "3rd":
                    cup = cupeach * 2;
                    break;
                case "4th":
                    cup = cupeach * 3;
                    break;
                case "5th":
                    cup = cupeach * 5;
                    break;
                case "6th":
                    cup = cupeach * 6;
                    break;
                case "Final":
                    cup = cupeach * 7;
                    break;
                case "Winner":
                    cup = cupeach * 8;
                    break;
                default:
                    break;
            }

            label51.Text = cup.ToString("#.##");
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox8.SelectedItem;

            

            if (mem <= 8)
            {
                rounds = 3;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1st");
                comboBox3.Items.Add("2nd");
                comboBox3.Items.Add("Final");
                comboBox3.Items.Add("Winner");
                
            }
            else if (mem <= 16)
            {
                rounds = 4;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1st");
                comboBox3.Items.Add("2nd");
                comboBox3.Items.Add("3rd");
                comboBox3.Items.Add("Final");
                comboBox3.Items.Add("Winner");
                
            }
            else if (mem <= 32)
            {
                rounds = 5;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1st");
                comboBox3.Items.Add("2nd");
                comboBox3.Items.Add("3rd");
                comboBox3.Items.Add("4th");
                comboBox3.Items.Add("Final");
                comboBox3.Items.Add("Winner");
            }
            else if (mem <= 64)
            {
                rounds = 6;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1st");
                comboBox3.Items.Add("2nd");
                comboBox3.Items.Add("3rd");
                comboBox3.Items.Add("4th");
                comboBox3.Items.Add("5th");
                comboBox3.Items.Add("Final");
                comboBox3.Items.Add("Winner");
            }
            else
            {
                rounds = 7;
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1st");
                comboBox3.Items.Add("2nd");
                comboBox3.Items.Add("3rd");
                comboBox3.Items.Add("4th");
                comboBox3.Items.Add("5th");
                comboBox3.Items.Add("6th");
                comboBox3.Items.Add("Final");
                comboBox3.Items.Add("Winner");

            }

            if (comrounds == 3)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("1st");
                comboBox4.Items.Add("2nd");
                comboBox4.Items.Add("Final");
                comboBox4.Items.Add("Winner");

            }
            else if (comrounds == 4)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("1st");
                comboBox4.Items.Add("2nd");
                comboBox4.Items.Add("3rd");
                comboBox4.Items.Add("Final");
                comboBox4.Items.Add("Winner");

            }
            else if (comrounds ==5)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("1st");
                comboBox4.Items.Add("2nd");
                comboBox4.Items.Add("3rd");
                comboBox4.Items.Add("4th");
                comboBox4.Items.Add("Final");
                comboBox4.Items.Add("Winner");
            }
            else if (comrounds==6)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("1st");
                comboBox4.Items.Add("2nd");
                comboBox4.Items.Add("3rd");
                comboBox4.Items.Add("4th");
                comboBox4.Items.Add("5th");
                comboBox4.Items.Add("Final");
                comboBox4.Items.Add("Winner");
            }
            else
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("1st");
                comboBox4.Items.Add("2nd");
                comboBox4.Items.Add("3rd");
                comboBox4.Items.Add("4th");
                comboBox4.Items.Add("5th");
                comboBox4.Items.Add("6th");
                comboBox4.Items.Add("Final");
                comboBox4.Items.Add("Winner");

            }
        }

        private void label51_TextChanged(object sender, EventArgs e)
        {

            double facup;
            if (!double.TryParse(label51.Text, out facup))
            {
                facup = 0; // Default on parsing failure
            }
            double comcup;
            if (!double.TryParse(label52.Text, out comcup))
            {
                comcup = 0; // Default on parsing failure
            }
            double ninecup;
            if (!double.TryParse(label53.Text, out ninecup))
            {
                ninecup = 0; // Default on parsing failure
            }
            double chcup;
            if (!double.TryParse(label54.Text, out chcup))
            {
                chcup = 0; // Default on parsing failure
            }
            double spcup;
            if (!double.TryParse(label55.Text, out spcup))
            {
                spcup = 0; // Default on parsing failure
            }


            if (facup > comcup 
                && facup > ninecup 
                && facup > chcup 
                && facup > spcup)
            {
                label50.Text = facup.ToString();
            }
        }

        private void label52_TextChanged(object sender, EventArgs e)
        {
            double facup;
            if (!double.TryParse(label51.Text, out facup))
            {
                facup = 0; // Default on parsing failure
            }
            double comcup;
            if (!double.TryParse(label52.Text, out comcup))
            {
                comcup = 0; // Default on parsing failure
            }
            double ninecup;
            if (!double.TryParse(label53.Text, out ninecup))
            {
                ninecup = 0; // Default on parsing failure
            }
            double chcup;
            if (!double.TryParse(label54.Text, out chcup))
            {
                chcup = 0; // Default on parsing failure
            }
            double spcup;
            if (!double.TryParse(label55.Text, out spcup))
            {
                spcup = 0; // Default on parsing failure
            }

            if (comcup > facup
                && facup > ninecup
                && facup > chcup
                && facup > spcup)
            {
                label50.Text = comcup.ToString();
            }
        }

        private void label53_TextChanged(object sender, EventArgs e)
        {
            double facup;
            if (!double.TryParse(label51.Text, out facup))
            {
                facup = 0; // Default on parsing failure
            }
            double comcup;
            if (!double.TryParse(label52.Text, out comcup))
            {
                comcup = 0; // Default on parsing failure
            }
            double ninecup;
            if (!double.TryParse(label53.Text, out ninecup))
            {
                ninecup = 0; // Default on parsing failure
            }
            double chcup;
            if (!double.TryParse(label54.Text, out chcup))
            {
                chcup = 0; // Default on parsing failure
            }
            double spcup;
            if (!double.TryParse(label55.Text, out spcup))
            {
                spcup = 0; // Default on parsing failure
            }

            if (ninecup > comcup
                && ninecup > facup
                && ninecup > chcup
                && ninecup > spcup)
            {
                label50.Text = ninecup.ToString();
            }
        }

        private void label54_TextChanged(object sender, EventArgs e)
        {
            double facup;
            if (!double.TryParse(label51.Text, out facup))
            {
                facup = 0; // Default on parsing failure
            }
            double comcup;
            if (!double.TryParse(label52.Text, out comcup))
            {
                comcup = 0; // Default on parsing failure
            }
            double ninecup;
            if (!double.TryParse(label53.Text, out ninecup))
            {
                ninecup = 0; // Default on parsing failure
            }
            double chcup;
            if (!double.TryParse(label54.Text, out chcup))
            {
                chcup = 0; // Default on parsing failure
            }
            double spcup;
            if (!double.TryParse(label55.Text, out spcup))
            {
                spcup = 0; // Default on parsing failure
            }

            if (chcup > comcup
                && chcup > ninecup
                && chcup > facup
                && chcup > spcup)
            {
                label50.Text = chcup.ToString();
            }
        }

        private void label55_TextChanged(object sender, EventArgs e)
        {
            double facup;
            if (!double.TryParse(label51.Text, out facup))
            {
                facup = 0; // Default on parsing failure
            }
            double comcup;
            if (!double.TryParse(label52.Text, out comcup))
            {
                comcup = 0; // Default on parsing failure
            }
            double ninecup;
            if (!double.TryParse(label53.Text, out ninecup))
            {
                ninecup = 0; // Default on parsing failure
            }
            double chcup;
            if (!double.TryParse(label54.Text, out chcup))
            {
                chcup = 0; // Default on parsing failure
            }
            double spcup;
            if (!double.TryParse(label55.Text, out spcup))
            {
                spcup = 0; // Default on parsing failure
            }

            if (spcup > comcup
                && spcup > ninecup
                && spcup > chcup
                && spcup > facup)
            {
                label50.Text = spcup.ToString();
            }
        }

        private void label50_TextChanged(object sender, EventArgs e)
        {
            label23.Text = label50.Text;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxcup = 58;
            double mincup = 29;
            rounds = 5;

            double r = maxcup - mincup;
            double each = r / (rounds);
            double rep = 0;

            switch (comboBox7.Text)
            {
                case "1st":
                    rep = mincup;
                    break;
                case "2nd":
                    rep = mincup + each;
                    break;
                case "3rd":
                    rep = mincup + (each * 2);
                    break;
                case "4th":
                    rep = mincup + (each * 3);
                    break;
                case "Final":
                    rep = mincup + (each * 4);
                    break;
                case "Winner":
                    rep = mincup + (each * 5);
                    break;
                default:
                    rep = 0;
                    break;
            }

            label55.Text = rep.ToString("#.##");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxcup = 48;
            double mincup = 24;
            rounds = 4;

            double r = maxcup - mincup;
            double each = r / (rounds);
            double rep = 0;

            switch (comboBox6.Text)
            {
                case "1st":
                    rep = mincup;
                    break;
                case "2nd":
                    rep = mincup + each;
                    break;
                case "3rd":
                    rep = mincup + (each * 2);
                    break;
                case "Final":
                    rep = mincup + (each * 3);
                    break;
                case "Winner":
                    rep = mincup + (each * 4);
                    break;
                default:
                    rep = 0;
                    break;
            }

            label54.Text = rep.ToString("#.##");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            maxcup = 53;
            double mincup = 0;
            rounds = 9;

            
            double each = maxcup / (rounds);
            double rep = 0;

            switch (comboBox5.Text)
            {
                case "1st":
                    rep = mincup;
                    break;
                case "2nd":
                    rep = mincup + each;
                    break;
                case "3rd":
                    rep = mincup + (each * 2);
                    break;
                case "4th":
                    rep = mincup + (each * 3);
                    break;
                case "5th":
                    rep = mincup + (each * 4);
                    break;
                case "6th":
                    rep = mincup + (each * 5);
                    break;
                case "7th":
                    rep = mincup + (each * 6);
                    break;
                case "8th":
                    rep = mincup + (each * 7);
                    break;
                case "Final":
                    rep = mincup + (each * 8);
                    break;
                case "Winner":
                    rep = mincup + (each * 9);
                    break;
                default:
                    rep = 0;
                    break;
            }

            label53.Text = rep.ToString("#.##");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cuptext = comboBox4.SelectedItem.ToString();
            double cup = 0;

            double cupeach = comrep / comrounds - 1;

            switch (cuptext)
            {
                case "1st":
                    cup = 0;
                    break;
                case "2nd":
                    cup = cupeach;
                    break;
                case "3rd":
                    cup = cupeach * 2;
                    break;
                case "4th":
                    cup = cupeach * 3;
                    break;
                case "5th":
                    cup = cupeach * 5;
                    break;
                case "6th":
                    cup = cupeach * 6;
                    break;
                case "Final":
                    cup = cupeach * 7;
                    break;
                case "Winner":
                    cup = cupeach * 8;
                    break;
                default:
                    cup = 0;
                    break;
            }

            label52.Text = cup.ToString("#.##");
        }
    }
}
    


