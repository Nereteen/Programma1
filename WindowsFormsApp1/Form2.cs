using System;
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
			label1.Text = Properties.Settings.Default.TEXTBOX_kalibrovka1.ToString();
			label2.Text = Properties.Settings.Default.TEXTBOX_kalibrovka2.ToString();
			label3.Text = Properties.Settings.Default.TEXTBOX_kalibrovka3.ToString();
			label4.Text = Properties.Settings.Default.TEXTBOX_kalibrovka4.ToString();
			label5.Text = Properties.Settings.Default.TEXTBOX_kalibrovka5.ToString();

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
			int status = 0;
			if (textBox1.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Масса'' ","Ошибка"); status++; }
			if (textBox7.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Показания датчика принятые за ноль'' ", "Ошибка"); status++; }
			if (button1.Text == "Сохранить")
			{ MessageBox.Show("Введите данные при отсутствии нагрузки на датчике, кнопкой ''Сохранить''", "Ошибка"); status++; }
			if (status == 0)
			{
				k1 = (double.Parse(Form1.words[0]) - R1) / double.Parse(textBox1.Text);
				label1.Text = k1.ToString();
				Properties.Settings.Default.TEXTBOX_kalibrovka1 = k1;
				Properties.Settings.Default.Save();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			R1 = double.Parse(Form1.words[0]);
			button1.Text = (R1.ToString());
		}

		private void button7_Click(object sender, EventArgs e)
		{ int status = 0;
			if (textBox2.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Масса'' ", "Ошибка"); status++;
			}
			if (textBox6.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Показания датчика принятые за ноль'' ", "Ошибка"); status++;
			}
			if (button2.Text == "Сохранить")
			{ MessageBox.Show("Введите данные при отсутствии нагрузки на датчике, кнопкой ''Сохранить''", "Ошибка"); status++;
			}
			if (status == 0)
			{
				k2 = (double.Parse(Form1.words[1]) - R2) / double.Parse(textBox2.Text);
				label2.Text = k2.ToString();
				Properties.Settings.Default.TEXTBOX_kalibrovka2 = k2;
				Properties.Settings.Default.Save();
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{ int status = 0;
			if (textBox3.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Масса'' ", "Ошибка"); status++;
			}
			if (textBox8.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Показания датчика принятые за ноль'' ", "Ошибка"); status++;
			}
			if (button3.Text == "Сохранить")
			{ MessageBox.Show("Введите данные при отсутствии нагрузки на датчике, кнопкой ''Сохранить''", "Ошибка"); status++;
			}
			if (status == 0)
			{
				k3 = (double.Parse(Form1.words[2]) - R3) / double.Parse(textBox3.Text);
				label3.Text = k3.ToString();
				Properties.Settings.Default.TEXTBOX_kalibrovka3 = k3;
				Properties.Settings.Default.Save();
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{ int status = 0;
			if (textBox4.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Масса'' ", "Ошибка"); status++;
			}
			if (textBox9.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Показания датчика принятые за ноль'' ", "Ошибка"); status++;
			}
			if (button4.Text == "Сохранить")
			{ MessageBox.Show("Введите данные при отсутствии нагрузки на датчике, кнопкой ''Сохранить''", "Ошибка"); status++;
			}
			if (status == 0)
			{
				k4 = (double.Parse(Form1.words[3]) - R4) / double.Parse(textBox4.Text);
				label4.Text = k4.ToString();
				Properties.Settings.Default.TEXTBOX_kalibrovka4 = k4;
				Properties.Settings.Default.Save();
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{ int status = 0;
			if (textBox5.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Масса'' ", "Ошибка"); status++;
			}
			if (textBox10.Text == "")
			{ MessageBox.Show("Введите данные в графу ''Показания датчика принятые за ноль'' ", "Ошибка"); status++;
			}
			if (button5.Text == "Сохранить")
			{ MessageBox.Show("Введите данные при отсутствии нагрузки на датчике, кнопкой ''Сохранить''", "Ошибка"); status++;
			}
			if (status == 0)
			{
				k5 = (double.Parse(Form1.words[4]) - R5) / double.Parse(textBox5.Text);
				label5.Text = k5.ToString();
				Properties.Settings.Default.TEXTBOX_kalibrovka5 = k5;
				Properties.Settings.Default.Save();
			}
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

		private void button12_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.TEXTBOX_kalibrovka1=0;
			label1.Text = Properties.Settings.Default.TEXTBOX_kalibrovka1.ToString();
			Properties.Settings.Default.Save();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.TEXTBOX_kalibrovka2 = 0;
			label2.Text = Properties.Settings.Default.TEXTBOX_kalibrovka2.ToString();
			Properties.Settings.Default.Save();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.TEXTBOX_kalibrovka3 = 0;
			label3.Text = Properties.Settings.Default.TEXTBOX_kalibrovka3.ToString();
			Properties.Settings.Default.Save();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.TEXTBOX_kalibrovka4 = 0;
			label4.Text = Properties.Settings.Default.TEXTBOX_kalibrovka4.ToString();
			Properties.Settings.Default.Save();
		}

		private void button16_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.TEXTBOX_kalibrovka5 = 0;
			label5.Text = Properties.Settings.Default.TEXTBOX_kalibrovka5.ToString();
			Properties.Settings.Default.Save();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
