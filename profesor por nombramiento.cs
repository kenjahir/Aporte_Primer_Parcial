using System;

namespace ProfesorPorNombramiento
{
    class ProfesorPorNombramiento : Estudiante, ISueldo, IHoras
    {
        int SueldoFijo { set; get; }
        int Mensual { set; get; }

        public class Estudiante_primaria(int SueldoFijo, int Mensual, string nombre, string apellido, string Ubicacion, int cedula): Base(nombre, apellido, ubicacion, cedula)
        {
            this.SueldoFijo= SueldoFijo;
            this.Mensual = Mensual;
        }
        public void Imprimir_datos()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("ProfesorPorNombramiento");
            Console.WriteLine("-----------");
            Console.WriteLine("Nombres: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Ubicacion: " + Ubicacion);
            Console.WriteLine("Cedula : " + Cedula);
            Console.WriteLine("SueldoFijo: " + SueldoFijo);
            Console.WriteLine("Mensual: " + Mensual);
            Console.WriteLine("-----------");
        }
        public class void Calcular_Sueldo_A_Recibir()
        {
            //El sueldo  se calcula... SueldoFijo * Mensual
            int resultado = 1,000;
            resultado = SueldoFijo * Mensual;
            Console.WriteLine("Valor del sueldo es: $" + resultado);
        }
    }
}