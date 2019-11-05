using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    class ClienteDAL
    {
        public static int Agregar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into  Alumno(Nombre, Apellido, Genero, Direccion) values ('{0}','{1}','{2}', '{3}')" , pCliente.Nombre, pCliente.Apellido, pCliente.Genero, pCliente.Direccion), BdComun.ObtenerConexion()); 
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id, Nombre, Apellido, Genero, Direccion FROM Alumno where Nombre ='{0}'", pNombre), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Genero = _reader.GetString(3);
                pCliente.Direccion = _reader.GetString(4);


                _lista.Add(pCliente);
            }

            return _lista;
        }
        public static Cliente ObtenerCliente(int pId)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, Nombre, Apellido, Genero, Direccion FROM Alumno where Id={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Genero = _reader.GetString(3);
                pCliente.Direccion = _reader.GetString(4);

            }
            conexion.Close();
            return pCliente;

        }
    }
}
