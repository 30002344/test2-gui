using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winmaths
{
    public partial class Form1 : Form
    {
        static int Num1;
        static int Num2;
        static int Answer;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToInt32(txtNum1.Text);
            Num2 = Convert.ToInt32(txtNum2.Text);
            Answer = Num1 + Num2;
            txtAnswer.Text = Convert.ToString(Answer);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Focus();
        }
    }
}
