using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Recogida de basura");
            comboBox1.Items.Add("Calles sin asfaltar");
            comboBox1.Items.Add("Problemas de desague en calles");
            comboBox1.Items.Add("Alcantarillas sin tapas");
            comboBox1.Items.Add("Deterioro del asfalto en calles");
            comboBox1.Items.Add("Árboles caídos en la vía pública ");
            comboBox1.Items.Add("Alambrado en las calles");
            comboBox1.Items.Add("Calles sin señalizaciones");
            comboBox1.Items.Add("Desliz de tierra");
            comboBox1.Items.Add("Incendio forestal");
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            /*
                comboBox1.Items.Add("Recogida de basura");
                comboBox1.Items.Add("Calles sin asfaltar");
                comboBox1.Items.Add("Problemas de desague en calles");
                comboBox1.Items.Add("Alcantarillas sin tapas");
                comboBox1.Items.Add("Deterioro del asfalto en calles");
                comboBox1.Items.Add("Árboles caídos en la vía pública ");
                comboBox1.Items.Add("Alambrado en las calles");
                comboBox1.Items.Add("Calles sin señalizaciones");
                comboBox1.Items.Add("Desliz de tierra");
                comboBox1.Items.Add("Incendio forestal");
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ventana2 = new Form2();
            ventana2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter escribir;
            escribir = File.CreateText("Problematica.txt");
            escribir.WriteLine("Nombre: " + TBnombre.Text + "\n " +
                "Apellido: " + TBapellidos.Text + "\n" +
                "Cedula: " + TBcedula.Text +"\n" +
                "Telefono: "+ TBtelefono.Text +"\n"+"\n"+
                "locacion*********************" + "\n" + "\n"+
                "provincia: " +TBprovincia.Text + "\n" +
                "Municipio: "+TBmunicipio.Text + "\n" +
                "Sector: "+ TBsector.Text + "\n" +
                "Coordenadas: "+TBcoordenadas.Text + "\n" + "\n"+
                "problematica**************" + "\n" + "\n"+
                "Problematica: " +comboBox1.SelectedItem.ToString() + "\n" +
                "Descripcion: "+TBdescripcion.Text);
            escribir.Close();
            MessageBox.Show("Datos recopilados");
            TBnombre.Text = "";
            TBapellidos.Text = "";
            TBcedula.Text = "";
            TBtelefono.Text = "";
            TBprovincia.Text = "";
            TBmunicipio.Text = "";
            TBsector.Text = "";
            TBcoordenadas.Text = "";
            TBdescripcion.Text = "";
            comboBox1.SelectedItem = null;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBnombre.Text = "";
            TBapellidos.Text = "";
            TBcedula.Text = "";
            TBtelefono.Text = "";
            TBprovincia.Text = "";
            TBmunicipio.Text = "";
            TBsector.Text = "";
            TBcoordenadas.Text = ""; 
            TBdescripcion.Text = "";
            comboBox1.SelectedItem = null;
        }
    }
}
