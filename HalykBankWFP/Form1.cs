using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalykBankWFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            string name = box_name.Text;
            int age = Convert.ToInt32(box_age.Text);
            int result = Convert.ToInt32(box_test.Text);
            if (result == 4)
                lbl_result.Text = "Здравствуйте " + name + "ваш IQ = 200";
            else
                lbl_result.Text = "Здравствуйте " + name + "ваш IQ = 0";
        }
    }
}
