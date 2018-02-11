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
		static public double mnozh;//"mnozh" мера измерения в разделе (КНОПКА ПОДКЛЮЧЕНИЯ (КОД))
		public string[] portnames = SerialPort.GetPortNames(); //  КНОПКА ПОДКЛЮЧЕНИЯ (КОД)
		public double Data1 = 0; //итоговые данные с датчиков, в понятном для пользователя виде.  в разделе (КНОПКА ПОДКЛЮЧЕНИЯ (КОД))
		public double Data2 = 0;
		public double Data3 = 0;
		public double Data4 = 0;
		public double Data5 = 0;
		public double k1 = 1; //коэффициент в разделе (КНОПКА ПОДКЛЮЧЕНИЯ (КОД))
		public double k2 = 1;
		public double k3 = 1;
		public double k4 = 1;
		public double k5 = 1;
		public SerialPort STMport;   //устройство.  в разделе (КНОПКА ПОДКЛЮЧЕНИЯ (КОД))
		public string resylt = " ";  //  КНОПКА ПОДКЛЮЧЕНИЯ (КОД)
		static public string[] words; //массив с данными датчика в разделе (КНОПКА ПОДКЛЮЧЕНИЯ (КОД))
		public double nol1 = 0;  //выполняет функцию обнуления показаний в разделе (КНОПКА ПОДКЛЮЧЕНИЯ (КОД))
		public double nol2 = 0;
		public double nol3 = 0;
		public double nol4 = 0;
		public double nol5 = 0; //переменные для КНОПКИ ПОДКЛЮЧЕНИЯ (КОД)


		public string Nazvanie1 = "Test"; //  КНОПКА СОХРАНИНИЯ 
		public string N = ""; // нумерация сохраняемых файлов КНОПКА СОХРАНИНИЯ 
		public int nom = 1;  // нумерация сохраняемых файлов КНОПКА СОХРАНИНИЯ 
		public string[] stringArray1 = new string[20]; //массивы с показаниями из лейблов, для сохранения в тектовый документ  КНОПКА СОХРАНИНИЯ 
		public string[] stringArray2 = new string[20];
		public string[] stringArray3 = new string[20];
		public string[] stringArray4 = new string[20];
		public string[] stringArray5 = new string[20];
		public int collMas = 0; //  КНОПКА СОХРАНИНИЯ  //переменные для КНОПКИ СОХРАНИНИЯ 

		public int status = 1;
		public int status1 = 0;

		public string dete1 = ""; //КНОПКА СНЯТЬ ПОКАЗАНИЯ
		public string dete2 = "";
		public string dete3 = "";
		public string dete4 = "";
		public string dete5 = ""; //переменные для КНОПКИ СНЯТЬ ПОКАЗАНИЯ

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
			if (status == 1)    //если статус=1 то выполняется код
			{
			    Thread xot = new Thread(PodklForm); //создается и запускается параллельный поток
				xot.Start();                         
			}
		}

		//  КНОПКА ПОДКЛЮЧЕНИЯ (КОД)
		private void PodklForm()
		{
			Form x = new Form();    
			int a = 0;
			int b = 0;
			foreach (string port in portnames)  // цикл поиска COM порта с подключенной STM
			{
				if (portnames[a] == "COM1")    //т.к к первому COM порту подключен монитор, мы его исключем 
				{
					a++;
				}
				else  //если имеются еще подключенные COM порты, то мы его как бы занимаем, и ставим статус=0  (не знаю что будет если подключить несколько COM устройств)
				{
					if (a == 1)
						MessageBox.Show("Подключено", port);       
					b++;
					status = 0;
				}
			}
			if (b == 0)      //если устройство не обнаруживается, то всплывает окно ошибки, ставится статус=1
			{
				MessageBox.Show("Контроллер не найден", "Ошибка");
				status = 1;
			}

			if (status == 0)        //если контроллер обноружен
			{
				do
				{
					label8.Refresh();          //очищаем label8-12, для реализации вывода данных в режиме онлайн 
					label9.Refresh();
					label10.Refresh();
					label11.Refresh();
					label12.Refresh();
					STMport = new SerialPort(); //описываем устройство 
					STMport.PortName = portnames[1];
					STMport.BaudRate = 9600;
					STMport.DataBits = 8;
					STMport.Parity = System.IO.Ports.Parity.None;
					STMport.StopBits = System.IO.Ports.StopBits.One;
					STMport.ReadBufferSize = 16;
					STMport.DtrEnable = true;
					STMport.Open();
					resylt = STMport.ReadLine();  //записываем полученные данные с виртуального COM порта в переменную
					STMport.Close();
					char razdelitel = ',';   
					string text = resylt;   
					words = text.Split(razdelitel);   //разделяем одну строку с данными записанные через запятую "text" на четыре отдельных строки в массив "words" 
					for (int i = 0; i < words.Length; i++) //перебираем массив "words"
					{
						k1 = Properties.Settings.Default.TEXTBOX_kalibrovka1; //загружаем параметры приложения, и присваеваем занчения в переменные "k"
						k2 = Properties.Settings.Default.TEXTBOX_kalibrovka2;
						k3 = Properties.Settings.Default.TEXTBOX_kalibrovka3;
						k4 = Properties.Settings.Default.TEXTBOX_kalibrovka4;
						k5 = Properties.Settings.Default.TEXTBOX_kalibrovka5;
						Data1 = (double.Parse(words[0]) - nol1) / k1 * mnozh; //по формуле считается нагрузку на датчик 
						Data2 = (double.Parse(words[1]) - nol2) / k2 * mnozh; //где "words" "сырые" значения с датчика, "nol" выполняет функцию обнуления показаний 
						Data3 = (double.Parse(words[2]) - nol3) / k3 * mnozh; //"k" коэффициент, "mnozh" мера измерения (граммы, килограммы и д.р)
						Data4 = (double.Parse(words[3]) - nol4) / k4 * mnozh;
						Data5 = (double.Parse(words[4]) - nol5) / k5 * mnozh;

						label8.Text = (Data1.ToString());  //выводим полученные данные на экран
						label9.Text = (Data2.ToString());
						label10.Text = (Data3.ToString());
						label11.Text = (Data4.ToString());
						label12.Text = (Data5.ToString());

						Thread.Sleep(100); //отдыхаем 100мс, и продолжаем цикл заново 
					}
				}
				while (true);
			}
		}

		//  КНОПКА СОХРАНИНИЯ 
		private void button3_Click(object sender, EventArgs e)
		{ if (textBox1.Text != "") //если в текст боксе есть данные то алгоритм выполняется
			{
				string D = "D:\\"; 
				string txt = ".txt";
				string Nazvanie = "Test"; 
				int probel1 = 0;  //переменные для расчета символьного пространства для сохраняемых данных
				int probel2 = 0;
				int probel3 = 0;
				int probel4 = 0;
				int probel5 = 0;
				if (textBox6.Text == "Испытание") //если название не введено т.е "Испытание" то назначается стандартное имя файла, и формируется путь сохранения 
				{
					N = nom.ToString();
					Nazvanie1 = D + Nazvanie + N + txt;
					nom++;
					MessageBox.Show("Файл " + Nazvanie + N + txt + " создан", "Файл создан");
				}
				else  // иначе присваевается веденное навзвание, и формируется путь сохранения 
				{ Nazvanie = textBox6.Text;  
					Nazvanie1 = D + Nazvanie + txt;
					MessageBox.Show("Файл " + Nazvanie + txt + " создан", "Файл создан");
				}

				StreamWriter file = new StreamWriter(Nazvanie1); 

				file.WriteLine("Датчик1" + "   Датчик2" + "   Датчик3" + "   Датчик4" + "   Датчик5"); //вывод первой строки в сохраняемом файле
				for (int i = 0; i < collMas; i++) //вывод данных столбцами  
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

		//     КНОПКА СНЯТЬ ПОКАЗАНИЯ
		private void button2_Click(object sender, EventArgs e)
		{

			if (status == 1)
			MessageBox.Show("Проверьте подключение", "Ошибка");
			if (status == 0)
			{
				if (collMas <= 17) //ограничение сохраниния данных в текст боксы
				{
					stringArray1[collMas] = label8.Text.ToString(); //запись данных из лейблов в массивы, для дальнейшего сохраниния 
					stringArray2[collMas] = label9.Text.ToString();
					stringArray3[collMas] = label10.Text.ToString();
					stringArray4[collMas] = label11.Text.ToString();
					stringArray5[collMas] = label12.Text.ToString();
					collMas++;

					dete1 = label8.Text + Environment.NewLine + dete1; //запись данных из лейблов в переменные столбцом 
					dete2 = label9.Text + Environment.NewLine + dete2;
					dete3 = label10.Text + Environment.NewLine + dete3;
					dete4 = label11.Text + Environment.NewLine + dete4;
					dete5 = label12.Text + Environment.NewLine + dete5;

					textBox1.Text = (dete1); //запись данных из лейблов в тестбоксы
					textBox2.Text = (dete2);
					textBox3.Text = (dete3);
					textBox4.Text = (dete4);
					textBox5.Text = (dete5);
				}				
			}
		}

		//   СБРОС ПОКАЗАНИЙ
		private void button4_Click(object sender, EventArgs e)
		{
			full_delete(); //очистка текстобоксов 
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
			 exit();
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			 exit();
		}

		//   УДАЛЕНИЕ
		public void full_delete()   //очистка текстобоксов 
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
			status = 1; full_delete(); Environment.Exit(0); Close(); 
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
					Thread.Sleep(1000);   //пауза при первом включении настроек 
					status1 = 1;
				}
				new Form2().Show(); //открывается окно настроек
			}
		}

		//    КНОПКА Обнулить показания датчиков
		private void button7_Click(object sender, EventArgs e)  //что то не так (нужно поправить) 
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


		