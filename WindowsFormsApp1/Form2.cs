using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
	public partial class Form2 : Form
	{
		public double k1 = 1;
		public double k2 = 1;
		public double k3 = 1;
		public double k4 = 1;
		public double k5 = 1;
		public double R1 = 1;
		public double R2 = 1;
		public double R3 = 1;
		public double R4 = 1;
		public double R5 = 1;
		Form1 words = new Form1();
		Thread xot1;
		public Form2()
		{
			InitializeComponent();
			xot1 = new Thread(PodklForm1);
			xot1.Start();
		}

		public void PodklForm1()
		{
			Form x1 = new Form();
			do
			{
				label6.Text = Form1.words[0];
				label7.Text = Form1.words[1];
				label8.Text = Form1.words[2];
				label9.Text = Form1.words[3];
				label10.Text = Form1.words[4];
			}
			while (true);

		}

		private void button11_Click(object sender, EventArgs e)
		{
			new Form3().Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			k1 = (double.Parse(Form1.words[0]) - R1) / double.Parse(textBox1.Text);
			label1.Text = k1.ToString();
			Properties.Settings.Default.TEXTBOX_kalibrovka1 = k1;
			Properties.Settings.Default.Save();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			R1 = double.Parse(Form1.words[0]);
			button1.Text = (R1.ToString());
		}

		private void button7_Click(object sender, EventArgs e)
		{
			k2 = (double.Parse(Form1.words[1]) - R2) / double.Parse(textBox2.Text);
			label2.Text = k2.ToString();
			Properties.Settings.Default.TEXTBOX_kalibrovka2 = k2;
			Properties.Settings.Default.Save();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			k3 = (double.Parse(Form1.words[2]) - R3) / double.Parse(textBox3.Text);
			label3.Text = k3.ToString();
			Properties.Settings.Default.TEXTBOX_kalibrovka3 = k3;
			Properties.Settings.Default.Save();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			k4 = (double.Parse(Form1.words[3]) - R4) / double.Parse(textBox4.Text);
			label4.Text = k4.ToString();
			Properties.Settings.Default.TEXTBOX_kalibrovka4 = k4;
			Properties.Settings.Default.Save();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			k5 = (double.Parse(Form1.words[4]) - R5) / double.Parse(textBox5.Text);
			label5.Text = k5.ToString();
			Properties.Settings.Default.TEXTBOX_kalibrovka5 = k5;
			Properties.Settings.Default.Save();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			R2 = double.Parse(Form1.words[1]);
			button2.Text = (R2.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			R3 = double.Parse(Form1.words[2]);
			button3.Text = (R3.ToString());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			R4 = double.Parse(Form1.words[3]);
			button4.Text = (R4.ToString());
		}

		private void button5_Click(object sender, EventArgs e)
		{
			R5 = double.Parse(Form1.words[4]);
			button5.Text = (R5.ToString());
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			xot1.Abort();
		}


		private void label6_Click(object sender, EventArgs e)
		{

		}

	}
}
