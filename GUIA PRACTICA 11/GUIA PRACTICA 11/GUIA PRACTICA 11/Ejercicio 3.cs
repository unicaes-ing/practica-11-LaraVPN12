using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GUIA_PRACTICA_11
{
    class Ejercicio_3
    {
        public static void MenuInicial()
        {
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("QUE DESEAS HACER");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("[1]------------AGREGAR DATOS DEL ALUMNO");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine("[2]------------MOSTRAR DATOS DEL ALUMNO");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("[3]------------BUSCAR ALUMNOS");
            Console.SetCursorPosition(65, 18);
            Console.WriteLine("[4]------------SALIR DEL PROGRAMA");
            Console.SetCursorPosition(65, 22);
            Console.Write("INGRESA UNA OPCION:  ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Ingresar();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Buscar();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("PRESIONA <ENTER> PARA SALIR");
                    Console.ReadKey();
                    break;

            }
        }
        static void Main(string[] args)
        {
            MenuInicial();
            Console.ReadKey();
        }
        public static void Ingresar()
        {
            try
            {
                Console.WriteLine("INGRESA LOS DATOS CORRESPONDIENTES");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA EL CARNET DEL CLIENTE:");
                string carnetEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA EL NOMBRE DEL CLIENTE:");
                string nombreEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("INGRESA LA EDAD DEL CLIENTE:");
               int edadEstudiante = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("INGRESA EL CUM DEL CLIENTE:");
                decimal cumEstudiante = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("DatosCliente.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(carnetEstudiante);
                binario.Write(nombreEstudiante);
                binario.Write(edadEstudiante);
                binario.Write(cumEstudiante);
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
        public static void Mostrar()
        {
            Console.WriteLine("QUE DESEAS MOSTRAR");
            Console.WriteLine();
            Console.WriteLine("[1]------------TODOS LOS ALUMNOS");
            Console.WriteLine();
            Console.WriteLine("[2]------------FILTRADOS POR EL CUM");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("ELIGE UNA OPCION:  ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch(opc)
            {
               case 1:
                    break;
                case 2:
                    break;
            }

        }
        public static void Buscar()
        {

        }
    }
}
