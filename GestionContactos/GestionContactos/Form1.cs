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

        const int Tamaño = 10;
        string[] nombre = new string[Tamaño];
        int[] numero = new int[Tamaño];
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

        int ComprobarContactoLibre(string[] nombre)
        {
            int i, numCon = 0;
            bool vacio = false;

            for(i = 0; i < nombre.Length && vacio == false; i++)
            {
                if (nombre[i] == "")
                {
                    vacio = true;
                    numCon = i;

                }
            }

            return numCon;
        }

        private void btnAnCon_Click(object sender, EventArgs e)
        {
            string nom;
            int num, numCon;
            bool coincide;

            nom = Interaction.InputBox("Nombre del contacto");
            num = int.Parse(Interaction.InputBox("Numero del contacto"));

            coincide = ComprobarContacto(nom, num, nombre, numero);
            numCon = ComprobarContactoLibre(nombre);
            if (coincide) 
            {
                MessageBox.Show("El contacto coincide");
            }
            else if (numCon != 0)
            {
                nombre[numCon] = nom;
                numero[numCon] = num;
                MessageBox.Show("Se ha registrado satisfactoriamente");
            }
            else
            {
                nombre[i] = nom;
                numero[i] = num;
                i++;
                MessageBox.Show("Se ha registrado satisfactoriamente");
                if(i == nombre.Length)
                {
                    MessageBox.Show("Error:\nEsta llena la agenda");
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
            }
            if (coincide)
            {
                MessageBox.Show("Se ha eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ese contacto no existe");
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
