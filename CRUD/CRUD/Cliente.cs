using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Cliente
    {
         public int Id { get; set; }
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Genero { get; set; }
       public string Direccion { get; set; }

       public Cliente() { }

       public Cliente(int pId, string pNombre, string pApellido, string pGenero, string pDireccion)

       {

           this.Id = pId;
           this.Nombre = pNombre;
           this.Apellido = pApellido;
           this.Genero = pGenero;
           this.Direccion = pDireccion;       

       }
    }
}
