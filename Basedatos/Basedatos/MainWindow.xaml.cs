using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basedatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            string servidor = txtServidor.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string datos = "";
            string conexion = "server=" + servidor + "; port= " + puerto + "; user id= " + usuario + "; password= " + password + "; database=mysql;";
            MySqlConnection conexionBD = new MySqlConnection(conexion);
            try
            {
                conexionBD.Open();
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", conexionBD);
                reader = cmd.ExecuteReader(); 
                while(reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show(datos);
        }
    }
}
