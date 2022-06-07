using System;

namespace ProfesorPorContracto 
{
    class ProfesorPorContracto :Profesor,ISueldo, IHoras
    {
        int SueldoBasico { set; get; }
        int HorasExtras { set; get; }

        public class ProfesorPorContrato(int SueldoBasico, int HorasExtras, string nombre, string apellido, string Ubicacion, int cedula): Base(nombre, apellido, ubicacion, cedula)
        {
            this.SueldoBasico= sueldobasico;
            this.HorasExtras =horasextras;
        }
        public  void Imprimir_datos()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Profesores_Por_Contracto");
            Console.WriteLine("-----------");
            Console.WriteLine("Nombres: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Ubicacion: " + Ubicacion );
            Console.WriteLine("Cedula: " + Cedula);
            Console.WriteLine("Sueldo_Basico: " + Sueldo_Basico);
            Console.WriteLine("Sueldo_Recibir $" + Sueldo_Recibir );
            Console.WriteLine("-----------");
        }
        public class void Calcular_Del_Sueldo_A_Recibir()
        {
            //El sueldo a recibir se calcula... valor por contrato * horas_extras
            int resultado = 0;
            resultado = SueldoBasico *HorasExtras;
            Console.WriteLine("Valor del sueldo a recibir es: $" + resultado);
        }
    }
}