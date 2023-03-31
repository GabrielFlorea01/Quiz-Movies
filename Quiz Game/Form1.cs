using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Joc_Quiz_BUN
{
    public partial class Form1 : Form
    {
        //variabile

        int RaspunsCorect;
        int NumarIntrebare = 1;
        int scor;
        int procentaj;
        int TotalIntrebari;

        public Form1()
        {
            InitializeComponent();
            Intreaba(NumarIntrebare);
            TotalIntrebari = 8;
        }

        

        private void VerifRaspuns(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
           
            if (buttonTag == RaspunsCorect)
            {
                scor++;
            }

            if (NumarIntrebare == TotalIntrebari)
            {
                procentaj = (int)Math.Round((double)(scor * 100) / TotalIntrebari);

                MessageBox.Show(
                   "Quiz completat!" + Environment.NewLine + "Ai raspuns la " + scor + " intrebari corecte." +
                    Environment.NewLine + "Procentajul tau total este " + procentaj + "%" + Environment.NewLine +
                   "Apasa OK sa joci din nou");

                scor = 0;
                NumarIntrebare = 0;
                Intreaba(NumarIntrebare);

                File.AppendAllText("Useri.txt", "-" + procentaj + "%  ");

                Form2 a = new Form2();
                a.Show();
                Visible = false;
            }

            NumarIntrebare++;
            Intreaba(NumarIntrebare);
        }

        private void Intreaba(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.titanic;


                    lblQ.Text = "Aceasta imagine face parte din filmul...";

                    button1.Text = "Titanic";
                    button2.Text = "O iubire de neuitat";
                    button3.Text = "Titanic vals";
                    button4.Text = "Prometheus";

                    RaspunsCorect = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Avatar;

                    lblQ.Text = "Din ce pelicula regizata de faimosul James Cameron face parte aceasta scena ?";

                    button1.Text = "Terminator 2";
                    button2.Text = "Avatar";
                    button3.Text = "Aliens";
                    button4.Text = "Rambo";

                    RaspunsCorect = 2;

                    break;



                case 3:
                    pictureBox1.Image = Properties.Resources.Singur_Acasa;

                    lblQ.Text = "Acest baiat este lasat in urma de parintii sai in filmul...";

                    button1.Text = "Inteligenta artificiala";
                    button2.Text = "Calotarie in centrul Pamantului";
                    button3.Text = "Singur Acasa";
                    button4.Text = "Richie Rich";

                    RaspunsCorect = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Nasul;

                    lblQ.Text = "Acest personaj celebru apare in filmul...";

                    button1.Text = "Goodfellas(Baieti buni)";
                    button2.Text = "Drumul spre pierzanie";
                    button3.Text = "The Godfather(Nașul)";
                    button4.Text = "Scarface";

                    RaspunsCorect = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Lotr;

                    lblQ.Text = "Aceasta scena face parte din trilogia...";

                    button1.Text = "Inapoi in viitor";
                    button2.Text = "X-men";
                    button3.Text = "Spider Man";
                    button4.Text = "Stapanul inelelor(Lord of the rings)";

                    RaspunsCorect = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Harry_potter;

                    lblQ.Text = "Aceasta batalie a avut loc in prima parte a seriei... ";

                    button1.Text = "Cronicile din Narnia";
                    button2.Text = "Harry Potter";
                    button3.Text = "Transformers";
                    button4.Text = "Academia Vampirilor";

                    RaspunsCorect = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.Star_Wars;

                    lblQ.Text = "Din ce film este desprinsa aceasta scena istorica?";

                    button1.Text = "Star Trek";
                    button2.Text = "Spaceballs";
                    button3.Text = "Star Wars";
                    button4.Text = "Lost in Space";

                    RaspunsCorect = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.Gladiatorul;

                    lblQ.Text = "Maximus este personajul principal din filmul... ";

                    button1.Text = "Gladiatorul";
                    button2.Text = "Legiunea straina";
                    button3.Text = "Troia";
                    button4.Text = "300 Eroii de la Termopile";

                    RaspunsCorect = 1;

                    break;

                    
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
