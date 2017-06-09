using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feynman
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void bt01_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            
                Tela2 frms = new Tela2();
                frms.ShowDialog();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos frms = new Alunos();
            frms.ShowDialog();
        }
    }
}


