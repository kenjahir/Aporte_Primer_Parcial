using System;

namespace 
{
    class Program
    {
        //Console.WriteLine(" hi");
        static void Main(string[] args)
        {
            Profesor_por_horas profesor_por__horas = new Profesor_por_horas (0, "Diana Valentina", "Mero Loor", "Quito", 1324515);
            profesor_por_horas.Imprimir_datos();
            profesor_por_horas.Calcular_matricula();

            Profesor_por_contrato profesor_por_nombramiento = new profesor_por_contracto(0, "Juan Daniel", "Calle Pérez", "Quevedo", 214241);
            profesor_por_contrato.Imprimir_datos();
            profesor_por_contrato.Calcular_SUELDO();

            Profesor_por_nombramiento estudiante_universitario = new Profesor_por_nombramiento(1,000, "Diana Valentina", "Mero Loor", "Manta", 12354);
            profesor_por_nombramiento.Imprimir_datos();
            profesor_por_nombramiento.Calcular_matricula();
        }
    }
}