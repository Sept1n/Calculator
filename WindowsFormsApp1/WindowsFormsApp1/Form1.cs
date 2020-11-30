using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Kalkulator : Form
    {

        Double wynik;
        bool przycisniecie = false;
        String znak = "";
        public Kalkulator()
        {
            InitializeComponent();
        }


        private void kasuj_Click(object sender, EventArgs e) // CE
        {
            oblicz.Text = "0";
        }

        private void button_Click(object sender, EventArgs e) // 0-9 i ,
        {
            if ((oblicz.Text == "0") || (przycisniecie))
                oblicz.Clear();


            przycisniecie = false;
            Button b = (Button)sender;
            
            if (b.Text == ",")
            {
                if (!oblicz.Text.Contains(","))
                {
                    oblicz.Text = oblicz.Text + b.Text;
                }
            }
            
            else
                oblicz.Text = oblicz.Text + b.Text;
        }
        private void dzialanie_Click(object sender, EventArgs e) // działania matematyczne
        {
            Button b = (Button)sender;

            if (wynik == 0)
            {
                znak = b.Text;
                wynik = double.Parse(oblicz.Text);
                przycisniecie = true;
                pamiętamy.Text = wynik + "" + znak;
            }
            else
                równa_się.PerformClick();
                przycisniecie = true;
                znak = b.Text;
                pamiętamy.Text = wynik + "" + znak;
        }
        private void kasuj_wszystko_Click(object sender, EventArgs e) //C
        {
            oblicz.Text = "0";
            wynik = 0;
            pamiętamy.Text = "";
        }
        private void ostatecznie_Click(object sender, EventArgs e) //=
        { 
            przycisniecie = true;
            pamiętamy.Text = "";

            if (znak == "+")
            {
                oblicz.Text = (wynik + double.Parse(oblicz.Text)).ToString();
            }
            if (znak == "-")
            {
                oblicz.Text = (wynik - double.Parse(oblicz.Text)).ToString();
            }
            if (znak == "*")
            {
                oblicz.Text = (wynik * double.Parse(oblicz.Text)).ToString();
            }
            if (znak == "/")
            {
                if (oblicz.Text == "0")
                {
                    oblicz.Text = "Pamiętaj cholero, nie dziel przez 0";
                }
                else
                    oblicz.Text = (wynik / double.Parse(oblicz.Text)).ToString();
            }
            
            wynik = 0;
            znak = "";
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    jedynka.PerformClick();
                    break;
                case "2":
                    dwójka.PerformClick();
                    break;
                case "3":
                    trójka.PerformClick();
                    break;
                case "4":
                    czwórka.PerformClick();
                    break;
                case "5":
                    piątka.PerformClick();
                    break;
                case "6":
                    szóstka.PerformClick();
                    break;
                case "7":
                    siódemka.PerformClick();
                    break;
                case "8":
                    ósemka.PerformClick();
                    break;
                case "9":
                    dziewiątka.PerformClick();
                    break;
                case "+":
                    plus.PerformClick();
                    break;
                case "-":
                    minus.PerformClick();
                    break;
                case "*":
                    mnożenie.PerformClick();
                    break;
                case "/":
                    dzielenie.PerformClick();
                    break;
                case "=":
                    równa_się.PerformClick();
                    break;
                case ".":
                    kropka.PerformClick();
                    break;

                default:
                    break;
            }
            
        }
        private void oblicz_TextChanged(object sender, EventArgs e)
        {

        }



        // kalkulator koniec



        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer2.Interval = 100;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
            timer4.Enabled = false;
            timer3.Interval = 100;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            timer4.Interval = 100;
        }

        private void timer2_Tick(object sender, EventArgs e) //czas
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("mm:HH:ss");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("ss:mm:HH");
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e) //motywy
        {
            label2.ForeColor = Color.Red;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //motywy
        {
            pictureBox1.Load("C:\\Users\\Kuba\\Desktop\\Projekt_3_POSK\\aquamarine.jpg");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\Kuba\\Desktop\\Projekt_3_POSK\\tapeta.jpg");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("C:\\Users\\Kuba\\Desktop\\Projekt_3_POSK\\winherop.jpg");
        }

        private void pamiętamy_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
