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
		public string probel = "                    ";
		public string dete1 = "";
		public string dete2 = "";
		public string dete3 = "";
		public string dete4 = "";
		public string dete5 = "";
		public string Nazvanie = "";
		public int status=1;
		public Form1()
		{
			InitializeComponent();
		}
		//  КНОПКА ПОДКЛЮЧЕНИЯ
		private void button1_Click(object sender, EventArgs e)
		{
			int a = 0;
			int b=0;
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
					status = 0;
				}
			}
			if (b == 0)
			{
				MessageBox.Show("Контроллер не найден", "Ошибка");
				status = 1;
			}
		}

		//  КНОПКА СОХРАНИНИЯ 
		private void button3_Click(object sender, EventArgs e)
		{ if (textBox1.Text != "")
			{
				string D = "D:\\";
				string txt = ".txt";
				Nazvanie = textBox6.Text;
				Nazvanie = D + Nazvanie + txt;

				StreamWriter file = new StreamWriter(Nazvanie);
				char razdelitel = ' ';
				string[] words1 = textBox1.Text.Split(razdelitel);
				string[] words2 = textBox2.Text.Split(razdelitel);
				string[] words3 = textBox3.Text.Split(razdelitel);
				string[] words4 = textBox4.Text.Split(razdelitel);
				string[] words5 = textBox5.Text.Split(razdelitel);


				for (int i = 0; i < words1.Length; i++)
				{

					file.WriteLine((words1[i]) + ("  " + words2[i]) + ("  " + words3[i]) + ("  " + words4[i]) + ("  " + words5[i]));
				}


				file.Close();
			}
		}
		
		//     ВЫВОД ДАННЫХ
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
			{ MessageBox.Show("Проверте подключение", "Ошибка");
				status = 1;
			}
			if (status == 0)
			{
				char razdelitel = ',';
				string text = resylt;
				string[] words = text.Split(razdelitel);
				for (int i = 0; i < words.Length; i++)
				{
					data1 = (words[0]);
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
				//textBox1.Text = (Data1.ToString());
				dete1 = data1 + probel + dete1;
				dete2 = data2 + probel + dete2;
				dete3 = data3 + probel + dete3;
				dete4 = data4 + probel + dete4;
				dete5 = data5 + probel + dete5;
				textBox1.Text = (dete1);
				textBox2.Text = (dete2);
				textBox3.Text = (dete3);
				textBox4.Text = (dete4);
				textBox5.Text = (dete5);
			}
		}

		 //   СБРОС ПОКАЗАНИЙ
		private void button4_Click(object sender, EventArgs e)
		{
			textBox5.Text = null;
			textBox4.Text = null;
			textBox3.Text = null;
			textBox2.Text = null;
			textBox1.Text = null;
			 dete1 = "";
		     dete2 = "";
		     dete3 = "";
		     dete4 = "";
	         dete5 = "";
	    }

		//   ВЫХОД
		private void button6_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Закрыть?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.No) this.Close();		
		}



		//Ниже находится не задействованный хлам)))
		private void Form1_Load(object sender, EventArgs e)
		{		}
		private void textBox6_TextChanged(object sender, EventArgs e)
		{		}
		private void textBox7_TextChanged(object sender, EventArgs e)
		{		}
		private void label1_Click_2(object sender, EventArgs e)
		{		}
		private void label1_Click_3(object sender, EventArgs e)
		{		}
		private void label1_Click_1(object sender, EventArgs e)
		{		}
		private void label2_Click(object sender, EventArgs e)
		{		}
		private void label1_Click(object sender, EventArgs e)
		{		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{		}
		private void label3_Click(object sender, EventArgs e)
		{		}
		private void textBox5_TextChanged(object sender, EventArgs e)
		{		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}
	}
	
}
