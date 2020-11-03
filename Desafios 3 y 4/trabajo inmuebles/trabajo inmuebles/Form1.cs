using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_inmuebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trabajo_inmuebles.Piso p1 = new Piso(Direccionl.Text, Convert.ToInt32(metrosl.Text), Convert.ToInt32(preciol.Text),
                            botonnuevo.Checked.Equals(true), Convert.ToInt32(npisol.Text));

            trabajo_inmuebles.Local l1 = new Local(Direccionl.Text, Convert.ToInt32(metrosl.Text), Convert.ToInt32(preciol.Text),
               (botonnuevo.Checked.Equals(true)), Convert.ToInt32(ventanasl.Text));
            if(boton.Checked == true)
            {
                MessageBox.Show("El precio final es" + Convert.ToString(l1.calcularp(Convert.ToInt32(preciol.Text))));
            }
            if(botonpiso.Checked == true)
            {
                MessageBox.Show("El precio final es" + Convert.ToString(p1.calcularp(Convert.ToInt32(preciol.Text))));
            }
        }

        private void botonusado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botonpiso_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void botonlocal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botonnuevo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ventanasl_TextChanged(object sender, EventArgs e)
        {



            
        }
    }
}
