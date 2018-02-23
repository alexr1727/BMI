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
    public partial class Form3 : Form
    {
        public Form3()
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

        void button2_Click(object sender, EventArgs e)
        {

            try {
                decimal height_m = Convert.ToDecimal(height.Text);
                decimal weight_m = Convert.ToDecimal(kg.Text);

                if (height.Text == string.Empty
                        || kg.Text == string.Empty) ;
                {
                    MessageBox.Show("Please enter a number");

                }

                decimal height_squ = height_m * height_m;

                decimal con_m = (weight_m / height_squ);

                decimal tron_2 = Math.Round(con_m, 2);

                string bmi_str_m = Convert.ToString(tron_2);
                string Message = "Your BMI is ";
                string Message_2 = bmi_str_m;
                string General_Message = "For the infomation you entered: \n\n" + height_m + " Meters " + " and " + weight_m + " Pounds\n";
                string Normal = "You fall in the Normal Category.";
                string Overweight = "You fall in the Overweight Category.";
                string obese = "You fall in the Obese Category.";
                label6.Text = General_Message + Message + Message_2;


                if (tron_2 < 19)
                {
                    label7.Text = "You fall in the Underweight Category.";
                }

                if (tron_2 > 19 | tron_2 > 24)
                {
                    label7.Text = Normal;

                }

                if (tron_2 > 25 | tron_2 > 30)
                {
                    label7.Text = Overweight;
                }

                if (tron_2 > 31)
                {
                    label7.Text = obese;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Input was not in the correct format! \n \n \t         Try Again:");



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {






        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit? ",
                "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
        
    
    

