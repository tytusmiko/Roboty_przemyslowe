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
using System.Threading;


namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        string Wiadomosc="";
        string Odbior = "";
        bool Stan_Chwytaka;

        public Form1()
        {
            InitializeComponent();

            //
            // Przypisanie i dodanie do listy wyboru dostepnych portów
            //
            String[] ports = SerialPort.GetPortNames(); 
            foreach (String x in ports)
            WyborPortu.Items.Add(x);
        }

        //
        // Otwieranie i zmiana portow
        //

        private void Button_Connect_Click(object sender, EventArgs e) 
        {
            if ((serialPort1.IsOpen) && (WyborPortu.Text != serialPort1.PortName)) // zamknięcie i zmiana portu
            {
                serialPort1.Close();
                serialPort1.PortName = WyborPortu.Text;
                serialPort1.Open();

                serialPort1.WriteLine("WH");
            }

            //
            // otwarcie nowego (pierwszego) portu oraz udostępnienie przycisków i scrollbarów
            //

            if ((!serialPort1.IsOpen) && (serialPort1.PortName == "BRAK") && (WyborPortu.Text != "")) // pierwsze przypisanie portu. domyślnie serialPort ustawiony jako "BRAK" 
            {
                serialPort1.PortName = WyborPortu.Text;
                serialPort1.Open();

                //
                // "aktywacja" scrollbarów i przycisku chwytaka
                //

                button1.Enabled = true;

                hScrollBar1.Enabled = true;
                hScrollBar2.Enabled = true;

                //
                // "aktywacja" strzałek
                //

                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                

                serialPort1.WriteLine("WH");

                // Stan_Chwytaka = ?????????????????????????????

            }
            else if (WyborPortu.Text == "") // error
            {
                errorProvider1.SetError(WyborPortu, "Wybierz port!");
            }
            
        }

        //
        // wiadomosc do ramki
        //

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        //
        // Wysylanie wiadomosci z textboxa do portu
        //

        private void Send_Click(object sender, EventArgs e)
        {
            serialPort1.Write(Wiadomosc_Okno.Text+'\r');
        }

        //
        // Odczytywanie wiadomosci z robota
        //

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Odbior = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        //
        // Wpisanie wiadomosci z robota do textboxa
        //

        private void ShowData(object sender, EventArgs e)
        {
            Textbox_Odbior.Text += Odbior + '\r'+'\n'; // w robocie bez "\n"
        }

        // 
        // Poruszanie strzałkami -> MJ (Move Joint)
        //

        private void pictureBox1_Click(object sender, EventArgs e) // strzalki -> event -> click.  TRZEBA USTAWIC WSZYSTKIE EVENTY!
        {
            serialPort1.Write("DJ 1, "+Convert.ToString(hScrollBar2.Value)+'\r' + "WH\r"); // wyslanie ruchu w prawo (z plusem) na pierwszy czlon i odbior polozenia
            // Textbox_Odbior.Text += "DJ 1, " + Convert.ToString(hScrollBar2.Value) + '\r' + "działa 1\r\n";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 2, " + Convert.ToString(hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w prawo (z plusem) na drugi czlon
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 3, " + Convert.ToString(hScrollBar2.Value) + '\r' + "WH\r");// wyslanie ruchu w prawo...
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 4, " + Convert.ToString(hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w prawo...
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 5, " + Convert.ToString(hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w prawo...
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 6, " + Convert.ToString(hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w prawo...
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 1, " + Convert.ToString(-hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w lewo (z minusem) na pierwszy czlon
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 2, " + Convert.ToString(-hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w lewo (z minusem) na drugi czlon
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 3, " + Convert.ToString(-hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w lewo...
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 4, " + Convert.ToString(-hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w lewo...
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 5, " + Convert.ToString(-hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w lewo...
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DJ 6, " + Convert.ToString(-hScrollBar2.Value) + '\r' + "WH\r"); // wyslanie ruchu w lewo...
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbar1_wartosc.Text = Convert.ToString(hScrollBar1.Value) + '%';
        }

        private void scrollbar1_wartosc_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            scrollbar2_wartosc.Text = Convert.ToString(hScrollBar2.Value) + '%';
        }

        private void Textbox_Odbior_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chwytak otwarty) 
            {
                serialPort1.Write("GC\rWH\r");
                // Stan_Chwytaka = ?????????????????????????????
            }
            else 
            {
                serialPort1.Write("GO\rWH\r");
                // Stan_Chwytaka = ?????????????????????????????
            }
        }
    }
}
