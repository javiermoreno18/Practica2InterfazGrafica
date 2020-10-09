using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2InterfazGrafica
{
    public partial class Form1 : Form

    {
        string nombre;
        string telefono;
        string procesador;
        string ram;
        string discoDuro;
        string sistemasOp;
        string adicionales;
       

        public Form1()
        {
            InitializeComponent();
        }

        public void getInformacion()
        {
            nombre = textBox1.Text;
            telefono = textBox2.Text;
            procesador = comboBox1.Text.ToString();
            ram = comboBox2.Text.ToString(); 

            if (radioButton1.Checked)
            {
                discoDuro = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                discoDuro = radioButton2.Text;
            }
            else
            {
                discoDuro = radioButton3.Text;
            }



            if (checkBox7.Checked)
            {
                sistemasOp = checkBox7.Text;
            }

            if (checkBox8.Checked)
            {
                sistemasOp = checkBox8.Text;
            }

            if (checkBox9.Checked)
            {
                sistemasOp = checkBox9.Text;
            }

            if (checkBox10.Checked)
            {
                sistemasOp = checkBox10.Text;
            }


            if (checkBox1.Checked)
            {
                adicionales = checkBox1.Text;
            }

            if (checkBox2.Checked)
            {
                adicionales = checkBox2.Text;
            }

            if (checkBox3.Checked)
            {
                adicionales = checkBox3.Text;
            }

            if (checkBox4.Checked)
            {
                adicionales = checkBox4.Text;
            }
            if (checkBox5.Checked)
            {
                adicionales = checkBox5.Text;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInformacion();
            MessageBox.Show("TICKET" + "\nNombre: " + nombre + "\nTelefono: " + telefono + "\nProcesador: " + procesador + "\nRam: " + ram + "\nDisco duro: " + discoDuro + "\nSistema Operativo: " + sistemasOp + "\nAdicionales: " + adicionales);

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
