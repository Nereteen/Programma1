﻿using System;
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
			System.Threading.Thread.Sleep(1000);
			
			int a = 0;
			int b=1;
			string[] portnames = SerialPort.GetPortNames();

			foreach (string port in portnames)
			{
				if (portnames[a] == "COM1")
				{
					
					a++;
				}
				else
				{ if (a == 1)
				MessageBox.Show("Подключено", port);
					b++;
				}
			}
			if (b==1)
			MessageBox.Show("Контроллер не найден", "Ошибка");
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
			string resylt=" ";
			string data1 = " ";
			string data2 = " ";
			string data3 = " ";
			string data4 = " ";
			string data5 = " ";
			double Data1 = 0;
			double Data2 = 0;
			double Data3 = 0;
			double Data4 = 0;
			double Data5 = 0;
			int a = 0;
			int b = 1;
			foreach (string port in portnames)
			{
				if (portnames[a] == "COM1")
				{
					a++;
				}
				else
				{  
					if (a == 1)
					b++;
					STMport = new SerialPort();
					STMport.PortName = portnames[1];
					STMport.BaudRate = 9600;
					STMport.DataBits = 8;
					STMport.Parity = System.IO.Ports.Parity.None;
					STMport.StopBits = System.IO.Ports.StopBits.One;
					STMport.ReadBufferSize = 16;
					STMport.ReadTimeout = 1000;
					STMport.DtrEnable = true;
					STMport.Open();
					resylt = STMport.ReadLine();
					STMport.Close();
				}
			}
			if (b == 1)
				MessageBox.Show("Проверте подключение", "Ошибка");

			char razdelitel = ',';
			string text = resylt;
			string[] words = text.Split(razdelitel);
			for (int i = 0; i < words.Length; i++)
			{
				data1=(words[0]);
				data2 = (words[1]);
				data3 = (words[2]);
				data4 = (words[3]);
				data5 = (words[4]);
			}
			Data1 = double.Parse(data1);
			Data2 = double.Parse(data2);
			Data3 = double.Parse(data3);
			Data4 = double.Parse(data4);
			Data5 = double.Parse(data5);
			textBox1.Text = (Data1.ToString());
			textBox2.Text = (Data2.ToString());
			textBox3.Text = (Data3.ToString());
			textBox4.Text = (Data4.ToString());
			textBox5.Text = (Data5.ToString());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox5.Text = null;
			textBox4.Text = null;
			textBox3.Text = null;
			textBox2.Text = null;
			textBox1.Text = null;
		}

		private void button6_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Закрыть?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.No) this.Close();
						
		}

		private void label1_Click_2(object sender, EventArgs e)
		{

		}
	}
	
}
