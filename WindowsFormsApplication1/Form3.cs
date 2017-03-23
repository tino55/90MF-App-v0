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
                    break;
                case "AMFA":
                    falabel.Text = "Ante Meridiem FA";
                    break;
                case "EEFA":
                    falabel.Text = "Early Evening FA";
                    break;
                case "EFA":
                    falabel.Text = "Evening FA";
                    break;
                case "LEFA":
                    falabel.Text = "Late Evening FA";
                    break;
                case "PFA":
                    falabel.Text = "Perpetual FA";
                    break;
                case "PTFA":
                    falabel.Text = "Prime Time FA";
                    break;
                case "TFA":
                    falabel.Text = "Timeless FA";
                    break;
                default:
                    falabel.Text = "Please select an FA";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String pos = textBox1.Text;
            label4.Text = "" + pos + "th";
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
    }
    }

