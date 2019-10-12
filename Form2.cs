using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ts3
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
        int n1=0, n2, n3, n4;
        int c1 = 0;



		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private BindingSource draw1BindingSource;
        private IContainer components;
        private BindingSource form2BindingSource;
        private BindingSource draw1BindingSource1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private TextBox textBox6;
        private Button button3;
        private Button button4;
        private TextBox txtSearch;
        private Button btnSearch;
        private ListView listView1;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView2;
        private TextBox textBox8;
        private Label label4;
        private Label label5;
        private TextBox textBox9;
        private ListBox listBox1;
        private Label label6;
        private ToolTip toolTip1;
        private TextBox textBox14;
        private Label label7;
        private Button button5;
        private Button button6;
        private ListView listView3;

        public List<ts3.draw1> draw11;
       
		public Form2(List<ts3.draw1>   draw,Array x)
		{
            //this.listBox1.Text = draw[666].del1.ToString();
             

            draw11 = draw;
            
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();


            
                 

            
            
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.draw1BindingSource = new System.Windows.Forms.BindingSource();
            this.form2BindingSource = new System.Windows.Forms.BindingSource();
            this.draw1BindingSource1 = new System.Windows.Forms.BindingSource();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem1});
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Edit";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "New";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Open";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 20);
            this.textBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(191, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 20);
            this.textBox6.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Location = new System.Drawing.Point(124, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(190, 163);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(45, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
            this.txtSearch.Validated += new System.EventHandler(this.txtSearch_Validated);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(121, 269);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Learn";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listView1.Location = new System.Drawing.Point(482, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 214);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(190, 210);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(44, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Delay";
            this.toolTip1.SetToolTip(this.label1, "Greater than  the  defined    delay of previously selected  count  of  numbers");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Del_Nums\r\n";
            this.toolTip1.SetToolTip(this.label2, "Define  the sum of   numbers 1-5  in draw greater  than the Delay is displayed in" +
                    " the next field");
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Draws";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Yellow;
            this.listView2.Location = new System.Drawing.Point(771, 254);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(242, 182);
            this.listView2.TabIndex = 20;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(349, 11);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(52, 20);
            this.textBox8.TabIndex = 21;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Draw_Delay";
            this.toolTip1.SetToolTip(this.label4, "Define the  history  index   draws starting  profit projection");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Num_Dev";
            this.toolTip1.SetToolTip(this.label5, "Deviation  from number of the next draw");
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(349, 50);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(52, 20);
            this.textBox9.TabIndex = 24;
            this.toolTip1.SetToolTip(this.textBox9, "Deviation of number of the next draw");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Cyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(482, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 186);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "occur";
            this.toolTip1.SetToolTip(this.label7, "Define  the occurances   deviation   greater  than the average");
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(349, 213);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(50, 20);
            this.textBox14.TabIndex = 27;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(124, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Predict";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 23);
            this.button6.TabIndex = 30;
            this.button6.Text = "Profit Projection";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listView3.Location = new System.Drawing.Point(771, 12);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(242, 214);
            this.listView3.TabIndex = 31;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // draw1BindingSource
            // 
            this.draw1BindingSource.DataSource = typeof(ts3.draw1);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(ts3.Form2);
            // 
            // draw1BindingSource1
            // 
            this.draw1BindingSource1.DataSource = typeof(ts3.draw1);
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1025, 448);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Form2";
            this.Text = "MAGIC PRO";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Form2_Load(object sender, System.EventArgs e)
		{
             
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
        {
            
		
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c9 = 0;
            int c8 = 0;
            c8 = (int)listBox1.SelectedIndex;
            c9 = (int)listBox1.SelectedItems[c8];

            int c10 = 0;

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = n1 + 1;
            if ((n1+1)  >draw11.Count )
                n1 = 0;
               textBox6.Text =n1.ToString();
            LoadParam(n1);

        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                if (textBox6.Text != "")
                {
                    n1 = Convert.ToInt32(textBox6.Text);






                    if (n1 >= draw11.Count || n1 < 0)
                    {
                        n1 = 0;
                        textBox6.Text = n1.ToString();
                    }
                    LoadParam(n1);

                }
                else
                    if (textBox6.Text == "")
                    {
                        
                        c1 = draw11.Count;
                        MessageBox.Show("Please  Insert a number from 0 to " + Convert.ToString(c1 - 1));
                    }
            }

            catch {
                c1 = draw11.Count;
                MessageBox.Show("Please  Insert a number from 0 to " + Convert.ToString(c1 - 1));
            
            }

        }

       public void  LoadParam(int i)
        {this.textBox1.Text = draw11[i].del1.ToString();
            this.textBox2.Text = draw11[i].del2.ToString();
            this.textBox3.Text = draw11[i].del3.ToString();
            this.textBox4.Text = draw11[i].del4.ToString();
            this.textBox5.Text = draw11[i].del5.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

              
            if (n1  <= 0||(n1+1)>draw11.Count)
                n1 =draw11.Count ;
            n1 = n1 - 1;
            textBox6.Text  = n1.ToString();
            LoadParam(n1);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            draw11.Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {    
            
            
            
            
            int c7=0;// count delay for each number
            int c14 = 0;//+- occurances from average
            int  c6=0;//number of draws before last draw
            int c4=0;//counter
            int c41 = 0;//counter2
            int C411=0;
            int c5 = 0;// threshold delay  for each number in draw
            int c2 = 0;//numbers 0-5 chosen from the draw bigger than c5
            listBox1.Items.Clear();
           listView1.Items.Clear();
           listView2.Items.Clear();
           listView3.Items.Clear();
            c2 = Convert.ToInt32(txtSearch.Text);
            c5 = Convert.ToInt32(textBox7.Text);
            //c6 = Convert.ToInt32(textBox8.Text);
            //c7=Convert.ToInt32(textBox9.Text);
            c14 = Convert.ToInt32(textBox14.Text);
            int avroccur1 = 0;
            for ( int c3=0; c3 <  draw11.Count; c3++)
            {
                if (draw11[c3].del1 > c5)
                    c4++;
                if (draw11[c3].occur1 >draw11[c3].avroccur+c14)
                    c41++;
               // else
                   // if 
                       // ((c3>draw11.Count-c6) &&  (draw11[c3].del1 < c7))  
                   // listView2.Items.Add(draw11[c3].num1.ToString());
                if (draw11[c3].del2 >c5)
                    c4++;
                if (draw11[c3].occur2 > draw11[c3].avroccur+c14)
                    c41++;

                //else
                  //  if (( c3 >( draw11.Count - c6)) && (draw11[c3].del2 < c7)) 
               // listView2.Items.Add(draw11[c3].num2.ToString());

                if (draw11[c3].del3> c5)
                    c4++;
                if (draw11[c3].occur3 > draw11[c3].avroccur+c14)
                    c41++;

                //else
                    //if ((c3 >( draw11.Count - c6)) && (draw11[c3].del3 < c7) )  
                //listView2.Items.Add(draw11[c3].num3.ToString());
                if (draw11[c3].del4 > c5)
                    c4++;

                if (draw11[c3].occur4 > draw11[c3].avroccur+c14)
                    c41++;

               // else
                   // if ((c3> (draw11.Count - c6)) && (draw11[c3].del4 < c7))  
                    //listView2.Items.Add(draw11[c3].num4.ToString());


                if (draw11[c3].del5 > c5)
                    c4++;

                if (draw11[c3].occur5 > draw11[c3].avroccur+c14)
                    c41++;

               // else
                   // if ((c3> (draw11.Count - c6)) && (draw11[c3].del5 < c7))  
                  //  listView2.Items.Add(draw11[c3].num5.ToString());
                
                 
                    if ((c4 == c2) && (c41 ==c2))
                    {


                        listBox1.Items.Add(draw11[c3].index.ToString());


                    }
                 
                c4 = 0;
                c41 = 0;
            }

               
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int c8;
           // ListView.SelectedListViewItemCollection indexes =this.listView1.SelectedItems;

         




        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int c9 = 0;
                int c8 = 0;
                c8 = (int)listBox1.SelectedIndex;

                label6.Text =  listBox1.SelectedItem.ToString();
                c9 = Convert.ToInt32(listBox1.SelectedItem);
               // c8 = (int)listBox1.SelectedIndex;
                int c10 = 0;

                nums_pop(c9);
            }
            catch
            {
                MessageBox.Show("problem with counter");
            }


        }

  public  void      nums_pop(int  c11)
  {
      int c15 = 0;
      int c14 = 0;
      int c2 = 0;//sum of numbers
            int c6 = 0;//delays greater than  c6 value
            int c7 = 0;//deviation from average  occurances
           // int c15 = 0;//counter
            c2 = Convert.ToInt32(txtSearch.Text);
            c6 = Convert.ToInt32(textBox7.Text);
           // c7 = Convert.ToInt32(textBox9.Text);
               c7 = Convert.ToInt32(textBox14.Text);
      //c11 number of current selected draw  from  listBox
               c14 = Convert.ToInt32(textBox14.Text);
            listView2.Items.Clear();
            for ( int c18 = 0; c18 < 45; c18++)
            {
                if (draw11[c11].nums_del_array[c18] > c6 && draw11[c11].nums_occur_array[c18]> draw11[c11].avroccur + c7)

                    listView2.Items.Add((c18+1).ToString());








            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Define the Numbers 1-5 Lower the Delay Defined in Delay Field");
            


        }

        private void button5_Click(object sender, EventArgs e)
        {


            try
            {
                int c9 = 0;
                int c8 = 0;
               // c8 = (int)listBox1.SelectedIndex;
                c9=draw11.Count-1;
              //  label6.Text = listBox1.SelectedItem.ToString();
                //c9 = Convert.ToInt32(listBox1.SelectedItem);
                // c8 = (int)listBox1.SelectedIndex;
                int c10 = 0;

                nums2_pop(c9);
            }
            catch
            {
                MessageBox.Show("problem with counter");
            }














        }

        public void nums2_pop(int c11)
        {
            int c15 = 0;
            int c14 = 0;
            int c2 = 0;//count of numbers
            int c6 = 0;//delays greater than  c6 value  of  c2 numbers
            int c7 = 0;//deviation from average  occurances
            // int c15 = 0;//counter
            c2 = Convert.ToInt32(txtSearch.Text);
            c6 = Convert.ToInt32(textBox7.Text);
            // c7 = Convert.ToInt32(textBox9.Text);
            c7 = Convert.ToInt32(textBox14.Text);
            //c11 number of current selected draw  from  listBox
            //c14 = Convert.ToInt32(textBox14.Text);
            listView1.Items.Clear();
            for (int c18 = 0; c18 < 45; c18++)
            {
                if (draw11[c11].nums_del_array[c18] > c6 && draw11[c11].nums_occur_array[c18] > draw11[c11].avroccur + c7)

                    listView1.Items.Add((c18 + 1).ToString());








            }


        }

        private void button6_Click(object sender, EventArgs e)
        {


            nums4_pop();
             


             

        }
        public void nums4_pop()
        {
            int c33 = 0, c34 = 0, c35 = 0;
int  []  temp=new int[45];

int c11 = 0;
            int c22=0;
            int c15 = 0;//deviation from number of next draw
            int c2 = 0;//  count of numbers  for the delayd defined in c6 for each draw
            int c14 = 0;//profit projection of draws(the point to start the history index draw projecting)
            int c6 = 0;//delays greater than  c6 value for the numbers defined in c2
            int c7 = 0;//deviation from average  occurances
            // int c15 = 0;//counter




            
            c14 = Convert.ToInt32(textBox8.Text);//COUNT  OF  DRAW
            c6 = Convert.ToInt32(textBox7.Text);//DELAYS
            c7 = Convert.ToInt32(textBox14.Text);//AVER DEVIATION
             
            c2 = Convert.ToInt32(txtSearch.Text);//COUNT  OF NUMS
             c15 = Convert.ToInt32(textBox9.Text);//NUM  DEVIATION


            // c7 = Convert.ToInt32(textBox9.Text);
            //c7 = Convert.ToInt32(textBox14.Text);
            //c11 number of current selected draw  from  listBox
            //c14 = Convert.ToInt32(textBox14.Text);
            listView3.Items.Clear();


            for (c11 = c14; c11 < draw11.Count-1; c11++)
            {

                for (int c18 = 0; c18 < 45; c18++)
                {
                    if (draw11[c11].nums_del_array[c18] > c6 && draw11[c11].nums_occur_array[c18] > draw11[c11].avroccur + c7)


                        temp[c18] = c18 + 1;
                    else
                        temp[c18] = 0;



                    //store the selected numbers of specific draw by delay and occur in array temp
                    //this is the predicted numbers for the next draw
                    //then  we take the selected numbers in array temp and we project them 
                    //in the   next draw to find out any matches  from the specific prediction
                    //we have defined predictions for 3,4,5 matches
                    //the variable c15 defines  +-variation from the number of the next draw 
                }

               for(int c19=0;c19<temp.Length;c19++)
                {

                    if (    (temp[c19] + c15) == draw11[c11 + 1].num1 ||   (temp[c19] + c15)== draw11[c11 + 1].num2 ||  (temp[c19] + c15)    == draw11[c11 + 1].num3 ||  (temp[c19] + c15)== draw11[c11 + 1].num4 ||(temp[c19] + c15)== draw11[c11 + 1].num5) 
                c22++;

                }
                if (c22 == 3)
                {
                    c33++;
                    listView3.Items.Add("win 3 " + draw11[c11 + 1].index);
                }
                if (c22 == 4)
                {
                    c34++;
                    listView3.Items.Add("win 4 " + draw11[c11 + 1].index);
                }

                if (c22 == 5)
                {
                    c35++;
                    listView3.Items.Add("win 5 " + draw11[c11 + 1].index);
                }
                  c22 = 0;

            }
            listView3.Items.Add(c35+" win 5 "   );
            listView3.Items.Add(c34 + " win 4"  );
            listView3.Items.Add( c33 + " win 3");

            c35 = 0;
            c34 = 0;
            c33 = 0;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Validated(object sender, EventArgs e)
        {

        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }





         

       
	}
}
 