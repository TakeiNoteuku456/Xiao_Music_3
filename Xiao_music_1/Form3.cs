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
    public partial class Form3 : Form
    {
        Thread fdp;
        public Form3()
        {
            InitializeComponent();
        }
        private void novoForm()
        {
            Application.Run(new Form2());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            fdp = new Thread(novoForm);
            fdp.SetApartmentState(ApartmentState.STA);
            fdp.Start();
        }
    }
}
