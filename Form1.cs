using System;
using System.Windows.Forms;

namespace Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(urlTextBox.Text))
            {
                radioPlayer.URL = urlTextBox.Text;
                radioPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Введите URL радиостанции!");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            radioPlayer.Ctlcontrols.stop();
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}