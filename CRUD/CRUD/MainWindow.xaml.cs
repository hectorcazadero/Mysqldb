using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace CRUD
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
        /*/void gridFill()
        {
            string conectionString = @"server=127.0.0.1; database=Programacion; Uid=root; pwd=pollo2419;";
            using (MySqlConnection conectar = new MySqlConnection(connectionString))
            {
                MySqlCommand sqlDa = new MySqlCommand("select * from book", conectar);
                conectar.Open();
                DataTable dt = new DataTable();
                dt.Load(sqlDa.ExecuteReader());
                conectar.Close();
                pngrid.DataContext = dt;
                if (dt.Rows.Count > 0)
            }
        }
        /*/
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Apellido = txtApellido.Text.Trim();

            pCliente.Genero = cbGenero.Text.Trim();
            pCliente.Direccion = txtDireccion.Text.Trim();
            int resultado = ClienteDAL.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
            cbGenero.SelectedIndex = 0;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.ShowDialog();
            if (buscar.ClienteSelecccionado != null)
            {
                txtNombre.Text = buscar.ClienteSelecccionado.Nombre;
                txtApellido.Text = buscar.ClienteSelecccionado.Apellido;
                cbGenero.Text = buscar.ClienteSelecccionado.Genero;
                txtDireccion.Text = buscar.ClienteSelecccionado.Direccion;


            }
        }
    }


       
      
}
