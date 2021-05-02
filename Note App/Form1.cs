using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Note_App
{
    public partial class CumButton : Form
    {
        public CumButton()
        {
            InitializeComponent();
        }

        private void cumbttn_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\bmice\Desktop\Note App\Note App/killsound-note.wav");
            splayer.Play();
        }
    }
}
