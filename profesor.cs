using System;

namespace Profesores
{
    class Profesores
    {
        string Nombre { set; get; }
        string Apellidos { set; get; }
        string Direccion { set; get; }
        int Cedula{ set; get; }

        public Profesores(string nombre, string apellido, string direecion, int cedula)
       
            {

            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ubicacion= direccion ;
            this.Cedula = cedula;
        }
}
