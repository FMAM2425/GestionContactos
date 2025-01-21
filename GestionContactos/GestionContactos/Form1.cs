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

        bool AñadirContacto(string nom, int num, string[] nombre, int[] contacto)
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

            coincide = AñadirContacto(nom, num, nombre, numero);
            if (coincide) 
            {
                MessageBox.Show("El contacto coincide");
            }
            else
            {
                nombre[nombre.Length-1] = nom;
                numero[numero.Length-1] = num;
                MessageBox.Show("Se ha registrado exitosamente");
            }
        }
    }
}
