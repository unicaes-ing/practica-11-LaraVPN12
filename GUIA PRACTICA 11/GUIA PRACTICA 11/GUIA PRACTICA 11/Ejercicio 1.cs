using System;
using System.IO;

namespace GUIA_PRACTICA_11
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INGRESA LOS DATOS CORRESPONDIENTES");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA EL NOMBRE DEL CLIENTE:");
                string nombreCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA EL NUMERO TELEFONICO DEL CLIENTE:");
                string telCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA LA FECHA DE NACIMIENTO DEL CLIENTE:");
                string nacimientoCliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA EL SUELDO DEL CLIENTE:");
                decimal sueldoCliente = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("DatosCliente.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(nombreCliente);
                binario.Write(telCliente);
                binario.Write(nacimientoCliente);
                binario.Write(sueldoCliente);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("LOS DATOS SE ALMACENARON EXITOSAMENTE");
                Console.ReadKey();


            }
            catch (Exception)
            {

                Console.WriteLine("HA OCURRIDO UNERROR AL GUARDAR LOS DATOS");
            }
        }
    }
}
