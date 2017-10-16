using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;


namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		static public double mnozh;
		public double Data1 = 0;
		public double Data2 = 0;
		public double Data3 = 0;
		public double Data4 = 0;
		public double Data5 = 0;
		public double k1 = 1;
		public double k2 = 1;
		public double k3 = 1;
		public double k4 = 1;
		public double k5 = 1;
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
		static public string[] words;
		public int status1 = 0;
		public double nol1 = 0;
		public double nol2 = 0;
		public double nol3 = 0;
		public double nol4 = 0;
		public double nol5 = 0;

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
			if (status == 1)
			{
			    Thread xot = new Thread(PodklForm);
				xot.Start();
			}
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

			if (status == 0)
			{
				do
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
					words = text.Split(razdelitel);
					for (int i = 0; i < words.Length; i++)
					{
						k1 = Properties.Settings.Default.TEXTBOX_kalibrovka1;
						k2 = Properties.Settings.Default.TEXTBOX_kalibrovka2;
						k3 = Properties.Settings.Default.TEXTBOX_kalibrovka3;
						k4 = Properties.Settings.Default.TEXTBOX_kalibrovka4;
						k5 = Properties.Settings.Default.TEXTBOX_kalibrovka5;
						Data1 = double.Parse(words[0]) * k1 * mnozh - nol1;
						Data2 = double.Parse(words[1]) * k2 * mnozh - nol2;
						Data3 = double.Parse(words[2]) * k3 * mnozh - nol3;
						Data4 = double.Parse(words[3]) * k4 * mnozh - nol4;
						Data5 = double.Parse(words[4]) * k5 * mnozh - nol5;


						Thread.Sleep(10);
						label8.Text = (Data1.ToString());
						label9.Text = (Data2.ToString());
						label10.Text = (Data3.ToString());
						label11.Text = (Data4.ToString());
						label12.Text = (Data5.ToString());
					}
				}
				while (true);
			}
		}

		//  КНОПКА СОХРАНИНИЯ 
		private void button3_Click(object sender, EventArgs e)
		{ if (textBox1.Text != "")
			{
				string D = "D:\\";
				string txt = ".txt";
				string Nazvanie = "Test";
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

				file.WriteLine("Датчик1" + "   Датчик2" + "   Датчик3" + "   Датчик4" + "   Датчик5");
				for (int i = 0; i < collMas; i++)
				{
					probel1 = 10 - stringArray1[i].Length;
					probel2 = 10 - stringArray2[i].Length; 
					probel3 = 10 - stringArray3[i].Length; 
					probel4 = 10 - stringArray4[i].Length; 
					probel5 = 10 - stringArray5[i].Length; 
					String s1 = new String(' ', probel1);
					String s2 = new String(' ', probel2);
					String s3 = new String(' ', probel3);
					String s4 = new String(' ', probel4);
					file.WriteLine(stringArray1[i] + s1 + stringArray2[i] + s2 + stringArray3[i] + s3 + stringArray4[i] + s4 + stringArray5[i]);
				}
				file.Close();
			}
		}

		//     КНОПКА ВЫВОД ДАННЫХ
		private void button2_Click(object sender, EventArgs e)
		{

			if (status == 1)
			MessageBox.Show("Проверьте подключение", "Ошибка");
			if (status == 0)
			{
				stringArray1[collMas] = label8.Text.ToString();
				stringArray2[collMas] = label9.Text.ToString();
				stringArray3[collMas] = label10.Text.ToString();
				stringArray4[collMas] = label11.Text.ToString();
				stringArray5[collMas] = label12.Text.ToString();
				collMas++;

				dete1 = label8.Text + Environment.NewLine + dete1;
				dete2 = label9.Text + Environment.NewLine + dete2;
				dete3 = label10.Text + Environment.NewLine + dete3;
				dete4 = label11.Text + Environment.NewLine + dete4;
				dete5 = label12.Text + Environment.NewLine + dete5;

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

		//    КНОПКА ВЫХОД
		private void button6_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Выйти?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.No) exit();
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Выйти?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.No) exit();
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

		//   ПОЛНЫЙ ВЫХОД
		public void exit()
		{
			full_delete(); Environment.Exit(0); Close();
		}

		//  КНОПКА НАСТРОЙКИ
		private void button5_Click_1(object sender, EventArgs e)
		{
			
			if (status == 1)
				MessageBox.Show("Проверьте подключение", "Ошибка");
			if (status == 0)
			{
				if (status1 == 0)
				{
					Thread.Sleep(1000);
					status1 = 1;
				}
				new Form2().Show();
			}
		}

		//    КНОПКА Обнулить показания датчиков
		private void button7_Click(object sender, EventArgs e)
		{
			if (status == 1)
				MessageBox.Show("Проверьте подключение", "Ошибка");
			if (status == 0)
			{
				nol1 = double.Parse(label8.Text);
				nol2 = double.Parse(label9.Text);
				nol3 = double.Parse(label10.Text);
				nol4 = double.Parse(label11.Text);
				nol5 = double.Parse(label12.Text);
			}
		}

		//  КНОПКА ИНСТРУКЦИЯ
		private void button11_Click(object sender, EventArgs e)
		{
			new Form5().Show();
		}


		//Ниже находится не задействованный хлам)
		private void Form1_Load(object sender, EventArgs e)
		{}
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
		{ }
		private void label12_Click(object sender, EventArgs e)
		{}
		private void label11_Click(object sender, EventArgs e)
		{}
		private void label10_Click(object sender, EventArgs e)
		{}
		private void label9_Click(object sender, EventArgs e)
		{}
		private void label8_Click(object sender, EventArgs e)
		{}
		private void label13_Click(object sender, EventArgs e)
		{}
		private void pictureBox1_Click(object sender, EventArgs e)
		{}
		private void textBox11_TextChanged(object sender, EventArgs e)
		{}
		private void textBox10_TextChanged(object sender, EventArgs e)
		{}
		private void textBox9_TextChanged(object sender, EventArgs e)
		{ }
		private void textBox8_TextChanged(object sender, EventArgs e)
		{}
		private void textBox7_TextChanged_1(object sender, EventArgs e)
		{}
	}
}


		