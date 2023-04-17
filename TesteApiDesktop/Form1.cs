using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteApiDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaPage vendaPage = new VendaPage();
            vendaPage.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevolucaoPage devolucaoPage = new DevolucaoPage();
            devolucaoPage.Show();   
        }
    }
}
