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
using Finisar.SQLite;

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
          

            SQLiteCommand cmd_sqlite;
            
            

            SQLiteConnection conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
            conexion_sqlite.Open();
            cmd_sqlite = conexion_sqlite.CreateCommand();


            cmd_sqlite.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='Personas';";
            object result = cmd_sqlite.ExecuteScalar();

            if (result == null)
            {
                cmd_sqlite.CommandText = "CREATE TABLE Personas (id INTEGER PRIMARY KEY AUTOINCREMENT, nombre VARCHAR(100), clave VARCHAR(100));";
                cmd_sqlite.ExecuteNonQuery();
            }

            


            string nombre = txtUser.Text;
            string clave = txtPass.Text;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una clave");
                return;
            }

            cmd_sqlite.CommandText = "INSERT INTO Personas (nombre, clave) VALUES ('" + nombre + "', '" + clave + "');";
            cmd_sqlite.ExecuteNonQuery();

            conexion_sqlite.Close();

            MessageBox.Show("Usuario registrado exitosamente");


            /*
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
            */
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome hogar = new frmHome();
            hogar.Show();
            this.Hide();
        }
    }
}
