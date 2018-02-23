using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();/*hides main form*/

            /*shows new form*/
            Form1 hq = new Form1();
            hq.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {

                double feet_z = Convert.ToInt32(feet.Text);
                double inches_z = Convert.ToInt32(inches.Text);
                double weight_z = Convert.ToInt32(pounds.Text);

                double inches_con = (feet_z * 12) + inches_z;

                double height_squ = (inches_con * inches_con);

                double answer = (weight_z / height_squ) * 703;
                double bmi = Math.Round(answer, 2);
                string bmi_str = Convert.ToString(bmi);
                string Message = "Your BMI is ";
                string Message_2 = bmi_str + ".";
                string General_Message = "For the infomation you entered: \n\n" + feet_z + " feet " + inches_z + " inches" + " and " + weight_z + " pounds\n";
                string Normal = "You fall in the Normal Category.";
                string Overweight = "You fall in the Overweight Category.";
                string obese = "You fall in the Obese Category.";

                label6.Text = General_Message + Message + Message_2;
                if (answer < 19)
                {
                    label7.Text = "You fall in the Underweight Category.";
                }

                if (answer > 19 | answer > 24)
                {
                    label7.Text = Normal;

                }

                if (answer > 25 | answer > 30)
                {
                    label7.Text = Overweight;
                }

                if (answer > 31)
                {
                    label7.Text = obese;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Input was not in the correct format! \n \n \t         Try Again:");



            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

