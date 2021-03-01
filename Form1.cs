using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Numbers
{
    public partial class Form1 : Form
    {

        Random generator = new Random();

        string ranF;
        int maxInt;
        int minInt;
        int ran;
        double dMax;
        double dMin;
        double ranD;




        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            //Int

                maxInt = Convert.ToInt32(txtMax.Text);
                minInt = Convert.ToInt32(txtMin.Text);



                ran = generator.Next(minInt, maxInt+1);
                ranF = Convert.ToString(ran);
                lblRandom.Text = $"Integer: {ranF}";



        }


        private void btnDouble_Click(object sender, EventArgs e)
        {
            //Double


            dMax = Convert.ToDouble(txtMax.Text);
            dMin = Convert.ToDouble(txtMin.Text);

            ranD = generator.NextDouble() * (dMax - dMin) + dMin;
            ranF = Convert.ToString(ranD);
            lblRandom.Text = $"Double: {ranF}";
        }
    }
}
