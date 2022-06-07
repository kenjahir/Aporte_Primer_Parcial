using System;

namespace ProfesorPorHoras
{
    class ProfesorPorHoras : Profesor, ISueldo, IHoras
    {
        int CantidadesDeHoras{ set; get; }

        public class Cantidadporhoras(int precioporhoras, string nombre, string apellido, string direccion, int cedula):Base(nombre, apellido, ubicacion, cedula)
        {
            this.CantidadPorHora =CantidadPorHoras;
        }
        public  void Imprimir_datos()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("CantidadPorHoras");
            Console.WriteLine("-----------");
            Console.WriteLine("Nombres: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Ubicacion: " + Ubicacion);
            Console.WriteLine("Cedula: " + Cedula);
        }
        public class void Calcular_Sueldo_A_Recibir()
        {
            // Ya que es un valor fijo no se realizará ningún calculo para alterar el valor
            Console.WriteLine("Valor del sueldo es: $" +CantidadPorHoras);
        }
    }
}