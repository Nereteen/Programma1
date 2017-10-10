namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(53, 369);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "Проверить подключение";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(688, 88);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 37);
			this.button2.TabIndex = 3;
			this.button2.Text = "Снять показания";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(688, 283);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(132, 37);
			this.button3.TabIndex = 4;
			this.button3.Text = "Сохранить в текстовом документе";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(688, 148);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(132, 37);
			this.button4.TabIndex = 5;
			this.button4.Text = "Сброс всех показаний";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(714, 369);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Выход";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox1
			// 
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Location = new System.Drawing.Point(53, 116);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(89, 232);
			this.textBox1.TabIndex = 8;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Location = new System.Drawing.Point(176, 116);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(89, 232);
			this.textBox2.TabIndex = 9;
			// 
			// textBox3
			// 
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Location = new System.Drawing.Point(296, 116);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(89, 232);
			this.textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox4.Location = new System.Drawing.Point(417, 116);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(89, 232);
			this.textBox4.TabIndex = 11;
			// 
			// textBox5
			// 
			this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox5.Location = new System.Drawing.Point(540, 116);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(89, 232);
			this.textBox5.TabIndex = 12;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Датчик 1";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(191, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Датчик 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(313, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Датчик 3";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(434, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Датчик 4";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(557, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Датчик 5";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(417, 35);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(212, 20);
			this.textBox6.TabIndex = 13;
			this.textBox6.Text = "Испытание";
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(293, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Название испытания:";
			this.label1.Click += new System.EventHandler(this.label1_Click_3);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(152, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 22;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Мера измерения:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(788, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 56);
			this.pictureBox1.TabIndex = 25;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(53, 524);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(89, 20);
			this.textBox11.TabIndex = 31;
			this.textBox11.Text = "0";
			this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(53, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 25);
			this.label8.TabIndex = 30;
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label9.Location = new System.Drawing.Point(176, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 25);
			this.label9.TabIndex = 29;
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(296, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 25);
			this.label10.TabIndex = 28;
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(417, 88);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(89, 25);
			this.label11.TabIndex = 27;
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label12
			// 
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Location = new System.Drawing.Point(540, 88);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(89, 25);
			this.label12.TabIndex = 26;
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(53, 589);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(89, 37);
			this.button7.TabIndex = 36;
			this.button7.Text = "Калибровать";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(53, 550);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(89, 37);
			this.button5.TabIndex = 37;
			this.button5.Text = "Принятые за ноль";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(50, 495);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(92, 26);
			this.label13.TabIndex = 38;
			this.label13.Text = "Масса";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// label14
			// 
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label14.Location = new System.Drawing.Point(53, 470);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(89, 25);
			this.label14.TabIndex = 39;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(50, 444);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(92, 26);
			this.label15.TabIndex = 40;
			this.label15.Text = "Коэффициент пропорциональности";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(173, 444);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(92, 26);
			this.label16.TabIndex = 46;
			this.label16.Text = "Коэффициент пропорциональности";
			// 
			// label17
			// 
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label17.Location = new System.Drawing.Point(176, 470);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(89, 25);
			this.label17.TabIndex = 45;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(173, 495);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(92, 26);
			this.label18.TabIndex = 44;
			this.label18.Text = "Масса";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(176, 550);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(89, 37);
			this.button8.TabIndex = 43;
			this.button8.Text = "Принятые за ноль";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(176, 589);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(89, 37);
			this.button9.TabIndex = 42;
			this.button9.Text = "Калибровать";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(176, 524);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(89, 20);
			this.textBox7.TabIndex = 41;
			this.textBox7.Text = "0";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(293, 444);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(92, 26);
			this.label19.TabIndex = 52;
			this.label19.Text = "Коэффициент пропорциональности";
			// 
			// label20
			// 
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label20.Location = new System.Drawing.Point(296, 470);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(89, 25);
			this.label20.TabIndex = 51;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(293, 495);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(92, 26);
			this.label21.TabIndex = 50;
			this.label21.Text = "Масса";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(296, 550);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(89, 37);
			this.button10.TabIndex = 49;
			this.button10.Text = "Принятые за ноль";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(296, 589);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(89, 37);
			this.button11.TabIndex = 48;
			this.button11.Text = "Калибровать";
			this.button11.UseVisualStyleBackColor = true;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(296, 524);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(89, 20);
			this.textBox8.TabIndex = 47;
			this.textBox8.Text = "0";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(414, 444);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(92, 26);
			this.label22.TabIndex = 58;
			this.label22.Text = "Коэффициент пропорциональности";
			// 
			// label23
			// 
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label23.Location = new System.Drawing.Point(417, 470);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(89, 25);
			this.label23.TabIndex = 57;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(414, 495);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(92, 26);
			this.label24.TabIndex = 56;
			this.label24.Text = "Масса";
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(417, 550);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(89, 37);
			this.button12.TabIndex = 55;
			this.button12.Text = "Принятые за ноль";
			this.button12.UseVisualStyleBackColor = true;
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(417, 589);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(89, 37);
			this.button13.TabIndex = 54;
			this.button13.Text = "Калибровать";
			this.button13.UseVisualStyleBackColor = true;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(417, 524);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(89, 20);
			this.textBox9.TabIndex = 53;
			this.textBox9.Text = "0";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(537, 444);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(92, 26);
			this.label25.TabIndex = 64;
			this.label25.Text = "Коэффициент пропорциональности";
			// 
			// label26
			// 
			this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label26.Location = new System.Drawing.Point(540, 470);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(89, 25);
			this.label26.TabIndex = 63;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(537, 495);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(92, 26);
			this.label27.TabIndex = 62;
			this.label27.Text = "Масса";
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(540, 550);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(89, 37);
			this.button14.TabIndex = 61;
			this.button14.Text = "Принятые за ноль";
			this.button14.UseVisualStyleBackColor = true;
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(540, 589);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(89, 37);
			this.button15.TabIndex = 60;
			this.button15.Text = "Калибровать";
			this.button15.UseVisualStyleBackColor = true;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(540, 524);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(89, 20);
			this.textBox10.TabIndex = 59;
			this.textBox10.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 680);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.TextBox textBox10;
	}
}

