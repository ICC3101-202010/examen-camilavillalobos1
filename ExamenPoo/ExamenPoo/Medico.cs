using System;
namespace ExamenPoo
{
    public class Medico : Persona
    {
        public int PuntosExperiencia;
        public Medico(string nombre, string nacionalidad, string profesion, int edad, int sueldo, int experiencia)
        {
            PuntosExperiencia = experiencia;
        }
        public override string Informacion()
        {
            string datos = "Nombre: "+Nombre+ "/nNacionalidad"+Nacionalidad+ "/nExperiencia: "+ PuntosExperiencia;
            return datos;
        }

        public void Evaluar(Jugadores jugador)
        {

        }
        public void Curar(Jugadores jugador)
        {

        }
    }
}
