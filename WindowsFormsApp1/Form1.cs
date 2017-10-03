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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Threading;

namespace WindowsFormsApp1
{


	public partial class Form1 : Form
	{
		static public double mnozh;
		public string probel = "                    ";
		public string dete1 = "";
		public string dete2 = "";
		public string dete3 = "";
		public string dete4 = "";
		public string dete5 = "";
		public string Nazvanie1 = "Test";
		public string N = "";
		public int nom = 1;
		public int status = 1;
		public string[] stringArray1 = new string[20];
		public string[] stringArray2 = new string[20];
		public string[] stringArray3 = new string[20];
		public string[] stringArray4 = new string[20];
		public string[] stringArray5 = new string[20];
		public int collMas = 0;
		public string[] portnames = SerialPort.GetPortNames();
		public SerialPort STMport;
		public string resylt = " ";

		public Form1()
		{
			InitializeComponent();
			List<mera> izmer = new List<mera>
		{
			new mera { Id=2, Name="Граммы", Mn=1},
			new mera { Id=1, Name="Миллиграммы", Mn=1000},
			new mera { Id=3, Name="Килограммы", Mn=0.001}
		};
			comboBox1.DataSource = izmer;
			comboBox1.DisplayMember = "Name";
			comboBox1.ValueMember = "Id";
		}

		//  КНОПКА ПОДКЛЮЧЕНИЯ
		private void button1_Click(object sender, EventArgs e)
		{
			Thread x = new Thread(PodklForm);
			x.Start();
		}

		//  КНОПКА СОХРАНИНИЯ 
		private void button3_Click(object sender, EventArgs e)
		{ if (textBox1.Text != "")
			{
				string D = "D:\\";
				string txt = ".txt";
				string Nazvanie = "Test";
				int simbol1 = 0;
				int simbol2 = 0;
				int simbol3 = 0;
				int simbol4 = 0;
				int simbol5 = 0;
				int probel1 = 0;
				int probel2 = 0;
				int probel3 = 0;
				int probel4 = 0;
				int probel5 = 0;
				if (textBox6.Text == "Испытание")
				{
					N = nom.ToString();
					Nazvanie1 = D + Nazvanie + N + txt;
					nom++;
					MessageBox.Show("Файл " + Nazvanie + N + txt + " создан", "Файл создан");
				}
				else
				{ Nazvanie = textBox6.Text;
					Nazvanie1 = D + Nazvanie + txt;
					MessageBox.Show("Файл " + Nazvanie + txt + " создан", "Файл создан");
				}

				StreamWriter file = new StreamWriter(Nazvanie1);
				string words1 = textBox1.Text;
				string words2 = textBox2.Text;
				string words3 = textBox3.Text;
				string words4 = textBox4.Text;
				string words5 = textBox5.Text;

				//int coll1=textBox1.Lines.Length-1;
				file.WriteLine("Датчик1" + "   Датчик2" + "   Датчик3" + "   Датчик4" + "   Датчик5");
				for (int i = 0; i < collMas; i++)
				{
					simbol1 = stringArray1[i].Length;
					simbol2 = stringArray2[i].Length;
					simbol3 = stringArray3[i].Length;
					simbol4 = stringArray4[i].Length;
					simbol5 = stringArray5[i].Length;
					probel1 = 10 - simbol1;
					probel2 = 10 - simbol2;
					probel3 = 10 - simbol3;
					probel4 = 10 - simbol4;
					probel5 = 10 - simbol5;
					String s = new String(' ', probel1);

					file.WriteLine(stringArray1[i] + s + stringArray2[i] + s + stringArray3[i] + s + stringArray4[i] + s + stringArray5[i]);
				}


				file.Close();
			}
		}

		//     ВЫВОД ДАННЫХ
		private void button2_Click(object sender, EventArgs e)
		{
			
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
				}
			}
			if (b == 1)
			{ MessageBox.Show("Проверьте подключение", "Ошибка");
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
				Data1 = double.Parse(data1) * mnozh;     //для работы с показаниями 
				Data2 = double.Parse(data2) * mnozh;
				Data3 = double.Parse(data3) * mnozh;
				Data4 = double.Parse(data4) * mnozh;
				Data5 = double.Parse(data5) * mnozh;

				stringArray1[collMas] = Data1.ToString();
				stringArray2[collMas] = Data2.ToString();
				stringArray3[collMas] = Data3.ToString();
				stringArray4[collMas] = Data4.ToString();
				stringArray5[collMas] = Data5.ToString();
				collMas++;

				dete1 = Data1.ToString() + Environment.NewLine + dete1;
				dete2 = Data2.ToString() + Environment.NewLine + dete2;
				dete3 = Data3.ToString() + Environment.NewLine + dete3;
				dete4 = Data4.ToString() + Environment.NewLine + dete4;
				dete5 = Data5.ToString() + Environment.NewLine + dete5;

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
			full_delete();
		}

		//    ВЫХОД
		private void button6_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Выйти?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.No) this.Close();
		}

		//   УДАЛЕНИЕ
		public void full_delete()
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
			collMas = 0;
		}

		//    МЕРА ИЗМЕРЕНИЯ
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			mera izmer = (mera)comboBox1.SelectedItem;
			mnozh = izmer.Mn;
		}
		public class mera
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public double Mn { get; set; }
		}

		//    КАЛИБРОВКА
		private void button7_Click(object sender, EventArgs e)
		{
		}

		//  КНОПКА ПОДКЛЮЧЕНИЯ (КОД)
		private void PodklForm()
		{
			Form x = new Form();
			int a = 0;
			int b = 0;
			foreach (string port in portnames)
			{
				if (portnames[a] == "COM1")
				{
					a++;
				}
				else
				{
					if (a == 1)
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

			for (int statusZn = 0; status == 0; statusZn++)
			{
				label8.Refresh();
				label9.Refresh();
				label10.Refresh();
				label11.Refresh();
				label12.Refresh();
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
				char razdelitel = ',';
				string text = resylt;
				string[] words = text.Split(razdelitel);
				for (int i = 0; i < words.Length; i++)
				{
					Thread.Sleep(100);
					label8.Text = (words[0]);
					label9.Text = (words[1]);
					label10.Text = (words[2]);
					label11.Text = (words[3]);
					label12.Text = (words[4]);
				}
			}
		}

		//Ниже находится не задействованный хлам)
		private void Form1_Load(object sender, EventArgs e)
		{ }
		private void textBox6_TextChanged(object sender, EventArgs e)
		{ }
		private void textBox7_TextChanged(object sender, EventArgs e)
		{ }
		private void label1_Click_2(object sender, EventArgs e)
		{ }
		private void label1_Click_3(object sender, EventArgs e)
		{ }
		private void label1_Click_1(object sender, EventArgs e)
		{ }
		private void label2_Click(object sender, EventArgs e)
		{ }
		private void label1_Click(object sender, EventArgs e)
		{ }
		private void textBox1_TextChanged(object sender, EventArgs e)
		{ }
		private void label3_Click(object sender, EventArgs e)
		{ }
		private void textBox5_TextChanged(object sender, EventArgs e)
		{ }

		private void label2_Click_1(object sender, EventArgs e)
		{

		}
		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}
	}
}


		