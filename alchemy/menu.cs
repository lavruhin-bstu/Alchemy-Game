using System;
using System.Windows.Forms;

namespace alchemy
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();

            gameWindow.Show();

        }

        private void LoadAbout(object sender, EventArgs e)
        {
            About aboutWindow = new About();

            aboutWindow.Show();
        }

        private void nameGame_Click(object sender, EventArgs e)
        {

        }
    }
}
