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
    public partial class Tela2 : Form
    {
        string  texto1t1, texto1t2, texto2t2, texto3t2, texto4t2;
        
        public Tela2()
        {
            InitializeComponent();
           
        }       

        private void btn1_t1_Click(object sender, EventArgs e)
        {
            /*TELA 1 Gravar*/
            texto1t1 = textBox1.Text;
            MessageBox.Show("Salvo com sucesso. Vamos lá, você consegue !");
            textBox1.Clear();
        }

        private void Tela1_Load(object sender, EventArgs e)
        {

        }
        /*Tela 2 */
        private void btn2_t1_Click(object sender, EventArgs e)
        {
            btn1_t1.Visible  = false;
            textBox1.Visible = false;
            btn2_t1.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            btn1_t2.Visible = true;
            btn2_t2.Visible = true;
            text1_t2.Visible = true;
            text2_t2.Visible = true;
            text3_t2.Visible = true;
            text4_t2.Visible = true;
            label4.Visible = true;

        }
        /*Tela 3 */
        private void btn2_t2_Click(object sender, EventArgs e)
        {
            btn1_t2.Visible = false;
            btn2_t2.Visible = false;
            text1_t2.Visible = false;
            text2_t2.Visible = false;
            text3_t2.Visible = false;
            text4_t2.Visible = false;
            label4.Visible = false;
            label6.Visible = true;
            pictureBox1.Visible = true;
            btn1_t3.Visible = true; /*Memorizando*/
            btn2_t3.Visible = true;
            label5.Visible = true;

        }
        
        private void btn1_t3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.feliz;
           label5.Text = texto1t2;
            btn1_t3.Visible = false; /*Memorizando*/
            button1.Visible = true; /*Memorizando*/


        }

        /*final da tela3 - chamado a tela 4*/
        private void btn2_t3_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            pictureBox1.Visible = false;
            btn1_t3.Visible = false;
            btn2_t3.Visible = false;/*Memorizando*/
            label5.Visible = false;/*Memorizando*/
            btn2_t4.Visible = true;
            lb51.Visible = true;
            lb52.Visible = true;
            lb53.Visible = true;
            lb54.Visible = true;
            lb55.Visible = true;
            lb56.Visible = true;
            lb57.Visible = true;
            button1.Visible = false; /*Memorizando*/
            button2.Visible = false; /*Memorizando*/
            button3.Visible = false; /*Memorizando*/
            lb56.Text = texto4t2; /*Label Tela4*/
            lb55.Text = texto1t2;/*Label Tela4*/
            lb54.Text = texto2t2;/*Label Tela4*/
            lb52.Text = texto1t1;/*Label Tela4*/
            lb57.Text = texto3t2;/*Label Tela4*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.triste;
            label5.Text = texto2t2;
            button1.Visible = false; /*Memorizando*/
            button2.Visible = true; /*Memorizando*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.duvida;
            label5.Text = texto3t2;
            button2.Visible = false; /*Memorizando*/
            button3.Visible = true; /*Memorizando*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.normal;
            label5.Text = texto4t2;
            button3.Visible = false; /*Memorizando*/
            btn1_t3.Visible = true; /*Memorizando*/

        }

      /*Tela 2 topicos*/
        private void btn1_t2_Click(object sender, EventArgs e)
        {/*tela2  Gravar  */
            texto1t2 = text1_t2.Text;
            texto2t2 = text2_t2.Text;
            texto3t2 = text3_t2.Text;
            texto4t2 = text4_t2.Text;

            MessageBox.Show("Salvo com sucesso. Estamos quase lá !");
            text1_t2.Clear();
            text2_t2.Clear();
            text3_t2.Clear();
            text4_t2.Clear();

        }
        private void text2_t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_t4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PARABÉNS!");
            Application.Exit();
        }

        private void lb56_Click(object sender, EventArgs e)
        {
            
        }

        private void lb55_Click(object sender, EventArgs e)
        {
            
        }

        private void lb54_Click(object sender, EventArgs e)
        {
            
        }

        private void lb53_Click(object sender, EventArgs e)
        {
           
        }

        private void lb52_Click(object sender, EventArgs e)
        {
            
        }

        private void lb51_Click(object sender, EventArgs e)
        {

        }

        private void lb57_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*TELA 1 - QUal assunto deseja dominar*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
