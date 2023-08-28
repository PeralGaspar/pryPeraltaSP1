using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace pryPeraltaSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            { 
                StreamWriter swCrearArchivo = new StreamWriter("MiArchivitito", false);
                MessageBox.Show("Se Creo correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Fatal Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                StreamWriter swManejoArchivo = new StreamWriter("MiArchivitito", true);
                swManejoArchivo.WriteLine(txtDatos.Text);
                MessageBox.Show("Grabado");
                swManejoArchivo.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Fatal Error");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
                StreamReader swManejoArchivo = new StreamReader("MiArchivitito");
                while (swManejoArchivo.EndOfStream != true) 
                { 
                    txtDatos.Text += swManejoArchivo.ReadLine() + Environment.NewLine;
                }
                swManejoArchivo.Close();
        }
    }
}
