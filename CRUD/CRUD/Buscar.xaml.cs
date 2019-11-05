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
using System.Windows.Shapes;

namespace CRUD
{
    /// <summary>
    /// Lógica de interacción para Buscar.xaml
    /// </summary>
    public partial class Buscar : Window
    {
        public Buscar()
        {
            InitializeComponent();
        }
        public Cliente ClienteSelecccionado { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgvBuscar.ItemsSource = ClienteDAL.Buscar(txtNombr.Text);
        }
        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (dgvBuscar.SelectedCells.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.SelectedCells[0].Item);
                ClienteSelecccionado = ClienteDAL.ObtenerCliente(id);
                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

       
    }
}
