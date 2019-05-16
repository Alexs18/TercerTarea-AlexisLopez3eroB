using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoGasolina1._0.Clases;

namespace CalculoGasolina1._0
{
    class Program
    {
        static void Main(string[] args)
        {

            DatosCliente1 AlexCliente = new DatosCliente1("Alexis Ricardo ", "López Mero", 1315643891, "Calle 114 av 104");
            DatosGasolina1 AlexGasolina = new DatosGasolina1("Extra", 18, 1.50);

            Console.WriteLine("------LOS DATOS DEL CLIENTE SON------\n" +
                "Nombres :   {0}\n" +
                "Apellidos:    {1} son\n" +
                "Numero de Cedula:    {2}\n" +
                "Direccion:    {3}", AlexCliente.nombre, AlexCliente.apellidos, AlexCliente.numcedula, AlexCliente.direccion);
            Console.WriteLine("-------LOS DATOS DE LA GASOLINA SON-------");
            Console.WriteLine("tipo de Gasolina:    {0}\n" +
                "Galones abquiridos:     {1}\n" +
                "Precio por Galon:    {2}", AlexGasolina.tipo, AlexGasolina.cantidadgalones, AlexGasolina.precioventa);

            Console.WriteLine("-----LOS DATOS DE LA FACTURA SON-----");
            Console.WriteLine("--------subtotal    " + AlexGasolina.subtotal);
            Console.WriteLine("--------Valor iva generado es " + AlexGasolina.Iva);
            Console.WriteLine("--------total a pagar es " + AlexGasolina.Total);
            Console.WriteLine("\n" +
                "" +
                "" +
                "" +
                "" +
                "");
            DatosCliente1 lexCliente = new DatosCliente1("Lady Maria ", "Molina Moreira", 1315647289, "Calle 202 av 105");
            DatosGasolina1 lexGasolina = new DatosGasolina1("Super", 20, 2.50);
          

            Console.WriteLine("-----LOS DATOS DEL CLIENTE SON-----\n" +
                "Nombres :   {0}\n" +
                "Apellidos:    {1} son\n" +
                "Numero de Cedula:    {2}\n" +
                "Direccion:    {3}", lexCliente.nombre, lexCliente.apellidos, lexCliente.numcedula, lexCliente.direccion);
            Console.WriteLine("-------LOS DATOS DE LA GASOLINA SON-------");
            Console.WriteLine("tipo de Gasolina:    {0}\n" +
                "Galones abquiridos:     {1}\n" +
                "Precio por Galon:    {2}", lexGasolina.tipo, lexGasolina.cantidadgalones, lexGasolina.precioventa);

            Console.WriteLine("-----LOS DATOS DE LA FACTURA SON-----");
            Console.WriteLine("--------subtotal    " + lexGasolina.subtotal);
            Console.WriteLine("--------Valor iva generado es " + lexGasolina.Iva);
            Console.WriteLine("--------total a pagar es " + lexGasolina.Total);
            Console.WriteLine("\n" +
                "" +
                "" +
                "" +
                "" +
                "");
            Console.ReadKey();
            
        }
    }
}
