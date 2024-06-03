using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
namespace Gestion__etudetion
{
    public partial class Form1 : Form
    {
        String nom, prenom, num, decision;

        Double Moyeen, Somme;
        Double[] note = new double[50];
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text= "gestion_de_etudent " +" TSDR "+" TSDI  " + DateTime.Now.Date;

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nom =textBox4.Text;
            num =textBox1.Text;
            prenom=textBox2.Text;
            Somme=00.00;
            Moyeen=00.00;
            for (i =0; i < 4; i++)
            {
                note[i]=double.Parse(Interaction.InputBox("Entrer les notes de etudent"));
                listBox1.Items.Add(note[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nom=textBox4.Text;
            num=textBox1.Text;
            prenom=textBox2.Text;

            Somme=00.00;
            Moyeen=00.00;
            decision=" ";
            textBox5.ResetText();
            textBox7.ResetText();
            textBox6.ResetText();
            listBox1.Items.Clear();

            nom =textBox4.Text;
            num =textBox1.Text;
            prenom=textBox2.Text;
            for (i =0; i < 4; i++)
            {
                note[i]=double.Parse(Interaction.InputBox("Entrer les notes de etudents"));
                listBox1.Items.Add(note[i]);

            }
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Somme= 0;
            
            for (i=0; i<=4; i++)
            {
                Somme += note[i];
              
            }
            textBox5.Text = Somme.ToString();
            Moyeen= Somme/4;
            textBox7.Text = Moyeen.ToString();

            if (Moyeen >=10)
            {
                decision= "validé";
            }
            else { decision= "rejeté"; }

            textBox6.Text = decision.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

