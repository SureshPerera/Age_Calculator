using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpCurrentDate.Value < dtpDateOfBirthday.Value)
                {
                    MessageBox.Show("Current Data Must Be Greater then DOB ");
                }else
                {
                   int age = dtpCurrentDate.Value.Year - dtpDateOfBirthday.Value.Year;

                    labelResult.Text = "Your Age : " + age.ToString();
                }
               btnClear.Enabled = true;


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            labelResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDateOfBirthday.Focus();
            btnClear.Enabled = false;
        }
    }
}
