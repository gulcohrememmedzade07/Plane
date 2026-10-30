using System.Media;

namespace Plane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "ON/OFF";
            pictureBox2.Visible = false;
        }
        bool isOn = false;
        bool isGas = false;
        bool isBreak = false;
        SoundPlayer sp = new SoundPlayer("isikacmakapamasesi.wav");
        SoundPlayer spEnis = new SoundPlayer("inishazirliklari.wav");
        SoundPlayer spTurbulans = new SoundPlayer("turbulans.wav");
        SoundPlayer spKemer = new SoundPlayer("kemerler.wav");
        SoundPlayer spTesekkur = new SoundPlayer("tesekkurler.wav");
        SoundPlayer spBeep = new SoundPlayer("beep.wav");

        private void button1_Click(object sender, EventArgs e)
        {
            isOn = !isOn;

            if (isOn)
            {
                button1.Text = "OFF";
                button1.BackColor = Color.Blue;
                pictureBox2.Visible = true;
            }
            else
            {
                button1.Text = "ON";
                button1.BackColor = Color.Yellow;
                pictureBox2.Visible = false;
                sp.Stop();
                isGas = false;
                isBreak = false;
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                sp.Play();
                isGas = true;
                isBreak = false;
                timer2.Stop();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Əvvəlcə ON/OFF düyməsini yandırın!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isOn && isGas == true && pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);

                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 2);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                isGas = false;
                isBreak = true;
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isOn && isBreak == true && pictureBox1.Location.Y <= 400)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);

                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 2);
            }
            else
            {
                timer2.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                spEnis.Play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                spTurbulans.Play();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                spKemer.Play();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                spTesekkur.Play();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                spBeep.Play();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
