using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoGasolina1._0.Clases
{
    public class DatosGasolina1                                                                                                                                                                                                                                                                                                                                                           
    {


        private String Tipo;

        public String tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        private int CantidadGalones;

        public int cantidadgalones
        {
            get { return CantidadGalones; }
            set { CantidadGalones = value; }
        }
        private double PrecioVenta;

        public DatosGasolina1(string tipo, int cantidadgalones, double precioventa)
        {
            this.tipo = tipo;
            this.cantidadgalones = cantidadgalones;
            this.precioventa = precioventa;
        }

        public double precioventa
        {get { return PrecioVenta; } set { PrecioVenta = value; } }
        public double subtotal
        {
            get {
                return cantidadgalones * precioventa;
            }

        }
        public double Iva
        {
            get {
                return subtotal * 0.12;
            }
        }
        public double Total
        {
            get
            {
                return Iva + subtotal;
            }
        }
       








    }
}
