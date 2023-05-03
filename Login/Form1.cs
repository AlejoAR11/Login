using MaterialSkin.Controls;
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

namespace Login
{


 
    public partial class frmHome : MaterialForm
    {
        bool validar = false;
        int count = 0;

        List<Persona> _Personas = new List<Persona>();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnSigin_Click(object sender, EventArgs e)
        {
            frmSigin sigin = new frmSigin();
            sigin.Show();
            this.Hide();
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string pass = txtPass.Text;

           /* if (!File.Exists("usuarios.cvs"))
            {
                MessageBox.Show("Debe registrase para iniciar sesión");
                txtUser.Text = "";
                txtPass.Text = "";
                return;

            }*/



            using (StreamReader leer = new StreamReader("usuarios.csv"))
            {
                while(!leer.EndOfStream) {
                    string linea = leer.ReadLine();
                    string[] v = linea.Split(';');

                    if(v.Length == 2 && v[0] ==name && v[1] == pass)
                    {
                        validar = true;
                        break;


                    }
                
                }


            }

            if (validar == true)
            {
                MessageBox.Show("Bienvenido " + name);


            }
            else
            {

                count += 1;
                MessageBox.Show("Usuario o contraseña no coinciden");

            }

            if (count == 3)
            {
                MessageBox.Show("Bruh Adiós");
                this.Close();
            }
        
        }
       
    }
}
