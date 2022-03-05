using System;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace alchemy
{
    public partial class Form1 : Form
    {
        private object currentObject = null;
        public Form1()
        {
            InitializeComponent();
            //  this.MouseMove += new MouseEventHandler(mouseEvent);
            //this.MouseClick += new MouseEventHandler(mouseClick);

        }

        

        string res;
        int counter = 0;
        int winGames = 0;
        int lastX;
        int lastY;
        /// <summary>
        /// //////////////////////////// по звука жизнь небо клетка
        /// </summary>
        private void FinalGames()
        {
            if (winGames==24)
            { 
                MessageBox.Show("Вы прошли игру!");
            SoundPlayer sound = new SoundPlayer(Properties.Resources.fanfaryi);
            sound.Play();}

        }

        //private void mouseClick(object sender, MouseEventArgs 1
        //{
        //    int x=0;
        //    int y=0;
        //    if (e.Button.ToString() == "Right")
        //    {

        //       // currentObject.GetType().GetProperty("Location").SetValue(currentObject, new Point(Cursor.Position.X, Cursor.Position.Y));
        //        currentObject = null;
        //    }

        //}

        public static T Clone<T>(T controlToClone) where T : Control
        {
            T instance = Activator.CreateInstance<T>();

            PropertyInfo[] props = controlToClone.GetType().GetProperties();

            foreach (PropertyInfo pi in props)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }

       




        private void Form1_Load(object sender, EventArgs e)
        {
            lastX = waterB.Location.X;
            lastY = waterB.Location.Y;

        }

        public void ScrollToBottom(Panel p)
        {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom })
            {
                p.VerticalScroll.Value = 0;

            }
        }

        private void fireB_Click(object sender, EventArgs e)
        {


            counter++;

            currentObject = sender;
            if (counter == 1)
            {

                res = (sender as Button).Text + "+";
                label3.Text = res;

            }
            else
            {
                res += (sender as Button).Text;
                label3.Text = res;

                counter = 0;
                ScrollToBottom(panel1);
                CheckRec(label3.Text);
                FinalGames();
            }

        }
        private void CheckRec(string res)
        {


            if (label3.Text == "Воздух+Воздух" && (windB.Visible == false))
            {
                windB.Visible = true;
                windB.Location = new Point(lastX, lastY + 106);
                lastY = windB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.wind );
                sound.Play(); winGames++;
                label3.Text = windB.Text;

            }





            if ((label3.Text == "Огонь+Земля" || label3.Text == "Земля+Огонь") && (lavaB.Visible == false))
            {
                lavaB.Location = new Point(lastX, lastY + 106);
                lavaB.Visible = true;
                lastX = lavaB.Location.X;
                lastY = lavaB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.lava );
                sound.Play(); winGames++; ;
                label3.Text=lavaB.Text;

            }




            if ((label3.Text == "Огонь+Воздух" || label3.Text == "Воздух+Огонь") && (energyB.Visible == false))
            {
                energyB.Visible = true;
                energyB.Location = new Point(lastX, lastY + 106);
                lastX = energyB.Location.X;
                lastY = energyB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.energy );
                sound.Play(); winGames++; ;
                label3.Text=energyB.Text;
            }



            if ((label3.Text == "Земля+Воздух" || label3.Text == "Воздух+Земля") && (dustB.Visible == false))
            {
                dustB.Visible = true;
                dustB.Location = new Point(lastX, lastY + 106);
                lastY = dustB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.pes );
                sound.Play(); winGames++;
                label3.Text = dustB.Text;

            }



            if ((label3.Text == "Огонь+Вода" || label3.Text == "Вода+Огонь") && (steamB.Visible == false))
            {
                steamB.Visible = true;
                steamB.Location = new Point(lastX, lastY + 106);
                lastX = steamB.Location.X;
                lastY = steamB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.steam );
                sound.Play(); winGames++; 
                label3.Text=steamB.Text;
            }


            if ((label3.Text == "Земля+Земля") && (BarlB.Visible == false))
            {
                BarlB.Visible = true;
                BarlB.Location = new Point(lastX, lastY + 106);
                lastY = BarlB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.energy );
                sound.Play(); winGames++;
                label3.Text=BarlB.Text;
            }



            if ((label3.Text == "Земля+Вода" || label3.Text == "Вода+Земля") && (bolotoB.Visible == false))
            {
                bolotoB.Visible = true;
                bolotoB.Location = new Point(lastX, lastY + 106);
                lastY = bolotoB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.bolot );
                sound.Play(); winGames++; 
                label3.Text=bolotoB.Text;
            }

            if ((label3.Text == "Вода+Вода") && (lakeB.Visible == false))
            {
                lakeB.Visible = true;

                lakeB.Location = new Point(lastX, lastY + 106);
                lastY = lakeB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.lake );
                sound.Play(); winGames++;
                label3.Text=lakeB.Text;
            }

            if ((label3.Text == "Энергия+Воздух" || label3.Text == "Воздух+Энергия") && (burB.Visible == false))
            {
                burB.Visible = true;
                burB.Location = new Point(lastX, lastY + 106);
                lastY = burB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.wind );
                sound.Play(); winGames++; 
                label3.Text=burB.Text;
            }

            if ((label3.Text == "Пар+Воздух" || label3.Text == "Воздух+Пар") && (skyB.Visible == false))
            {
                skyB.Visible = true;
                skyB.Location = new Point(lastX, lastY + 106);
                lastY = skyB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.sky );
                sound.Play(); winGames++; 
                label3.Text=skyB.Text;
            }

            if ((label3.Text == "Огонь+Пыль" || label3.Text == "Пыль+Огонь") && (peplB.Visible == false))
            {
                peplB.Visible = true;
                peplB.Location = new Point(lastX, lastY + 106);
                lastY = peplB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.pepel );
                sound.Play(); winGames++; 
                label3.Text=peplB.Text;
            }
            if ((label3.Text == "Вода+Пыль" || label3.Text == "Пыль+Вода") && (dirtB.Visible == false))
            {
                dirtB.Visible = true;
                dirtB.Location = new Point(lastX, lastY + 106);
                lastY = dirtB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.dirt );
                sound.Play(); winGames++; 
                label3.Text=dirtB.Text;
            }
            if ((label3.Text == "Энергия+Болото" || label3.Text == "Болто+Энергия") && (lifeB.Visible == false))
            {
                lifeB.Visible = true;
                lifeB.Location = new Point(lastX, lastY + 106);
                lastY = lifeB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.bolot );
                sound.Play(); winGames++; 
                label3.Text=lifeB.Text;
            }
            if ((label3.Text == "Энергия+Вода" || label3.Text == "Вода+Энергия") && (alcB.Visible == false))
            {
                alcB.Visible = true;
                alcB.Location = new Point(lastX, lastY + 106);
                lastY = alcB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.spirt );
                sound.Play(); winGames++; 
                label3.Text=alcB.Text;
            }
            if ((label3.Text == "Лава+Давление" || label3.Text == "Давление+Лава") && (vulcanB.Visible == false))
            {
                vulcanB.Visible = true;
                vulcanB.Location = new Point(lastX, lastY + 106);
                lastY = vulcanB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.vulcan );
                sound.Play(); winGames++; 
                label3.Text=vulcanB.Text;
            }
            if ((label3.Text == "Лава+Вода" || label3.Text == "Вода+Лава") && (rockB.Visible == false))
            {
                rockB.Visible = true;
                rockB.Location = new Point(lastX, lastY + 106);
                lastY = rockB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.rock );
                sound.Play(); winGames++; 
                label3.Text=rockB.Text;
            }
            if ((label3.Text == "Воздух+Камень" || label3.Text == "Камень+Воздух") && (pesB.Visible == false))
            {
                pesB.Visible = true;
                pesB.Location = new Point(lastX, lastY + 106);
                lastY = pesB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.pes );
                sound.Play(); winGames++; 
                label3.Text=pesB.Text;
            }
            if ((label3.Text == "Огонь+Камень" || label3.Text == "Камень+Огонь") && (ironB.Visible == false))
            {
                ironB.Visible = true;
                ironB.Location = new Point(lastX, lastY + 106);
                lastY = ironB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.iron );
                sound.Play(); winGames++; 
                label3.Text=ironB.Text;
            }
            if ((label3.Text == "Вода+Спирт" || label3.Text == "Спирт+Вода") && (vodkaB.Visible == false))
            {
                vodkaB.Visible = true;
                vodkaB.Location = new Point(lastX, lastY + 106);
                lastY = vodkaB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.vodka );
                sound.Play(); winGames++; 
                label3.Text=vodkaB.Text;
            }
            if ((label3.Text == "Земля+Жизнь" || label3.Text == "Жизнь+Земля") && (semenB.Visible == false))
            {
                semenB.Visible = true;
                semenB.Location = new Point(lastX, lastY + 106);
                lastY = semenB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.the_semen);
                sound.Play(); winGames++;
                label3.Text=semenB.Text;
            }

            if ((label3.Text == "Камень+Жизнь" || label3.Text == "Жизнь+Камень") && (eggB.Visible == false))
            {
                eggB.Visible = true;
                eggB.Location = new Point(lastX, lastY + 106);
                lastY = eggB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.egg );
                sound.Play(); winGames++; ;
                label3.Text=eggB.Text;
            }
            if ((label3.Text == "Вода+Жизнь" || label3.Text == "Жизнь+Вода") && (vodB.Visible == false))
            {
                vodB.Visible = true;
                vodB.Location = new Point(lastX, lastY + 106);
                lastY = vodB.Location.Y;
               SoundPlayer sound = new SoundPlayer(Properties.Resources.bolot );
               sound.Play(); winGames++; ;
                label3.Text=vodB.Text;
            }
            if ((label3.Text == "Болото+Жизнь" || label3.Text == "Жизнь+Болото") && (vodB.Visible == false))
            {
                bakB.Visible = true;
                bakB.Location = new Point(lastX, lastY + 106);
                lastY = bakB.Location.Y;
                  SoundPlayer sound = new SoundPlayer(Properties.Resources.bak );
                 sound.Play(); winGames++; 
                label3.Text=bakB.Text;
            }
            if ((label3.Text == "Воздух+Яйцо" || label3.Text == "Яйцо+Воздух") && (birdB.Visible == false))
            {
                birdB.Visible = true;
                birdB.Location = new Point(lastX, lastY + 106);
                lastY = birdB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.bird );
                sound.Play(); winGames++; 
                label3.Text=birdB.Text;
            }
            if ((label3.Text == "Бактерия+Бактерия") && (qB.Visible == false))
            {
                qB.Visible = true;
                qB.Location = new Point(lastX, lastY + 106);
                lastY = qB.Location.Y;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.q );
                sound.Play(); winGames++; 
                label3.Text = qB.Text;
            }
        }



        private void waterB_Click(object sender, EventArgs e)
        {
            //Button newBut = Clone(waterB);
            //if (is_free)
            //{
            //    newBut.Location = new Point(400, 400);
            //    is_free = false;
            //}
            //else
            //    newBut.Location = new Point(400, 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            windB.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void creatB_Click(object sender, EventArgs e)
        {

        }

        private void mixB_Click(object sender, EventArgs e)
        {
            label3.Text = null;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._1);
            simpleSound.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

