using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ru_ssian_roulette
{
    public partial class Main : Form
    {
        spin main = new spin();




    
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_load(object sender, EventArgs e)
        {
            // this code display gif
            Image img = Image.FromFile(@"C:\Users\AJAYPAL\source\repos\ru_ssian roulette\Res\load.gif");
            pictureBox1.Image = img;
            // this code play sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\AJAYPAL\source\repos\ru_ssian roulette\Res\load.wav");
            player.Play();
            main.load = 1;

            btn_spin.Enabled = true;
            btn_load.Enabled = false;
        }

        private void button_spin(object sender, EventArgs e)
        { // this code display gif
            Image img = Image.FromFile(@"C:\Users\AJAYPAL\source\repos\ru_ssian roulette\Res\spin.gif");
            pictureBox1.Image = img;
            // this code play sound
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\AJAYPAL\source\repos\ru_ssian roulette\Res\spin.wav");
            player.Play();
            Random rnd = new Random();
            //this code pick random number between 1-7.
            main.Spin = rnd.Next(1, 7);

            btn_shoot.Enabled = true;
            btn_spin.Enabled = false;

        }

        private void button_shoot(object sender, EventArgs e)
        {
            main.shoot = 0;
            Image img = Image.FromFile(@"C:\Users\AJAYPAL\source\repos\ru_ssian roulette\Res\shoot.gif");
            pictureBox1.Image = img;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\AJAYPAL\source\repos\ru_ssian roulette\Res\shoot.wav");
            player.Play();
            do
            {
                if (main.shoot == 0 && main.load == main.Spin)
                {

                    //below codes pop up message on the screen.
                    MessageBox.Show("you won and your score is 10");
                    main.shoot = 3;
                    btn_shoot.Enabled = false;
                    
                }
                else if (main.shoot == 1 && main.load == main.Spin)
                {
                    MessageBox.Show("you won and your score is 5");
                    main.shoot = 3;
                    main.reload = main.reload - 1;
                   

                }
                else if (main.shoot == 2)
                {
                    MessageBox.Show("you loose");
                    main.shoot = 3;
                    main.reload = main.reload - 1;

                }
                else
                {
                    main.shoot++;

                    spin s = new spin();
                    main.Spin = s.sp(main.Spin);
                }
            }
            while (main.shoot <= 2);

            if (main.reload == 0)
            {
                btn_shoot.Enabled = false;
                btn_load.Enabled = true;
                btn_spin.Enabled = true;
                main.reload = 2;
            }


        }

        private void button_play(object sender, EventArgs e)
        {
            (new Main()).Show();
            this.Hide();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }

       

}

