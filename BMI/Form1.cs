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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();/*hides main form*/

            /*shows new form*/
            Form2 standard = new Form2();
            standard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();/*hides main form*/

            /*shows new form*/
            Form3 metric = new Form3();
            metric.ShowDialog();
        }
    }
}
