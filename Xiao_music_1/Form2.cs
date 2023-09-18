using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Xiao_music_1
{
    public partial class Form2 : Form
    {
        SoundPlayer SomMenuUndertale;
        Thread fdp;
        public Form2()
        {
            InitializeComponent();
            SomMenuUndertale = new SoundPlayer(); // Crie uma instância do SoundPlayer
            SomMenuUndertale.SoundLocation = @"C:\Users\CJ3016757\Downloads\Undertale OST 093 - Menu (Full).wav"; // Defina o caminho do arquivo de áudio
            SomMenuUndertale.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SomMenuUndertale.Stop();
            this.Close();
            fdp = new Thread(novoForm);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form1());
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            SomMenuUndertale.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SomMenuUndertale.Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            fdp = new Thread(novoForm1);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }
        private void novoForm1()
        {
            Application.Run(new Form3());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
