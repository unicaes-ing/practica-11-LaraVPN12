using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GUIA_PRACTICA_11
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("DatosCliente.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string nombreCliente = binario.ReadString();
                string telCliente = binario.ReadString();
                string nacimientoCliente = binario.ReadString();
                decimal sueldoCliente = binario.ReadDecimal();
                stream.Close();
                binario.Close();
                Console.WriteLine("DATOS DEL CLIENTE");
                Console.WriteLine();
                Console.WriteLine("NOMBRE DEL CLIENTE: {0}",nombreCliente);
                Console.WriteLine();
                Console.WriteLine("NUMERO TELEFONICO DEL CLIENTE: {0}", telCliente);
                Console.WriteLine();
                Console.WriteLine("FECHA DE NACIMIENTO DEL CLIENTE: {0}", nacimientoCliente);
                Console.WriteLine();
                Console.WriteLine("SUELDO DEL CLIENTE: {0:C2}", sueldoCliente);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("PRESIONE <ENTER> PARA SALIR");
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.WriteLine("HA OCURRIDO UN ERROR AL QUERER MOSTRAR LOS DATOS");
            }
        }
    }
}
