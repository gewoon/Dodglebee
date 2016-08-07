using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        bool right; //Meeste gegevens worden aan het begin van het programma al gegeven.
        bool left;
        bool up;
        bool down;
        int Speed = 4;//snelheid waarin je beweegt
        bool started = false;
        Random num = new Random();//Maakt randomizer (kiest een nummer tussen 2 gegeven nummers)
        int count = 0;//score
        bool crenable = false;
        int credits;//tijdelijke saldo (slaat niet op)
        

        public Form1()
        {            
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "Credits: " + Dodglebee.Properties.Settings.Default.Credits; //Update credit saldo.
            SoundPlayer paulp = new SoundPlayer(Dodglebee.Properties.Resources.Splittercore_1_); //Laadt leuk muziekje
            if (right == true) { Player.Left += Speed; }//Beweeg speler met bepaalde snelheid(bepaalt door integer "Speed".)
            if (left == true) { Player.Left -= Speed; }
            if (up == true) { Player.Top -= Speed; }
            if (down == true) { Player.Top += Speed; }
            if (Player.Left <= 0) { Player.Left = 1; }//Maakt de randen om het speelveld (je kan er niet buiten)
            if (Player.Top <= 0) { Player.Top = 1; }
            if (Player.Left >= 273) { Player.Left = 272; }
            if (Player.Top >= 277) { Player.Top = 276; }

            if (count == 20)//Activeer Paul-modus.
            {
                count++; //+1 anders ontstaat er een tijdelijke loop
                paulp.Play();//Speel muziekje
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Dodglebee.Properties.Resources.paul;
                pictureBox1.Visible = true;
                Speed = 6;
            }
            if(count== 26)//Deactiveer Paul-modus
            {
                paulp.Stop();
                this.BackgroundImageLayout = ImageLayout.Tile;
                this.BackgroundImage = Dodglebee.Properties.Resources.bg;
                pictureBox1.Visible = false;
                Speed = 4;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)//Kijkt welk pijltje er is is geklikt en beweeg daarop
        {
            if (e.KeyCode == Keys.Space) { started = true; label2.Visible = false; }
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Up) { up = true; }
            if (e.KeyCode == Keys.Down) { down = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)//Stop met bewegen als je niet meer op de toets drukt
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Up) { up = false; }
            if (e.KeyCode == Keys.Down) { down = false; }
        }

        private void alTime_Tick(object sender, EventArgs e)
        {
            if (started == true)
            {
                al1.Top += Speed; //Vijand beweegt van boven naar onder (vanaf score 0).
                if (al1.Top >= 277) { count++; al1.Top = num.Next(-200, -15); al1.Left = num.Next(0, 273); } //Spawn vijand opnieuw als hij de overkant heeft behaald (num.Next(x,x) bepaalt random coordinaten van nieuwe spawnlocatie).

                if (count >= 15)
                {
                    al2.Left += Speed; //Nieuwe vijand beweegt van links naar rechts (vanaf score 16).
                    if (al2.Left >= 273) { al2.Left = num.Next(-200, -15); al2.Top = num.Next(0, 277); }
                }

                if (count >= 30)
                {
                    al3.Top -= Speed; //Nieuwe vijand beweegt van onder naar boven (vanaf score 30)
                    if (al3.Top <= 0) { al3.Top = num.Next(290, 490); al3.Left = num.Next(0, 273); }
                }

                if (count >= 45)
                {
                    al4.Left -= Speed; //Laatste vijand beweegt van rechts naar links (vanaf score 45)
                    if (al4.Left <= 0) { al4.Top = num.Next(0, 277); al4.Left = num.Next(290, 490); }
                }

                if (crenable == true) //Checkt of er een credit mag vallen, zoja gaat het programma verder met lezen
                {
                    Credit.Top += 5; //Laat credit vallen vanaf de top naar beneden met snelheid 5.
                    if(Credit.Top >= 277)//Als credit beneden is zonder gepakt te zijn, laat credit stoppen met vallen en stuur terug naar start positie (niet zichtbaar).
                    {
                        crenable = false;
                        Credit.Location = new Point(num.Next(0,273), -30);
                    }

                }
            }

            if (al1.Bounds.IntersectsWith(Player.Bounds)) //Als vijand jou aantikt, game over! (al1 = vijand 1 etc.)
            {
                Reset();
            }
            if (al2.Bounds.IntersectsWith(Player.Bounds))
            {
                Reset();
            }
            if (al3.Bounds.IntersectsWith(Player.Bounds))
            {
                Reset();
            }
            if (al4.Bounds.IntersectsWith(Player.Bounds))
            {
                Reset();
            }

            if (Credit.Bounds.IntersectsWith(Player.Bounds)) //Als je een credit op pakt
            {
                
                crenable = false; //Laat credit stoppen met vallen
                credits++; //Voegt 1 credit toe aan je saldo (nummer++; voegt altijd +1 toe)
                if (count <= 24) //Speelt geluidje onder score 24 en na 31. (anders raakt het in de war met Paul's geluid)
                {
                    SoundPlayer cre = new SoundPlayer(Dodglebee.Properties.Resources.ka_ching_sound_effect);
                    cre.Play();
                }
                if (count >= 31)
                {
                    SoundPlayer cre = new SoundPlayer(Dodglebee.Properties.Resources.ka_ching_sound_effect);
                    cre.Play();
                }
                Credit.Location = new Point(num.Next(0, 273), -30); //Credit terug naar start positie.
                Dodglebee.Properties.Settings.Default.Credits += 1; //Voegt 1 credit toe aan totale saldo (reset niet).
                Dodglebee.Properties.Settings.Default.Save();
                Dodglebee.Properties.Settings.Default.Reload();
            }

        }

        private void crTime_Tick(object sender, EventArgs e)
        {
            crenable = true;
            //Credits vallen sneller als je score hoger wordt. (count = score)
            if (count == 16) { crTime.Interval = 8500; }
            if (count == 31) { Speed = 5; crTime.Interval = 7000; }
            if (count == 46) { crTime.Interval = 5000; Speed = 7; }
        }

        public void Reset() //Reset het spel en laat bericht + stats zien.
        {
            if(count >= 20)//Als score tussen 20-26 zit, laat Paul game over bericht zien.
            {
                if (count <= 26)
                {
                    PaulNotice.Visible = true;
                    PaulNotice.BringToFront();
                    cancel.Visible = true;
                    cancel.BringToFront();
                    OK.Visible = true;
                    OK.BringToFront();
                    label1.BringToFront();
                }
                else //Als je score iets anders is dan tussen 20-26, normale Macklebee bericht.
                {
                    MackleNotice.Visible = true;
                    MackleNotice.BringToFront();
                    cancel.Visible = true;
                    cancel.BringToFront();
                    OK.Visible = true;
                    OK.BringToFront();
                    label1.BringToFront();
                }
            }
            else //Laat normaal game over bericht zien als score niet boven 20 is.
            {
                MackleNotice.Visible = true;
                MackleNotice.BringToFront();
                cancel.Visible = true;
                cancel.BringToFront();
                OK.Visible = true;
                OK.BringToFront();
                label1.BringToFront();
            }
            label1.Visible = true; //Laat stats zien.
            label1.Text = "Credits earned: "+ credits;
            alTime.Stop();
            pTime.Stop();
            crTime.Stop();

            al1.Location = new Point(13, -30); //Reset coords
            al2.Location = new Point(-30, 260);
            al3.Location = new Point(301, 13);
            al4.Location = new Point(301, 261);
            Player.Location = new Point(140, 140);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();//Sluit applicatie als gebruiker op Cancel heeft geklikt.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();//Applicatie herstart als de gebruiker nog eens wilt spelen. (Moet vanwege problemen met het resetten)
        }
    }
}
