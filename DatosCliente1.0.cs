using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGasolina1._0.Clases
{
    public class DatosCliente1
    {

        private String Nombre;

        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private String Apellidos;

        public String apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        private int NumCedula;

        public int numcedula
        {
            get { return NumCedula; }
            set { NumCedula = value; }
        }
        private String Direccion;
        public String direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public DatosCliente1(string nombre, string apellidos, int numcedula, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.numcedula = numcedula;
            this.direccion = direccion;
        }





    }
}
