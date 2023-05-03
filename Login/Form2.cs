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
    public partial class frmSigin : MaterialForm
    {

        List<Persona> _Personas = new List<Persona>();
        public frmSigin()
        {
            InitializeComponent();
        }

        private void frmSigin_Load(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void btnSigin_Click(object sender, EventArgs e)
        {
            string name=txtUser.Text;
            string pass = txtPass.Text;

            Persona persona = new Persona(name, pass);
            _Personas.Add(persona);

            txtUser.Text = "";
            txtPass.Text = "";

            using(StreamWriter crear = new StreamWriter("usuarios.csv", true))
            {
                crear.WriteLine(name + ";" + pass);
            }
            MessageBox.Show("Usuario registrado");
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome hogar = new frmHome();
            hogar.Show();
            this.Hide();
        }
    }
}
