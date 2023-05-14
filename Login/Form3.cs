using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace Login
{
    public partial class frmCRUD : MaterialForm
    {
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {
            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;

            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");

            //Abriremos la conexión
            conexion_sqlite.Open();

            //Creando el comando SQL
            cmd_sqlite = conexion_sqlite.CreateCommand();

            

            cmd_sqlite.CommandText = "SELECT id,nombre,clave FROM Personas";

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
