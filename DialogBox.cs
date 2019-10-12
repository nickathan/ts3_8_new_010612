using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace ts3
{
	/// <summary>
	/// Summary description for DialogBox.
	/// </summary>
	//public class DialogBox1 : System.Windows.Forms.Form
public  class DialogBox1:System.Windows.Forms.Form
	{
        public  System.Data.OleDb.OleDbConnection  oleDbConnection1;
	    public  System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		public  System.Windows.Forms.Button OKbutton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private new System.Windows.Forms.Button  CancelButton;
		private System.Windows.Forms.Button TrainButton;
		private System.Windows.Forms.Button PredictButton;
		private System.Windows.Forms.Label Number1;
		private System.Windows.Forms.TextBox JokerNumber;
		private System.Windows.Forms.TextBox Joker5;
		private System.Windows.Forms.TextBox Joker4;
		private System.Windows.Forms.TextBox Joker3;
		private System.Windows.Forms.TextBox Joker2;
		private System.Windows.Forms.TextBox Joker1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.HScrollBar hScrollBar1;
        public  int   total_prediction=50;
		//position [0,0]=index,[0,1]=number1,[0,2]=number2
		//[0,3]=number3,[0,4]=number4,[0,5]=number5,[0,6]=joker
        int [,]jokern = new int[8000,250];
		string [] jokerd=new string[8000];  //date
        int[,] jokern1=new int[8000,250];
		int[,] jokern2=new int [8000,250];
int n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,n11,n12,n13,n14,n15,n16,n17,n18,n19,n20,n21,n22,n23,n24,n25,n26,n27,n28,n29,n30,n31,n32,n33,n34,n35,n36,n37,n38,n39,n40,n41,n42,n43,n44,n45;

	int[,] jokern3=new int[8000,250];
	int[,] jokern4=new int [8000,250];


int[,] limits=new int[8000,250];

	/* pos 0: (1+2+3+4+5)/5  higher
	 * pos 1: (1+2+3+4+5)/5  lower
	 * pos 2:  (1+2)/2 higher
	 * pos 3:  (1+2)/2 lower
	 * pos 4:   (1+3)/2 higher
	 * pos 5:  (1+3)/2  lower
	 * pos 6:  (1+4)/2 higher
	 * pos 7:   (1+4)/2 lower
	 * pos 8:   (1+5)/2  higher
	 * pos 9:   (1+5)/2 lower
	 * pos 10: (2+3)/2 higher
	 * pos 11: (2+3)/2 lower
	 * pos 12:  (2+4)/2 higher
	 * pos 13:  (2+4)/2 lower
	 * pos 14:   (2+5)/2  higher
	 * pos 15:  (2+5)/2  lower
	 * pos 16:  (3+4)/2  higher
	 * pos 17:  (3+4)/2  lower
	 * poa 18:  (3+5)/2  higher
	 * pos 19:  (3+5)/2  lower
	 * pos 20:  (4+5)/2  higher
	 * pos 21:  (4+5)/2  lower
	 * pos 22:  (1+2+3)/3 higher
	 * pos 23:  (1+2+3)/3 lower
	 * pos 24: (1+2+4)/3 higher
	 * pos 25:(1+2+4)/3 lower
	 * pos 26: (1+2+5)/3 higher
	 * pos 27:  (1+2+5)/3 lower
	 * pos 28:  (2+3+4)/3 higher
	 * pos 29:  (2+3+4)/3 lower
	 * pos 30:  (2+3+5)/3 higher
	 * pos 31:   (2+3+5)/3 lower
	 * pos 32:   (3+4+5)/3 higher
	 * pos 33:  (3+4+5)/3 lower
	 * pos 34:   (1+3+4)/3  higher
	 * pos 35:   (1+3+4)/3  lower
	 * pos 36:  (1+4+5)/3  higher
	 * pos 37:   (1+4+5)/3 lower
	 * pos 38:   (1+3+5)/3  higher
	 * pos 39:    (1+3+5)/3 lower
	 * pos 40:  (1+2+3+4)/4  higher
	 * pos 41:   (1+2+3+4)/4  lower
	 * pos 42:  (1+2+4+5)/4 higher
	 * pos 43:   (1+2+4+5)/4 lower
	 * pos 44:  (2+3+4+5)/4  higher
	 * pos 45:   (2+3+4+5)/4  lower
	 * pos 46:  (1+3+4+5)/4  higher
	 * pos 47:   (1+3+4+5)/4 lower
	 * pos 48:    odds
	 * pos 49:    evens
	 * pos 50:   average odds
	 * pos 51:   average evens
	 * pos 52:   5-0  odds/evens
	 * pos 53:   4-1      >>
	 * pos 54:   3-2      >>
	 * pos 55:   1-4      >>
	 * pos 56:   0-5      >>
	 * pos 57:
	 * pos 58:
	 * pos 59:
	 * pos 60:
	 * pos 61:
	 * pos 62:
	 * pos 63:
	 * pos 64:
	 * pos 65:
	 * 
	 * 
	 * 
	 * 
	 * 
	 * pos 101   the numbers respectively 1-45
	 * pos 145
	 * pos 146
	 * 
	 * pos 181  
	 * pos 201   jokers 1-20
	 * pos 220
	 * 
	  */
	int r15=0;

	int ri11=0,ri12=0,ri15=0;
	int  ri10=0;
	int ri7=0;
	int  ri6=0;
	DataSet dataset1;
	private System.Windows.Forms.TextBox txtIndex;
	private System.Windows.Forms.Label lblIndex;
	private System.Windows.Forms.Label lblDate;
	private System.Windows.Forms.TextBox txtDate;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.TextBox textBox6;
	private System.Windows.Forms.TextBox textBox7;
	private System.Windows.Forms.TextBox textBox8;
	private System.Windows.Forms.TextBox textBox9;
	private System.Windows.Forms.TextBox textBox10;
	private System.Windows.Forms.Button button4;
	private System.Windows.Forms.ListBox TtDlistBox;
	private System.Windows.Forms.ListBox D1listBox1;
	private System.Windows.Forms.ListBox D1listBox2;
	private System.Windows.Forms.ListBox EolistBox;
	private System.Windows.Forms.ListBox D2listBox1;
	private System.Windows.Forms.ListBox D2listBox2;
	private System.Windows.Forms.ListBox D3listBox1;
	private System.Windows.Forms.ListBox D3listBox2;
	private System.Windows.Forms.CheckBox EocheckBox;
	private System.Windows.Forms.CheckBox TtDcheckBox;
	private System.Windows.Forms.CheckBox D1checkBox;
	private System.Windows.Forms.CheckBox D2checkBox;
	private System.Windows.Forms.CheckBox D3checkBox;
	private System.Windows.Forms.CheckBox D4checkBox;
	private System.Windows.Forms.CheckBox D5checkBox;
	private System.Windows.Forms.CheckBox DjcheckBox;
	private System.Windows.Forms.ListBox D4listBox1;
	private System.Windows.Forms.ListBox D4listBox2;
	private System.Windows.Forms.ListBox D5listBox1;
	private System.Windows.Forms.ListBox D5listBox2;
	private System.Windows.Forms.ListBox DjlistBox1;
	private System.Windows.Forms.ListBox DjlistBox2;
	private System.Windows.Forms.TextBox textBox5;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.TextBox txtDate1;
	private System.Windows.Forms.Button AutoButton;
    private Button manualScanbtn;
	int recordNumber=10;
    //public  System.Collections.Generic.List<object>  draws1;
	//object  ri61;
	//DataRow  drCurrent;

     





		public DialogBox1( ref int  ri5,ref DataSet dataSet,ref System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2,ref System.Data.OleDb.OleDbConnection oleDbConnection2 )

		{
			oleDbDataAdapter1=oleDbDataAdapter2;
			oleDbConnection1=oleDbConnection2;
			//
			// Required for Windows Form Designer support
			//
			//oleDbDataAdapter1.Fill(dataSet1,"joker1");
			//dataGrid1.SetDataBinding(dataSet1,"joker1");
 
			//TableDisplay  tableDisplay=new TableDisplay();
//oleDbDataAdapter1.Fill(dataSet1,"joker1");
			    InitializeComponent();
			  //ri5=ri5+ri5;
			ri6=ri5;
			dataset1=dataSet;
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
            this.components = new System.ComponentModel.Container();
            this.OKbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.Label();
            this.JokerNumber = new System.Windows.Forms.TextBox();
            this.Joker5 = new System.Windows.Forms.TextBox();
            this.Joker3 = new System.Windows.Forms.TextBox();
            this.Joker2 = new System.Windows.Forms.TextBox();
            this.Joker1 = new System.Windows.Forms.TextBox();
            this.Joker4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PredictButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EolistBox = new System.Windows.Forms.ListBox();
            this.DjlistBox2 = new System.Windows.Forms.ListBox();
            this.DjlistBox1 = new System.Windows.Forms.ListBox();
            this.D5listBox2 = new System.Windows.Forms.ListBox();
            this.D5listBox1 = new System.Windows.Forms.ListBox();
            this.D4listBox2 = new System.Windows.Forms.ListBox();
            this.D4listBox1 = new System.Windows.Forms.ListBox();
            this.DjcheckBox = new System.Windows.Forms.CheckBox();
            this.D5checkBox = new System.Windows.Forms.CheckBox();
            this.D3checkBox = new System.Windows.Forms.CheckBox();
            this.D2checkBox = new System.Windows.Forms.CheckBox();
            this.D1checkBox = new System.Windows.Forms.CheckBox();
            this.EocheckBox = new System.Windows.Forms.CheckBox();
            this.D3listBox2 = new System.Windows.Forms.ListBox();
            this.D3listBox1 = new System.Windows.Forms.ListBox();
            this.D2listBox2 = new System.Windows.Forms.ListBox();
            this.D2listBox1 = new System.Windows.Forms.ListBox();
            this.D1listBox2 = new System.Windows.Forms.ListBox();
            this.D1listBox1 = new System.Windows.Forms.ListBox();
            this.TtDlistBox = new System.Windows.Forms.ListBox();
            this.TtDcheckBox = new System.Windows.Forms.CheckBox();
            this.D4checkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.manualScanbtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(0, 416);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(128, 76);
            this.OKbutton.TabIndex = 0;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(840, 416);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(168, 76);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TrainButton.Location = new System.Drawing.Point(128, 416);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(136, 76);
            this.TrainButton.TabIndex = 7;
            this.TrainButton.Text = "MANUAL   TRAIN";
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lime;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDate1);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.lblIndex);
            this.groupBox3.Controls.Add(this.txtIndex);
            this.groupBox3.Controls.Add(this.hScrollBar1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Number1);
            this.groupBox3.Controls.Add(this.JokerNumber);
            this.groupBox3.Controls.Add(this.Joker5);
            this.groupBox3.Controls.Add(this.Joker3);
            this.groupBox3.Controls.Add(this.Joker2);
            this.groupBox3.Controls.Add(this.Joker1);
            this.groupBox3.Controls.Add(this.Joker4);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(656, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 408);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search  Results/Current Draw";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 35);
            this.label1.TabIndex = 35;
            this.label1.Text = "Current Date";
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(60, 326);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(160, 20);
            this.txtDate1.TabIndex = 34;
            this.txtDate1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(184, 208);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(43, 20);
            this.textBox10.TabIndex = 33;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(184, 176);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(43, 20);
            this.textBox9.TabIndex = 32;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(184, 144);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(43, 20);
            this.textBox8.TabIndex = 31;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(184, 104);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 20);
            this.textBox7.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(184, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 20);
            this.textBox6.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "PREVIOUS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "NEXT";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(56, 280);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(160, 20);
            this.txtDate.TabIndex = 26;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(16, 280);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 32);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date  Search";
            // 
            // lblIndex
            // 
            this.lblIndex.Location = new System.Drawing.Point(208, 248);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(83, 20);
            this.lblIndex.TabIndex = 24;
            this.lblIndex.Text = "Index";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(304, 248);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(60, 20);
            this.txtIndex.TabIndex = 23;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(16, 248);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(176, 17);
            this.hScrollBar1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(92, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "JokerNumber";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(92, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Number5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(92, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Number4";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Number3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(92, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number2";
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(92, 21);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(83, 20);
            this.Number1.TabIndex = 16;
            this.Number1.Text = "Number1";
            // 
            // JokerNumber
            // 
            this.JokerNumber.Location = new System.Drawing.Point(18, 216);
            this.JokerNumber.Name = "JokerNumber";
            this.JokerNumber.Size = new System.Drawing.Size(54, 20);
            this.JokerNumber.TabIndex = 15;
            // 
            // Joker5
            // 
            this.Joker5.Location = new System.Drawing.Point(16, 176);
            this.Joker5.Name = "Joker5";
            this.Joker5.Size = new System.Drawing.Size(56, 20);
            this.Joker5.TabIndex = 14;
            // 
            // Joker3
            // 
            this.Joker3.Location = new System.Drawing.Point(18, 99);
            this.Joker3.Name = "Joker3";
            this.Joker3.Size = new System.Drawing.Size(54, 20);
            this.Joker3.TabIndex = 12;
            // 
            // Joker2
            // 
            this.Joker2.Location = new System.Drawing.Point(18, 60);
            this.Joker2.Name = "Joker2";
            this.Joker2.Size = new System.Drawing.Size(54, 20);
            this.Joker2.TabIndex = 11;
            // 
            // Joker1
            // 
            this.Joker1.Location = new System.Drawing.Point(18, 21);
            this.Joker1.Name = "Joker1";
            this.Joker1.Size = new System.Drawing.Size(54, 20);
            this.Joker1.TabIndex = 10;
            // 
            // Joker4
            // 
            this.Joker4.Location = new System.Drawing.Point(16, 132);
            this.Joker4.Name = "Joker4";
            this.Joker4.Size = new System.Drawing.Size(56, 20);
            this.Joker4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 94);
            this.button4.TabIndex = 20;
            this.button4.Text = "FIND PERFECT MATCH";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PredictButton
            // 
            this.PredictButton.BackColor = System.Drawing.Color.LightCoral;
            this.PredictButton.ForeColor = System.Drawing.Color.Black;
            this.PredictButton.Location = new System.Drawing.Point(400, 409);
            this.PredictButton.Name = "PredictButton";
            this.PredictButton.Size = new System.Drawing.Size(133, 83);
            this.PredictButton.TabIndex = 10;
            this.PredictButton.Text = "PREDICT";
            this.PredictButton.UseVisualStyleBackColor = false;
            this.PredictButton.Click += new System.EventHandler(this.PredictButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.EolistBox);
            this.groupBox1.Controls.Add(this.DjlistBox2);
            this.groupBox1.Controls.Add(this.DjlistBox1);
            this.groupBox1.Controls.Add(this.D5listBox2);
            this.groupBox1.Controls.Add(this.D5listBox1);
            this.groupBox1.Controls.Add(this.D4listBox2);
            this.groupBox1.Controls.Add(this.D4listBox1);
            this.groupBox1.Controls.Add(this.DjcheckBox);
            this.groupBox1.Controls.Add(this.D5checkBox);
            this.groupBox1.Controls.Add(this.D3checkBox);
            this.groupBox1.Controls.Add(this.D2checkBox);
            this.groupBox1.Controls.Add(this.D1checkBox);
            this.groupBox1.Controls.Add(this.EocheckBox);
            this.groupBox1.Controls.Add(this.D3listBox2);
            this.groupBox1.Controls.Add(this.D3listBox1);
            this.groupBox1.Controls.Add(this.D2listBox2);
            this.groupBox1.Controls.Add(this.D2listBox1);
            this.groupBox1.Controls.Add(this.D1listBox2);
            this.groupBox1.Controls.Add(this.D1listBox1);
            this.groupBox1.Controls.Add(this.TtDlistBox);
            this.groupBox1.Controls.Add(this.TtDcheckBox);
            this.groupBox1.Controls.Add(this.D4checkBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 416);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train Parameters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // EolistBox
            // 
            this.EolistBox.Items.AddRange(new object[] {
            "0/5",
            "1/4",
            "2/3",
            "3/2",
            "4/1",
            "5/0",
            "don\'t  care"});
            this.EolistBox.Location = new System.Drawing.Point(376, 24);
            this.EolistBox.Name = "EolistBox";
            this.EolistBox.Size = new System.Drawing.Size(104, 4);
            this.EolistBox.TabIndex = 25;
            // 
            // DjlistBox2
            // 
            this.DjlistBox2.HorizontalScrollbar = true;
            this.DjlistBox2.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "dont care"});
            this.DjlistBox2.Location = new System.Drawing.Point(253, 354);
            this.DjlistBox2.Name = "DjlistBox2";
            this.DjlistBox2.Size = new System.Drawing.Size(64, 4);
            this.DjlistBox2.TabIndex = 45;
            this.DjlistBox2.SelectedIndexChanged += new System.EventHandler(this.DjlistBox2_SelectedIndexChanged);
            // 
            // DjlistBox1
            // 
            this.DjlistBox1.AllowDrop = true;
            this.DjlistBox1.HorizontalScrollbar = true;
            this.DjlistBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "dont care"});
            this.DjlistBox1.Location = new System.Drawing.Point(147, 354);
            this.DjlistBox1.Name = "DjlistBox1";
            this.DjlistBox1.ScrollAlwaysVisible = true;
            this.DjlistBox1.Size = new System.Drawing.Size(64, 4);
            this.DjlistBox1.TabIndex = 44;
            this.DjlistBox1.SelectedIndexChanged += new System.EventHandler(this.DjlistBox1_SelectedIndexChanged);
            // 
            // D5listBox2
            // 
            this.D5listBox2.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "dont  care"});
            this.D5listBox2.Location = new System.Drawing.Point(247, 298);
            this.D5listBox2.Name = "D5listBox2";
            this.D5listBox2.Size = new System.Drawing.Size(63, 4);
            this.D5listBox2.TabIndex = 43;
            // 
            // D5listBox1
            // 
            this.D5listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "dont  dare"});
            this.D5listBox1.Location = new System.Drawing.Point(147, 298);
            this.D5listBox1.Name = "D5listBox1";
            this.D5listBox1.Size = new System.Drawing.Size(64, 4);
            this.D5listBox1.TabIndex = 42;
            // 
            // D4listBox2
            // 
            this.D4listBox2.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "dont  care"});
            this.D4listBox2.Location = new System.Drawing.Point(240, 243);
            this.D4listBox2.Name = "D4listBox2";
            this.D4listBox2.Size = new System.Drawing.Size(64, 4);
            this.D4listBox2.TabIndex = 41;
            // 
            // D4listBox1
            // 
            this.D4listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "dont  care"});
            this.D4listBox1.Location = new System.Drawing.Point(147, 243);
            this.D4listBox1.Name = "D4listBox1";
            this.D4listBox1.Size = new System.Drawing.Size(64, 4);
            this.D4listBox1.TabIndex = 40;
            this.D4listBox1.SelectedIndexChanged += new System.EventHandler(this.D4listBox1_SelectedIndexChanged);
            // 
            // DjcheckBox
            // 
            this.DjcheckBox.Location = new System.Drawing.Point(13, 347);
            this.DjcheckBox.Name = "DjcheckBox";
            this.DjcheckBox.Size = new System.Drawing.Size(104, 24);
            this.DjcheckBox.TabIndex = 39;
            this.DjcheckBox.Text = "Distance  Joker";
            // 
            // D5checkBox
            // 
            this.D5checkBox.Location = new System.Drawing.Point(13, 291);
            this.D5checkBox.Name = "D5checkBox";
            this.D5checkBox.Size = new System.Drawing.Size(120, 24);
            this.D5checkBox.TabIndex = 38;
            this.D5checkBox.Text = "Distance Number5";
            // 
            // D3checkBox
            // 
            this.D3checkBox.Location = new System.Drawing.Point(16, 194);
            this.D3checkBox.Name = "D3checkBox";
            this.D3checkBox.Size = new System.Drawing.Size(120, 24);
            this.D3checkBox.TabIndex = 37;
            this.D3checkBox.Text = "Distance  Number3";
            // 
            // D2checkBox
            // 
            this.D2checkBox.Location = new System.Drawing.Point(16, 146);
            this.D2checkBox.Name = "D2checkBox";
            this.D2checkBox.Size = new System.Drawing.Size(120, 23);
            this.D2checkBox.TabIndex = 36;
            this.D2checkBox.Text = "Distance Number2";
            // 
            // D1checkBox
            // 
            this.D1checkBox.Location = new System.Drawing.Point(13, 104);
            this.D1checkBox.Name = "D1checkBox";
            this.D1checkBox.Size = new System.Drawing.Size(120, 24);
            this.D1checkBox.TabIndex = 35;
            this.D1checkBox.Text = "Distance Number1";
            this.D1checkBox.CheckedChanged += new System.EventHandler(this.D1checkBox_CheckedChanged);
            // 
            // EocheckBox
            // 
            this.EocheckBox.Location = new System.Drawing.Point(280, 24);
            this.EocheckBox.Name = "EocheckBox";
            this.EocheckBox.Size = new System.Drawing.Size(96, 24);
            this.EocheckBox.TabIndex = 30;
            this.EocheckBox.Text = "Even/Odds";
            // 
            // D3listBox2
            // 
            this.D3listBox2.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "dont  care"});
            this.D3listBox2.Location = new System.Drawing.Point(240, 187);
            this.D3listBox2.Name = "D3listBox2";
            this.D3listBox2.Size = new System.Drawing.Size(64, 4);
            this.D3listBox2.TabIndex = 29;
            this.D3listBox2.SelectedIndexChanged += new System.EventHandler(this.D3listBox2_SelectedIndexChanged);
            // 
            // D3listBox1
            // 
            this.D3listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "dont  care"});
            this.D3listBox1.Location = new System.Drawing.Point(147, 187);
            this.D3listBox1.Name = "D3listBox1";
            this.D3listBox1.Size = new System.Drawing.Size(63, 4);
            this.D3listBox1.TabIndex = 28;
            // 
            // D2listBox2
            // 
            this.D2listBox2.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "dont  care"});
            this.D2listBox2.Location = new System.Drawing.Point(240, 136);
            this.D2listBox2.Name = "D2listBox2";
            this.D2listBox2.Size = new System.Drawing.Size(64, 4);
            this.D2listBox2.TabIndex = 27;
            // 
            // D2listBox1
            // 
            this.D2listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "dont  care"});
            this.D2listBox1.Location = new System.Drawing.Point(147, 136);
            this.D2listBox1.Name = "D2listBox1";
            this.D2listBox1.Size = new System.Drawing.Size(64, 4);
            this.D2listBox1.TabIndex = 26;
            this.D2listBox1.SelectedIndexChanged += new System.EventHandler(this.D2listBox1_SelectedIndexChanged);
            // 
            // D1listBox2
            // 
            this.D1listBox2.Items.AddRange(new object[] {
            "0",
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "dont  care"});
            this.D1listBox2.Location = new System.Drawing.Point(240, 96);
            this.D1listBox2.Name = "D1listBox2";
            this.D1listBox2.Size = new System.Drawing.Size(64, 4);
            this.D1listBox2.TabIndex = 23;
            this.D1listBox2.SelectedIndexChanged += new System.EventHandler(this.D1listBox2_SelectedIndexChanged);
            // 
            // D1listBox1
            // 
            this.D1listBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "dont  care"});
            this.D1listBox1.Location = new System.Drawing.Point(147, 96);
            this.D1listBox1.Name = "D1listBox1";
            this.D1listBox1.Size = new System.Drawing.Size(64, 4);
            this.D1listBox1.TabIndex = 22;
            this.D1listBox1.SelectedIndexChanged += new System.EventHandler(this.D1listBox1_SelectedIndexChanged);
            // 
            // TtDlistBox
            // 
            this.TtDlistBox.ColumnWidth = 12;
            this.TtDlistBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TtDlistBox.Items.AddRange(new object[] {
            "0",
            "1",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "don\'t care"});
            this.TtDlistBox.Location = new System.Drawing.Point(153, 48);
            this.TtDlistBox.Name = "TtDlistBox";
            this.TtDlistBox.ScrollAlwaysVisible = true;
            this.TtDlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TtDlistBox.Size = new System.Drawing.Size(64, 4);
            this.TtDlistBox.Sorted = true;
            this.TtDlistBox.TabIndex = 15;
            this.TtDlistBox.SelectedIndexChanged += new System.EventHandler(this.TtDlistBox_SelectedIndexChanged);
            // 
            // TtDcheckBox
            // 
            this.TtDcheckBox.Location = new System.Drawing.Point(13, 55);
            this.TtDcheckBox.Name = "TtDcheckBox";
            this.TtDcheckBox.Size = new System.Drawing.Size(129, 25);
            this.TtDcheckBox.TabIndex = 34;
            this.TtDcheckBox.Text = "Train Total  Distance";
            this.TtDcheckBox.CheckedChanged += new System.EventHandler(this.TtDcheckBox_CheckedChanged);
            // 
            // D4checkBox
            // 
            this.D4checkBox.Location = new System.Drawing.Point(13, 243);
            this.D4checkBox.Name = "D4checkBox";
            this.D4checkBox.Size = new System.Drawing.Size(120, 23);
            this.D4checkBox.TabIndex = 17;
            this.D4checkBox.Text = "Distance Number4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 76);
            this.button1.TabIndex = 16;
            this.button1.Text = "FINAL PREDICTION";
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(267, 416);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(133, 69);
            this.AutoButton.TabIndex = 17;
            this.AutoButton.Text = "AUTO  TRAIN";
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // manualScanbtn
            // 
            this.manualScanbtn.BackColor = System.Drawing.Color.Cyan;
            this.manualScanbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualScanbtn.Location = new System.Drawing.Point(666, 420);
            this.manualScanbtn.Name = "manualScanbtn";
            this.manualScanbtn.Size = new System.Drawing.Size(179, 69);
            this.manualScanbtn.TabIndex = 18;
            this.manualScanbtn.Text = "MANUAL_SCAN";
            this.manualScanbtn.UseVisualStyleBackColor = false;
            // 
            // DialogBox1
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1027, 486);
            this.ControlBox = false;
            this.Controls.Add(this.manualScanbtn);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PredictButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKbutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBox1";
            this.Text = "DialogBox";
            this.Load += new System.EventHandler(this.DialogBox1_Load_1);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		 

		private void DialogBox1_Load_1(object sender, System.EventArgs e)
		{
		
		
		}

		 

		 

		private void OKbutton_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox2_Enter(object sender, System.EventArgs e)
		{
		
		}

		 

		 

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void PredictButton_Click(object sender, System.EventArgs e)
		{
		
		}

		 

		 

		private void TrainButton_Click(object sender, System.EventArgs e)
		{
		
		}

		private void CancelButton_Click(object sender, System.EventArgs e)
		{
		
		}

		public void CancelButton_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void TrainButton_Click_1(object sender, System.EventArgs e)
		{
			  
			try
			{
				 
		
				//TableDisplay  tableDisplay=new TableDisplay();
				 DataTable    dataTable =this.dataset1.Tables["joker1"];
				
				//dataset1.d=dataview;
 

				if(MessageBox.Show ("START  OF  TRAINING","CONFIRM  TRAIN  START-UP",MessageBoxButtons.OKCancel)==DialogResult.OK)
				{
					int  ri11=dataTable.Rows.Count-150;
					//for(ri10=0;ri10<dataTable.Rows.Count;ri10++)
					for (ri10=ri11;ri10<dataTable.Rows.Count;ri10++)
					{
						







				 
						for(ri6=0;ri6<ri10;ri6++)

							//foreach(DataRow row in dataTable.Rows[ri6])
						{
                           


if((int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][7]  )
ri11++;

							
							if((int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][7]  )
								ri11++;
						
							
							if((int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][7]  )
								ri11++;	


							
							if((int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][7]  )
								ri11++;

							
							if((int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][7]  )
								ri11++;



if(ri11>3)// check  for fours


{
	ri11=0;	//zero  counter	
	
	
	
	recordNumber = (int ) dataTable.Rows[ri10][3];
	//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
	//string output=this.jokern[ri11,(recordNumber+100)].ToString();
	//MessageBox.Show(output);
						
						
	textBox5.Text=recordNumber.ToString();

	recordNumber = (int ) dataTable.Rows[ri10][4];
	//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
	//string output=this.jokern[ri11,(recordNumber+100)].ToString();
	//MessageBox.Show(output);
						
						
	textBox6.Text=recordNumber.ToString();

	recordNumber = (int ) dataTable.Rows[ri10][5];
	//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
	//string output=this.jokern[ri11,(recordNumber+100)].ToString();
	//MessageBox.Show(output);
						
						
	textBox7.Text=recordNumber.ToString();

	recordNumber = (int ) dataTable.Rows[ri10][6];
	//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
	//string output=this.jokern[ri11,(recordNumber+100)].ToString();
	//MessageBox.Show(output);
						
						
	textBox8.Text=recordNumber.ToString();

	recordNumber = (int ) dataTable.Rows[ri10][7];
	//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
	//string output=this.jokern[ri11,(recordNumber+100)].ToString();
	//MessageBox.Show(output);
						
						
	textBox9.Text=recordNumber.ToString();

	
	
	
	
	
	
	
	
	
	
	
	
	// drCurrent=dataTable.Rows.Find(ri6+1);

								// drCurrent.BeginEdit();
								//MessageBox.Show("drCurrent:"+drCurrent.ToString());
								recordNumber = (int ) dataTable.Rows[ri6][1];
								txtIndex.Text=recordNumber.ToString();
								//recordNumber=(int)	drCurrent.Table.Rows[ri6][1];
						
								recordNumber = (int ) dataTable.Rows[ri6][3];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								string output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								Joker1.Text=recordNumber.ToString();

						
						
								recordNumber = (int ) dataTable.Rows[ri6][4];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);

						
						
								Joker2.Text=recordNumber.ToString();

						
						
						
								recordNumber = (int ) dataTable.Rows[ri6][5];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);

						
						
								Joker3.Text=recordNumber.ToString();

						
						
								recordNumber = (int ) dataTable.Rows[ri6][6];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);

						
						
								Joker4.Text=recordNumber.ToString();

						
						
								recordNumber = (int ) dataTable.Rows[ri6][7];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								// MessageBox.Show(output);



						
						
								Joker5.Text=recordNumber.ToString();

								recordNumber = (int ) dataTable.Rows[ri6][2];
								this.jokern[ri6,(recordNumber+200)]++;

								JokerNumber.Text=recordNumber.ToString();

								string dateString = (string)dataTable.Rows[ri6][0].ToString();
								txtDate.Text=dateString;
						
								ri7=ri6;
								ri7++;
								for (int ri8=1;ri8<46;ri8++)
								{
									this.jokern1[ri6,(ri8+100)]=this.jokern[ri6,(ri8+100)];
                            
								}
								for (int ri8=1;ri8<21;ri8++)
								{
							 
									this.jokern1[ri6,(ri8+200)]=this.jokern[ri6,(ri8+200)];
								}

MessageBox.Show("SEARCH  COMPLETED SUCCESFULLY");

							}
							ri11=0;//zero counter to recheck
						}
					}



						//string target1="";
						//string target2="";
						//string target3="";
						//conversion of string in format  yyyy/mm/dd
						//ready for sorting
					//Application.DoEvents();

//DataRow  TargetRow=(System.Data.DataRow)dataTable.Rows;
//TargetRow.BeginEdit();
 /*
						string output="";
						output+=dateString.Substring(dateString.LastIndexOf('/')+1,4);
						int i10=dateString.LastIndexOf('/');
						int i11=dateString.LastIndexOf('/',i10-1);
					
						
					if(i10-i11==2)
					{
						//dateString[i11+1]="0";
						// dateString.Insert((i11+1),"0");
						//i10=i10+1;
//MessageBox.Show ("SELECTION REPORT2:");
//i11=dateString.LastIndexOf('/',i10-1);
						output+="/";
						output+="0";
						output+=dateString.Substring(dateString.LastIndexOf('/',i10-1)+1,2);
					 //output+="/";
                    
					}
					else
					{
						output+=dateString.Substring(dateString.LastIndexOf('/',i10-1),i10-i11+1);
					}
//dateString.Insert(0,"0");
//int i12=dateString.IndexOf('/',i11-1);
					if(i11==1)
output+="0";
						output+=dateString.Substring(0,dateString.IndexOf('/'));


						txtDate.Text=output.ToString();
//oleDbDataAdapter1.UpdateCommand.CommandText=  "";//"UPDATE joker1  SET" + "date='"+txtDate.Text;
		   
							dataTable.Rows[ri6]["date"]=output.ToString();
						 // drCurrent.EndEdit();

							 
   System.Data.OleDb.OleDbCommandBuilder   cmdBuilder=new System.Data.OleDb.OleDbCommandBuilder(oleDbDataAdapter1);
  //oleDbDataAdapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
   //string  oleUsersUpdate = string.Format ("UPDATE joker1 SET date = txtDate.Text WHERE id = ri6  ");
 

//oleDbDataAdapter1.DeleteCommand=cmdBuilder.GetDeleteCommand();
							 
						       // oleDbDataAdapter1.UpdateCommand=new System.Data.OleDb.OleDbCommand();
			 //oleDbDataAdapter1.UpdateCommand.CommandText=  "UPDATE [joker1] SET [date] =  txtDate.Text WHERE [id]=(ri6+1)";
			 	//oleDbDataAdapter1.UpdateCommand.Connection=oleDbConnection1;
				 
							 //oleDbDataAdapter1.UpdateCommand.CommandText = oleUsersUpdate;

						  // oleDbDataAdapter1.InsertCommand=cmdBuilder.GetInsertCommand();
						    if(dataset1.HasChanges()==true)
						   {
							   //dataset1.GetChanges();
							  // MessageBox.Show("HasChanges=true");
					 
							   // oleDbDataAdapter1.UpdateCommand.CommandText="UPDATE joker1 SET jokernumber=40 ";

							      oleDbDataAdapter1.Update(dataset1,"joker1");
							     // oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
							   dataset1.AcceptChanges();
						   }  


*/
						   //oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();

						   //this.oleDbDataAdapter1.Update(this.dataset1,"joker1");
						   //oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
						   //dataset1.AcceptChanges();


					//TargetRow.EndEdit();
				 
				//DataSet  DataSetChanges=dataset1.GetChanges(DataRowState.Modified);

				//dataset1.Merge(DataSetChanges);
 
					//PopulateLB();
					//DataTable    dataTable =dataSet1.Tables[0];
					//ri4=50;
					//if (dataTable.Rows.Count !=  0)
					if(ri6!=0)
					{
						//string  output="";
					//	output="this is ari4 value:{0}",tableDisplay.ri4;
	//this.Joker1.Text=Convert.ToString(tableDisplay.ri4);
					//DialogBox1.Console.WriteLine("variable ri4={0}",tableDisplay.ri4);
						//MessageBox.Show ("SELECTION REPORT","YOU HAVE SELECTED : "+ Text ,MessageBoxButtons.OKCancel);
					//string x = ((Form1)this.ParentForm).Text

				//this.Joker1.Text=Convert.ToString(ri6);
					} 
                   
				//this.Joker1.Text=((TableDisplay)this.ParentForm).txtUserSelect.Text;
				  }
			}
			catch(System.Data.OleDb.OleDbException oleException)
			{
MessageBox.Show ("SELECTION TRAIN  ERROR"+oleException.ToString(),"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
MessageBox.Show("UPDATE  COMPLETED SUCCESFULLY");

		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
		
		}

	private void predictionText_TextChanged(object sender, System.EventArgs e)
	{
	
	}

	private void txtDate_TextChanged(object sender, System.EventArgs e)
	{
	
	}

	private void textBox1_TextChanged(object sender, System.EventArgs e)
	{
	
	}

	private void label1_Click(object sender, System.EventArgs e)
	{
	
	}

	private void groupBox1_Enter_1(object sender, System.EventArgs e)
	{
	
	}

	private void TtDcheckBox_CheckedChanged(object sender, System.EventArgs e)
	{
		if(this.TtDlistBox.Enabled==false)
			this.TtDlistBox.Enabled=true;
		else
this.TtDlistBox.Enabled=false;
		//this.txtUserSelect.Enabled=false;



	
	}

	private void D1checkBox_CheckedChanged(object sender, System.EventArgs e)
	{
	
	}

	private void DjlistBox2_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void D1listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void TtDlistBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void D4listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void DjlistBox1_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void D1listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void textBox10_TextChanged(object sender, System.EventArgs e)
	{
	
	}

	private void button4_Click(object sender, System.EventArgs e)
	{

		try
		{
				 
		
			//TableDisplay  tableDisplay=new TableDisplay();
			DataTable    dataTable =this.dataset1.Tables["joker1"];
				
			//dataset1.d=dataview;
 

			if(MessageBox.Show ("START  OF  FOUR  PERFECT MATCH","CONFIRM  FOUR PERFECT MATCH  START-UP",MessageBoxButtons.OKCancel)==DialogResult.OK)
			{
				int  ri11=dataTable.Rows.Count-100;
				//for(ri10=0;ri10<dataTable.Rows.Count;ri10++)
				for (ri10=0;ri10<dataTable.Rows.Count;ri10++)
				{
						
					//combinations  1,2,3,4/2,3,4,5/1,3,4,5/1,2,3,5/1,2,4,5





				 
					for(r15=0;r15<5;r15++)

						//foreach(DataRow row in dataTable.Rows[ri6])
					{
						for(ri6=ri10+1;ri6<dataTable.Rows.Count;ri6++)
						{
						      
							switch(r15)
							{
								
								case  0:
									//if((int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][7]  )
									//ri11++;

								 
									if((int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
						
							
									if((int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][7]  )
										ri11++;	


							
									if((int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									if((int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
									break;


								case 1:
								 
									if((int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									//if((int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][7]  )
									//ri11++;
						
							
									if((int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][7]  )
										ri11++;	


							
									if((int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									if((int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
									break;


								case 2:
								 
									if((int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									if((int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
						
							
									//if((int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][7]  )
									//ri11++;	


							
									if((int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									if((int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
									break;


								case  3:
								 
									if((int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									if((int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
						
							
									if((int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][7]  )
										ri11++;	


							
									//if((int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][7]  )
									//ri11++;

							
									if((int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
									break;
								case  4:
								 
									if((int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][3]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									if((int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][4]==(int)dataTable.Rows[ri6][7]  )
										ri11++;
						
							
									if((int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][5]==(int)dataTable.Rows[ri6][7]  )
										ri11++;	


							
									if((int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][6]==(int)dataTable.Rows[ri6][7]  )
										ri11++;

							
									//if((int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][3]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][4]||( int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][5]||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][6] ||(int)dataTable.Rows[ri10][7]==(int)dataTable.Rows[ri6][7]  )
									//ri11++;
									break;

								default:
									break;
							}


							if(ri11>3)


							{

								//zero  ri11
								ri11=0;		
	
	
	
								recordNumber = (int ) dataTable.Rows[ri10][3];
								//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								//string output=this.jokern[ri11,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								textBox5.Text=recordNumber.ToString();

								recordNumber = (int ) dataTable.Rows[ri10][4];
								//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								//string output=this.jokern[ri11,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								textBox6.Text=recordNumber.ToString();

								recordNumber = (int ) dataTable.Rows[ri10][5];
								//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								//string output=this.jokern[ri11,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								textBox7.Text=recordNumber.ToString();

								recordNumber = (int ) dataTable.Rows[ri10][6];
								//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								//string output=this.jokern[ri11,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								textBox8.Text=recordNumber.ToString();

								recordNumber = (int ) dataTable.Rows[ri10][7];
								//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								//string output=this.jokern[ri11,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								textBox9.Text=recordNumber.ToString();

								string dateString = (string)dataTable.Rows[ri10][0].ToString();
								txtDate1.Text=dateString;

	
	
	
	
	
	
	
	
	
	
	
	
								// drCurrent=dataTable.Rows.Find(ri6+1);

								// drCurrent.BeginEdit();
								//MessageBox.Show("drCurrent:"+drCurrent.ToString());
								recordNumber = (int ) dataTable.Rows[ri6][1];
								txtIndex.Text=recordNumber.ToString();
								//recordNumber=(int)	drCurrent.Table.Rows[ri6][1];
						
								recordNumber = (int ) dataTable.Rows[ri6][3];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								string output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);
						
						
								Joker1.Text=recordNumber.ToString();

						
						
								recordNumber = (int ) dataTable.Rows[ri6][4];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);

						
						
								Joker2.Text=recordNumber.ToString();

						
						
						
								recordNumber = (int ) dataTable.Rows[ri6][5];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);

						
						
								Joker3.Text=recordNumber.ToString();

						
						
								recordNumber = (int ) dataTable.Rows[ri6][6];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								//MessageBox.Show(output);

						
						
								Joker4.Text=recordNumber.ToString();

						
						
								recordNumber = (int ) dataTable.Rows[ri6][7];
								this.jokern[ri6,(recordNumber+100)]++;
						 
                        
								output=this.jokern[ri6,(recordNumber+100)].ToString();
								// MessageBox.Show(output);



						
						
								Joker5.Text=recordNumber.ToString();

								recordNumber = (int ) dataTable.Rows[ri6][2];
								this.jokern[ri6,(recordNumber+200)]++;

								JokerNumber.Text=recordNumber.ToString();

								string dateString1 = (string)dataTable.Rows[ri6][0].ToString();
								txtDate.Text=dateString1;
						
								ri7=ri6;
								ri7++;
								for (int ri8=1;ri8<46;ri8++)
								{
									this.jokern1[ri6,(ri8+100)]=this.jokern[ri6,(ri8+100)];
                            
								}
								for (int ri8=1;ri8<21;ri8++)
								{
							 
									this.jokern1[ri6,(ri8+200)]=this.jokern[ri6,(ri8+200)];
								}

								MessageBox.Show("SEARCH  COMPLETED SUCCESFULLY");

							}

							//zero ri11  even if smaller than 3
							ri11=0;
						
						}
						
						
					}
//zero r15 
r15=0;
				}



				//string target1="";
				//string target2="";
				//string target3="";
				//conversion of string in format  yyyy/mm/dd
				//ready for sorting
				//Application.DoEvents();

				//DataRow  TargetRow=(System.Data.DataRow)dataTable.Rows;
				//TargetRow.BeginEdit();
				/*
									   string output="";
									   output+=dateString.Substring(dateString.LastIndexOf('/')+1,4);
									   int i10=dateString.LastIndexOf('/');
									   int i11=dateString.LastIndexOf('/',i10-1);
					
						
								   if(i10-i11==2)
								   {
									   //dateString[i11+1]="0";
									   // dateString.Insert((i11+1),"0");
									   //i10=i10+1;
			   //MessageBox.Show ("SELECTION REPORT2:");
			   //i11=dateString.LastIndexOf('/',i10-1);
									   output+="/";
									   output+="0";
									   output+=dateString.Substring(dateString.LastIndexOf('/',i10-1)+1,2);
									//output+="/";
                    
								   }
								   else
								   {
									   output+=dateString.Substring(dateString.LastIndexOf('/',i10-1),i10-i11+1);
								   }
			   //dateString.Insert(0,"0");
			   //int i12=dateString.IndexOf('/',i11-1);
								   if(i11==1)
			   output+="0";
									   output+=dateString.Substring(0,dateString.IndexOf('/'));


									   txtDate.Text=output.ToString();
			   //oleDbDataAdapter1.UpdateCommand.CommandText=  "";//"UPDATE joker1  SET" + "date='"+txtDate.Text;
		   
										   dataTable.Rows[ri6]["date"]=output.ToString();
										// drCurrent.EndEdit();

							 
				  System.Data.OleDb.OleDbCommandBuilder   cmdBuilder=new System.Data.OleDb.OleDbCommandBuilder(oleDbDataAdapter1);
				 //oleDbDataAdapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				  //string  oleUsersUpdate = string.Format ("UPDATE joker1 SET date = txtDate.Text WHERE id = ri6  ");
 

			   //oleDbDataAdapter1.DeleteCommand=cmdBuilder.GetDeleteCommand();
							 
											  // oleDbDataAdapter1.UpdateCommand=new System.Data.OleDb.OleDbCommand();
							//oleDbDataAdapter1.UpdateCommand.CommandText=  "UPDATE [joker1] SET [date] =  txtDate.Text WHERE [id]=(ri6+1)";
							   //oleDbDataAdapter1.UpdateCommand.Connection=oleDbConnection1;
				 
											//oleDbDataAdapter1.UpdateCommand.CommandText = oleUsersUpdate;

										 // oleDbDataAdapter1.InsertCommand=cmdBuilder.GetInsertCommand();
										   if(dataset1.HasChanges()==true)
										  {
											  //dataset1.GetChanges();
											 // MessageBox.Show("HasChanges=true");
					 
											  // oleDbDataAdapter1.UpdateCommand.CommandText="UPDATE joker1 SET jokernumber=40 ";

												 oleDbDataAdapter1.Update(dataset1,"joker1");
												// oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
											  dataset1.AcceptChanges();
										  }  


			   */
				//oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();

				//this.oleDbDataAdapter1.Update(this.dataset1,"joker1");
				//oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
				//dataset1.AcceptChanges();


				//TargetRow.EndEdit();
				 
				//DataSet  DataSetChanges=dataset1.GetChanges(DataRowState.Modified);

				//dataset1.Merge(DataSetChanges);
 
				//PopulateLB();
				//DataTable    dataTable =dataSet1.Tables[0];
				//ri4=50;
				//if (dataTable.Rows.Count !=  0)
				if(ri6!=0)
				{
					//string  output="";
					//	output="this is ari4 value:{0}",tableDisplay.ri4;
					//this.Joker1.Text=Convert.ToString(tableDisplay.ri4);
					//DialogBox1.Console.WriteLine("variable ri4={0}",tableDisplay.ri4);
					//MessageBox.Show ("SELECTION REPORT","YOU HAVE SELECTED : "+ Text ,MessageBoxButtons.OKCancel);
					//string x = ((Form1)this.ParentForm).Text

					//this.Joker1.Text=Convert.ToString(ri6);
				} 
                   
				//this.Joker1.Text=((TableDisplay)this.ParentForm).txtUserSelect.Text;
			}
		}
		catch(System.Data.OleDb.OleDbException oleException)
		{
			MessageBox.Show ("SELECTION TRAIN  ERROR"+oleException.ToString(),"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		MessageBox.Show("UPDATE  COMPLETED SUCCESFULLY");


	
	}

	private void textBox1_TextChanged_1(object sender, System.EventArgs e)
	{
	
	}

	private void D2listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

	private void AutoButton_Click(object sender, System.EventArgs e)
	{
	
		 
				 
		
		//TableDisplay  tableDisplay=new TableDisplay();
		DataTable    dataTable =this.dataset1.Tables["joker1"];
				
		//dataset1.d=dataview;
 
int  sum=0;
		if(MessageBox.Show ("START  OF  AUTO  TRAINING","CONFIRM  AUTO  TRAIN  START-UP",MessageBoxButtons.OKCancel)==DialogResult.OK)
		{
			int  ri11=dataTable.Rows.Count-50;
			//for(ri10=0;ri10<dataTable.Rows.Count;ri10++)
			for (ri10=1;ri10<46;ri10++)
			{
						



sum=0;




				 
				for(ri6=0;ri6<ri11;ri6++)

					//foreach(DataRow row in dataTable.Rows[ri6])
				{
                           


					if(ri10==(int)dataTable.Rows[ri6][3]||ri10==(int)dataTable.Rows[ri6][4]||ri10==(int)dataTable.Rows[ri6][5]||ri10==(int)dataTable.Rows[ri6][6] || ri10==(int)dataTable.Rows[ri6][7])
					{
						jokern[ri6,100+ri10]++;
jokern[ri6,100+ri10]+=sum;

sum=jokern[ri6,100+ri10];


					}
							
						 
				}
							
						 
			}

							
						 
							
						 



						 


						 
	
	
			recordNumber = (int ) dataTable.Rows[ri10][3];
			//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			//string output=this.jokern[ri11,(recordNumber+100)].ToString();
			//MessageBox.Show(output);
						
						
			textBox5.Text=recordNumber.ToString();

			recordNumber = (int ) dataTable.Rows[ri10][4];
			//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			//string output=this.jokern[ri11,(recordNumber+100)].ToString();
			//MessageBox.Show(output);
						
						
			textBox6.Text=recordNumber.ToString();

			recordNumber = (int ) dataTable.Rows[ri10][5];
			//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			//string output=this.jokern[ri11,(recordNumber+100)].ToString();
			//MessageBox.Show(output);
						
						
			textBox7.Text=recordNumber.ToString();

			recordNumber = (int ) dataTable.Rows[ri10][6];
			//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			//string output=this.jokern[ri11,(recordNumber+100)].ToString();
			//MessageBox.Show(output);
						
						
			textBox8.Text=recordNumber.ToString();

			recordNumber = (int ) dataTable.Rows[ri10][7];
			//this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			//string output=this.jokern[ri11,(recordNumber+100)].ToString();
			//MessageBox.Show(output);
						
						
			textBox9.Text=recordNumber.ToString();

	
	
	
	
	
	
	
	
	
	
	
	
			// drCurrent=dataTable.Rows.Find(ri6+1);

			// drCurrent.BeginEdit();
			//MessageBox.Show("drCurrent:"+drCurrent.ToString());
			recordNumber = (int ) dataTable.Rows[ri6][1];
			txtIndex.Text=recordNumber.ToString();
			//recordNumber=(int)	drCurrent.Table.Rows[ri6][1];
						
			recordNumber = (int ) dataTable.Rows[ri6][3];
			this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			string output=this.jokern[ri6,(recordNumber+100)].ToString();
			//MessageBox.Show(output);
						
						
			Joker1.Text=recordNumber.ToString();

						
						
			recordNumber = (int ) dataTable.Rows[ri6][4];
			this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			output=this.jokern[ri6,(recordNumber+100)].ToString();
			//MessageBox.Show(output);

						
						
			Joker2.Text=recordNumber.ToString();

						
						
						
			recordNumber = (int ) dataTable.Rows[ri6][5];
			this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			output=this.jokern[ri6,(recordNumber+100)].ToString();
			//MessageBox.Show(output);

						
						
			Joker3.Text=recordNumber.ToString();

						
						
			recordNumber = (int ) dataTable.Rows[ri6][6];
			this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			output=this.jokern[ri6,(recordNumber+100)].ToString();
			//MessageBox.Show(output);

						
						
			Joker4.Text=recordNumber.ToString();

						
						
			recordNumber = (int ) dataTable.Rows[ri6][7];
			this.jokern[ri6,(recordNumber+100)]++;
						 
                        
			output=this.jokern[ri6,(recordNumber+100)].ToString();
			// MessageBox.Show(output);



						
						
			Joker5.Text=recordNumber.ToString();

			recordNumber = (int ) dataTable.Rows[ri6][2];
			this.jokern[ri6,(recordNumber+200)]++;

			JokerNumber.Text=recordNumber.ToString();

			string dateString = (string)dataTable.Rows[ri6][0].ToString();
			txtDate.Text=dateString;
						
			ri7=ri6;
			ri7++;
			for (int ri8=1;ri8<46;ri8++)
			{
				this.jokern1[ri6,(ri8+100)]=this.jokern[ri6,(ri8+100)];
                            
			}
			for (int ri8=1;ri8<21;ri8++)
			{
							 
				this.jokern1[ri6,(ri8+200)]=this.jokern[ri6,(ri8+200)];
			}

			MessageBox.Show("SEARCH  COMPLETED SUCCESFULLY");

						 
				 



			//string target1="";
			//string target2="";
			//string target3="";
			//conversion of string in format  yyyy/mm/dd
			//ready for sorting
			//Application.DoEvents();

			//DataRow  TargetRow=(System.Data.DataRow)dataTable.Rows;
			//TargetRow.BeginEdit();
			/*
									   string output="";
									   output+=dateString.Substring(dateString.LastIndexOf('/')+1,4);
									   int i10=dateString.LastIndexOf('/');
									   int i11=dateString.LastIndexOf('/',i10-1);
					
						
								   if(i10-i11==2)
								   {
									   //dateString[i11+1]="0";
									   // dateString.Insert((i11+1),"0");
									   //i10=i10+1;
			   //MessageBox.Show ("SELECTION REPORT2:");
			   //i11=dateString.LastIndexOf('/',i10-1);
									   output+="/";
									   output+="0";
									   output+=dateString.Substring(dateString.LastIndexOf('/',i10-1)+1,2);
									//output+="/";
                    
								   }
								   else
								   {
									   output+=dateString.Substring(dateString.LastIndexOf('/',i10-1),i10-i11+1);
								   }
			   //dateString.Insert(0,"0");
			   //int i12=dateString.IndexOf('/',i11-1);
								   if(i11==1)
			   output+="0";
									   output+=dateString.Substring(0,dateString.IndexOf('/'));


									   txtDate.Text=output.ToString();
			   //oleDbDataAdapter1.UpdateCommand.CommandText=  "";//"UPDATE joker1  SET" + "date='"+txtDate.Text;
		   
										   dataTable.Rows[ri6]["date"]=output.ToString();
										// drCurrent.EndEdit();

							 
				  System.Data.OleDb.OleDbCommandBuilder   cmdBuilder=new System.Data.OleDb.OleDbCommandBuilder(oleDbDataAdapter1);
				 //oleDbDataAdapter1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				  //string  oleUsersUpdate = string.Format ("UPDATE joker1 SET date = txtDate.Text WHERE id = ri6  ");
 

			   //oleDbDataAdapter1.DeleteCommand=cmdBuilder.GetDeleteCommand();
							 
											  // oleDbDataAdapter1.UpdateCommand=new System.Data.OleDb.OleDbCommand();
							//oleDbDataAdapter1.UpdateCommand.CommandText=  "UPDATE [joker1] SET [date] =  txtDate.Text WHERE [id]=(ri6+1)";
							   //oleDbDataAdapter1.UpdateCommand.Connection=oleDbConnection1;
				 
											//oleDbDataAdapter1.UpdateCommand.CommandText = oleUsersUpdate;

										 // oleDbDataAdapter1.InsertCommand=cmdBuilder.GetInsertCommand();
										   if(dataset1.HasChanges()==true)
										  {
											  //dataset1.GetChanges();
											 // MessageBox.Show("HasChanges=true");
					 
											  // oleDbDataAdapter1.UpdateCommand.CommandText="UPDATE joker1 SET jokernumber=40 ";

												 oleDbDataAdapter1.Update(dataset1,"joker1");
												// oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
											  dataset1.AcceptChanges();
										  }  


			   */
			//oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();

			//this.oleDbDataAdapter1.Update(this.dataset1,"joker1");
			//oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
			//dataset1.AcceptChanges();


			//TargetRow.EndEdit();
				 
			//DataSet  DataSetChanges=dataset1.GetChanges(DataRowState.Modified);

			//dataset1.Merge(DataSetChanges);
 
			//PopulateLB();
			//DataTable    dataTable =dataSet1.Tables[0];
			//ri4=50;
			//if (dataTable.Rows.Count !=  0)
				 
			//string  output="";
			//	output="this is ari4 value:{0}",tableDisplay.ri4;
			//this.Joker1.Text=Convert.ToString(tableDisplay.ri4);
			//DialogBox1.Console.WriteLine("variable ri4={0}",tableDisplay.ri4);
			//MessageBox.Show ("SELECTION REPORT","YOU HAVE SELECTED : "+ Text ,MessageBoxButtons.OKCancel);
			//string x = ((Form1)this.ParentForm).Text

			//this.Joker1.Text=Convert.ToString(ri6);
				 
                   
			//this.Joker1.Text=((TableDisplay)this.ParentForm).txtUserSelect.Text;
			 
		 
			MessageBox.Show("UPDATE  COMPLETED SUCCESFULLY");
		}

	}

	private void D3listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
	{
	
	}

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }
			}
}
