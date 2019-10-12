using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;








namespace ts3
{

    

   
    public   partial  class DialogBox2 : System.Windows.Forms.Form
    {
       // List<Object> draws4 = new List< Object>();

        public int[,] data_mine4 = new int[200000, 80];
        int counterwords = 0;

        public DialogBox2(Object  draw5, Array data_mine2 )
 
        {


              data_mine4 = (int[,])data_mine2;

            InitializeComponent();
            
            
        }

     





        private void DialogBox2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            richTextBox1.Clear();
          

            int nv6=0;
            //string nv10=new string (\n);

            int nv1 =(int) numericUpDown1.Value;
            int nv2 = (int)numericUpDown2.Value;
            int nv12 = (int)numericUpDown3.Value;
            int nv3 = data_mine4[0, 4];
            int nv8 = 0;
            int nv9 = 0;
            if (nv2 == 5)
            {
                nv8 = 0;
                nv9 = 1;
            }
            else if (nv2 == 4)
            {
                nv8 = 1;
                nv9 = 6;

            }

            else if (nv2 == 3)
            {
                nv8 = 6;
                nv9 = 16;

            }

            else if (nv2 == 2)
            {
                nv8 = 16;
                nv9 = 26;

            }
            else if (nv2 == 1)
            {
                nv8 = 26;
                nv9 = 31;

            }

            richTextBox1.Text +=("Draw"+"          "  + "Numbers Count"+"               "+"Characters count"+"\n");

                for (int nv4 = 0; nv4 < 1200; nv4++)
                {

                    for (int nv5 = nv8; nv5 < nv9; nv5++)
                    {
                        nv6 = data_mine4[nv4, nv5];
                        if (nv6 >= nv1)
                        {

                            

                            richTextBox1.Text +=( nv4.ToString()+"                     "+  nv6.ToString()+"                                   "+counterwords.ToString()+"\n");
                            //nv10=\;
                           // richTextBox1.Text += nv10;
                            

                        }


                        



                    }

                    counterwords = richTextBox1.Text.Length;
                    if (counterwords >= nv12)
                        break;



        }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}