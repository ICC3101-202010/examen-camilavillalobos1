using System;
namespace ExamenPoo
{
    public abstract class Persona
    {
        public string Nombre;
        public string Nacionalidad;
        public string Profesion;
        public int Edad;
        public int Sueldo;

        public Persona()
        {
        }

        protected Persona(string nombre, string nacionalidad, string profesion, int edad, int sueldo)
        {
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            Profesion = profesion;
            Edad = edad;
            Sueldo = sueldo;
        }
        public abstract string Informacion();
    }
}
