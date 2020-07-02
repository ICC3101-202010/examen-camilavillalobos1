using System;
namespace ExamenPoo
{
    public class Jugadores: Persona
    {
        public int PuntosdeAtaque;
        public string Defensa;
        public int NumeroCamiseta;
        public string Rol;
        public string Estado;

        public Jugadores(string nombre, string nacionalidad, string profesion, int edad, int sueldo, int puntosdeAtaque, string defensa, int numeroCamiseta, string rol, string estado)
        {
            PuntosdeAtaque = puntosdeAtaque;
            Defensa = defensa;
            NumeroCamiseta = numeroCamiseta;
            Rol = rol;
            Estado = estado;
        }
        public delegate void LesionEventHandler(object source, EventArgs args);

        public event LesionEventHandler Lesion;

        protected virtual void OnLesion(string estado)
        {

        }

        public override string Informacion()
        {
            Console.WriteLine("Jugadores");
            string datos = "Nombre: " + Nombre + "/nEstado en cancha: "+Estado+ "/nRol: " +Rol+
                "/nNacionalidad: "+ Nacionalidad +"/nEdad: " + Edad + "/nNumero: "+ NumeroCamiseta+
                "/nPuntos de Ataque: " + PuntosdeAtaque;
            return datos;
        }
    }
}
