using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			string[] portnames = SerialPort.GetPortNames();
		    label1.Text = portnames[1];
								                                 
				
			}

				private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SerialPort STMport;
			string[] portnames = SerialPort.GetPortNames();
			
			STMport = new SerialPort();
			STMport.PortName = portnames[1];
			STMport.BaudRate = 9600;
			STMport.DataBits = 8;
			STMport.Parity = System.IO.Ports.Parity.None;
			STMport.StopBits = System.IO.Ports.StopBits.One;
			STMport.ReadBufferSize = 16;
			STMport.ReadTimeout = 10000;
			STMport.WriteTimeout = 10000;
			STMport.DtrEnable = true;
			STMport.Open();

			textBox5.Text = STMport.ReadLine();
			STMport.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
