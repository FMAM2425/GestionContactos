using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Nombre = 10;
        const int Numero = 10;
        string[] nombre = new string[Nombre];
        int[] numero = new int[Numero];
        int i = 0;

        bool ComprobarContacto(string nom, int num, string[] nombre, int[] contacto)
        {
            bool coincide = false;
            for(int i = 0; i < nombre.Length; i++)
            {
                if(nom == nombre[i])
                {
                    coincide = true;   
                }
            }
            return coincide;
        }

        private void btnAnCon_Click(object sender, EventArgs e)
        {
            string nom;
            int num;
            bool coincide;

            nom = Interaction.InputBox("Nombre del contacto");
            num = int.Parse(Interaction.InputBox("Numero del contacto"));

            coincide = ComprobarContacto(nom, num, nombre, numero);
            if (coincide) 
            {
                MessageBox.Show("El contacto coincide");
            }
            else
            {
                nombre[i] = nom;
                numero[i] = num;
                i++;
                MessageBox.Show("Se ha registrado satisfactoriamente");
                if(i == nombre.Length)
                {
                    i = 0;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nom;
            bool coincide = false;
            
            nom = Interaction.InputBox("Nombre del contacto");

            for (int i = 0; i < nombre.Length && coincide == false; i++)
            {
                if (nom == nombre[i])
                {
                    nombre[i] = "";
                    numero[i] = 0;
                    coincide = true;
                }
                else
                {
                    MessageBox.Show("Ese contacto no existe");
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            string nom;
            int tlf;
            bool encontrado = false;

            nom = Interaction.InputBox("Introduce el contacto \nque quieres modificar");

            for(int i = 0;i < nombre.Length && !encontrado; i++)
            {
                if(nom == nombre[i])
                {
                    encontrado = true;
                    tlf = int.Parse(Interaction.InputBox("Introduce un nuevo telefono para " + nombre[i]));
                    numero[i] = tlf;
                    MessageBox.Show("El telefono a sido modificado satisfactoriamente");
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (numero[i] == 0)
                {
                    texto += "Contacto vacío\n";
                }
                else
                {
                    texto += nombre[i] + " " + numero[i] + "\n";
                }
            }
            MessageBox.Show(texto);
        }
    }
}
