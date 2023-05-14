using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Finisar.SQLite;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Login
{



    public partial class frmHome : MaterialForm
    {
       


        bool validar = false;
        int fallo = 0;



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
            string nombre = txtUser.Text;
            string clave = txtPass.Text;
            

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una clave");
                return;
            }


            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
          

            
            conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
            conexion_sqlite.Open();
            cmd_sqlite = conexion_sqlite.CreateCommand();

            string connectionString = "Data Source=database.db;Version=3;Compress=True;";
            string query = "SELECT COUNT(*) FROM Personas WHERE nombre = '" + nombre + "' AND clave = '" + clave + "'";

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                conexion.Open();

                using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                {
                    int count = Convert.ToInt32(comando.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso!");
                        frmCRUD crud = new frmCRUD();
                        crud.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        fallo += 1;
                        MessageBox.Show("Nombre de usuario o clave incorrectos");
                    }

                    if (fallo ==3) {
                        MessageBox.Show("Bruh, Adiós");
                        this.Close();
                    }
                }
            }


            /*
            string name = txtUser.Text;
            string pass = txtPass.Text;



            using (StreamReader leer = new StreamReader("usuarios.csv"))
            {
                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();
                    string[] v = linea.Split(';');

                    if (v.Length == 2 && v[0] == txtUser.Text && v[1] == txtPass.Text)
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
            }*/
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;

            conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
            conexion_sqlite.Open();
            cmd_sqlite = conexion_sqlite.CreateCommand();

            cmd_sqlite.CommandText = "INSERT INTO Personas(nombre, clave) VALUES ('Juan', 'ju123');";
            cmd_sqlite.ExecuteNonQuery();



            cmd_sqlite.ExecuteNonQuery();

            

            cmd_sqlite.CommandText = "SELECT nombre,clave FROM Personas";

            datareader_sqlite = cmd_sqlite.ExecuteReader();
            while (datareader_sqlite.Read())
            {
                //Mostrando los datos

                string lectura = datareader_sqlite.GetString(0);
                lectura = lectura + datareader_sqlite.GetString(1);
                MessageBox.Show(lectura);

            }
          


            conexion_sqlite.Close();
        }
    }
}


/*
  Estaba en Login

     if (!File.Exists("usuarios.cvs"))
 {
     MessageBox.Show("Debe registrase para iniciar sesión");
     txtUser.Text = "";
     txtPass.Text = "";
     return;

 }*/