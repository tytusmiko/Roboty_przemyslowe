namespace WindowsFormsApp17
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WyborPortu = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.Wiadomosc_Okno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.Textbox_Odbior = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Łączenie = new System.Windows.Forms.GroupBox();
            this.Wybor_Stop = new System.Windows.Forms.ComboBox();
            this.Wybor_Parity = new System.Windows.Forms.ComboBox();
            this.Wybor_Data = new System.Windows.Forms.ComboBox();
            this.Wybor_Baud = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scrollbar1_wartosc = new System.Windows.Forms.TextBox();
            this.scrollbar2_wartosc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Łączenie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WyborPortu
            // 
            this.WyborPortu.DisplayMember = "BRAK";
            this.WyborPortu.FormattingEnabled = true;
            this.WyborPortu.Location = new System.Drawing.Point(68, 28);
            this.WyborPortu.Name = "WyborPortu";
            this.WyborPortu.Size = new System.Drawing.Size(147, 21);
            this.WyborPortu.TabIndex = 0;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(229, 19);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 20);
            this.Send.TabIndex = 2;
            this.Send.Tag = "";
            this.Send.Text = "Wyslij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Wiadomosc_Okno
            // 
            this.Wiadomosc_Okno.Location = new System.Drawing.Point(103, 19);
            this.Wiadomosc_Okno.Name = "Wiadomosc_Okno";
            this.Wiadomosc_Okno.Size = new System.Drawing.Size(120, 20);
            this.Wiadomosc_Okno.TabIndex = 3;
            this.Wiadomosc_Okno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PORT:";
            // 
            // serialPort1
            // 
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.PortName = "BRAK";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tekst wysyłania:";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(241, 28);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(75, 21);
            this.Button_Connect.TabIndex = 6;
            this.Button_Connect.Tag = "";
            this.Button_Connect.Text = "Połącz";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Enabled = false;
            this.hScrollBar1.Location = new System.Drawing.Point(261, 72);
            this.hScrollBar1.Maximum = 109;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(161, 20);
            this.hScrollBar1.TabIndex = 7;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Enabled = false;
            this.hScrollBar2.Location = new System.Drawing.Point(261, 105);
            this.hScrollBar2.Maximum = 109;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(161, 20);
            this.hScrollBar2.TabIndex = 8;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // Textbox_Odbior
            // 
            this.Textbox_Odbior.Location = new System.Drawing.Point(13, 61);
            this.Textbox_Odbior.Multiline = true;
            this.Textbox_Odbior.Name = "Textbox_Odbior";
            this.Textbox_Odbior.Size = new System.Drawing.Size(291, 133);
            this.Textbox_Odbior.TabIndex = 13;
            this.Textbox_Odbior.TextChanged += new System.EventHandler(this.Textbox_Odbior_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Odbiór:";
            // 
            // Łączenie
            // 
            this.Łączenie.Controls.Add(this.Wybor_Stop);
            this.Łączenie.Controls.Add(this.Wybor_Parity);
            this.Łączenie.Controls.Add(this.Wybor_Data);
            this.Łączenie.Controls.Add(this.Wybor_Baud);
            this.Łączenie.Controls.Add(this.label13);
            this.Łączenie.Controls.Add(this.label12);
            this.Łączenie.Controls.Add(this.label11);
            this.Łączenie.Controls.Add(this.label10);
            this.Łączenie.Location = new System.Drawing.Point(12, 12);
            this.Łączenie.Name = "Łączenie";
            this.Łączenie.Size = new System.Drawing.Size(324, 159);
            this.Łączenie.TabIndex = 15;
            this.Łączenie.TabStop = false;
            this.Łączenie.Text = "Łączenie";
            // 
            // Wybor_Stop
            // 
            this.Wybor_Stop.DisplayMember = "BRAK";
            this.Wybor_Stop.FormattingEnabled = true;
            this.Wybor_Stop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Wybor_Stop.Location = new System.Drawing.Point(56, 124);
            this.Wybor_Stop.Name = "Wybor_Stop";
            this.Wybor_Stop.Size = new System.Drawing.Size(147, 21);
            this.Wybor_Stop.TabIndex = 24;
            // 
            // Wybor_Parity
            // 
            this.Wybor_Parity.DisplayMember = "BRAK";
            this.Wybor_Parity.FormattingEnabled = true;
            this.Wybor_Parity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None"});
            this.Wybor_Parity.Location = new System.Drawing.Point(56, 97);
            this.Wybor_Parity.Name = "Wybor_Parity";
            this.Wybor_Parity.Size = new System.Drawing.Size(147, 21);
            this.Wybor_Parity.TabIndex = 23;
            // 
            // Wybor_Data
            // 
            this.Wybor_Data.DisplayMember = "BRAK";
            this.Wybor_Data.FormattingEnabled = true;
            this.Wybor_Data.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.Wybor_Data.Location = new System.Drawing.Point(56, 71);
            this.Wybor_Data.Name = "Wybor_Data";
            this.Wybor_Data.Size = new System.Drawing.Size(147, 21);
            this.Wybor_Data.TabIndex = 22;
            // 
            // Wybor_Baud
            // 
            this.Wybor_Baud.DisplayMember = "BRAK";
            this.Wybor_Baud.FormattingEnabled = true;
            this.Wybor_Baud.Items.AddRange(new object[] {
            "9600",
            "4800"});
            this.Wybor_Baud.Location = new System.Drawing.Point(56, 43);
            this.Wybor_Baud.Name = "Wybor_Baud";
            this.Wybor_Baud.Size = new System.Drawing.Size(147, 21);
            this.Wybor_Baud.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Stop:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Parity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Data:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Baud:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Textbox_Odbior);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Send);
            this.groupBox1.Controls.Add(this.Wiadomosc_Okno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 203);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Komunikacja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.scrollbar2_wartosc);
            this.groupBox2.Controls.Add(this.scrollbar1_wartosc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox12);
            this.groupBox2.Controls.Add(this.hScrollBar2);
            this.groupBox2.Controls.Add(this.hScrollBar1);
            this.groupBox2.Controls.Add(this.pictureBox11);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 368);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ROBOT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Człon 6:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Człon 5:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Człon 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Człon 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Człon 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Człon 1:";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Enabled = false;
            this.pictureBox12.Image = global::WindowsFormsApp17.Properties.Resources.lewo;
            this.pictureBox12.Location = new System.Drawing.Point(334, 327);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(41, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Enabled = false;
            this.pictureBox11.Image = global::WindowsFormsApp17.Properties.Resources.lewo;
            this.pictureBox11.Location = new System.Drawing.Point(334, 290);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(41, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Enabled = false;
            this.pictureBox10.Image = global::WindowsFormsApp17.Properties.Resources.lewo;
            this.pictureBox10.Location = new System.Drawing.Point(334, 252);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Enabled = false;
            this.pictureBox9.Image = global::WindowsFormsApp17.Properties.Resources.lewo;
            this.pictureBox9.Location = new System.Drawing.Point(334, 213);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Enabled = false;
            this.pictureBox8.Image = global::WindowsFormsApp17.Properties.Resources.lewo;
            this.pictureBox8.Location = new System.Drawing.Point(334, 175);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Enabled = false;
            this.pictureBox7.Image = global::WindowsFormsApp17.Properties.Resources.lewo;
            this.pictureBox7.Location = new System.Drawing.Point(334, 137);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Enabled = false;
            this.pictureBox6.Image = global::WindowsFormsApp17.Properties.Resources.strzałka;
            this.pictureBox6.Location = new System.Drawing.Point(381, 327);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Image = global::WindowsFormsApp17.Properties.Resources.strzałka;
            this.pictureBox5.Location = new System.Drawing.Point(381, 289);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::WindowsFormsApp17.Properties.Resources.strzałka;
            this.pictureBox4.Location = new System.Drawing.Point(381, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::WindowsFormsApp17.Properties.Resources.strzałka;
            this.pictureBox3.Location = new System.Drawing.Point(381, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::WindowsFormsApp17.Properties.Resources.strzałka;
            this.pictureBox2.Location = new System.Drawing.Point(381, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::WindowsFormsApp17.Properties.Resources.strzałka;
            this.pictureBox1.Location = new System.Drawing.Point(381, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(318, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Otwórz/Zamknij Chwytak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scrollbar1_wartosc
            // 
            this.scrollbar1_wartosc.Enabled = false;
            this.scrollbar1_wartosc.Location = new System.Drawing.Point(205, 71);
            this.scrollbar1_wartosc.Name = "scrollbar1_wartosc";
            this.scrollbar1_wartosc.Size = new System.Drawing.Size(39, 20);
            this.scrollbar1_wartosc.TabIndex = 15;
            this.scrollbar1_wartosc.TextChanged += new System.EventHandler(this.scrollbar1_wartosc_TextChanged);
            // 
            // scrollbar2_wartosc
            // 
            this.scrollbar2_wartosc.Enabled = false;
            this.scrollbar2_wartosc.Location = new System.Drawing.Point(205, 105);
            this.scrollbar2_wartosc.Name = "scrollbar2_wartosc";
            this.scrollbar2_wartosc.Size = new System.Drawing.Size(39, 20);
            this.scrollbar2_wartosc.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(141, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Jog Speed";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Jog Increment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WyborPortu);
            this.Controls.Add(this.Łączenie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Łączenie.ResumeLayout(false);
            this.Łączenie.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WyborPortu;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox Wiadomosc_Okno;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.TextBox Textbox_Odbior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Łączenie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Wybor_Stop;
        private System.Windows.Forms.ComboBox Wybor_Parity;
        private System.Windows.Forms.ComboBox Wybor_Data;
        private System.Windows.Forms.ComboBox Wybor_Baud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox scrollbar1_wartosc;
        private System.Windows.Forms.TextBox scrollbar2_wartosc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

