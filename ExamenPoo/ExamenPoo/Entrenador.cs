using System;
using System.Collections.Generic;
namespace ExamenPoo
{
    public class Entrenador: Persona
    {
        public int PuntosTactica;

        public Entrenador(string nombre, string nacionalidad, string profesion, int edad, int sueldo, int puntostactica)
        {
            PuntosTactica = puntostactica;
        }
        public void CambiarJugador(List<Jugadores> jugadores)
        {
            int i = 0;
            foreach (var item in jugadores)
            {
                Console.WriteLine(i +"- "+ item.Nombre);
                i++;
            }
            Console.WriteLine("Que jugador desea cambiar?:");
            int opc = Convert.ToInt32(Console.ReadLine());
            jugadores.Remove(jugadores[opc-1]);

        }
        public override string Informacion()
        {
            string datos = "Nombre: " + Nombre + "/nNacionalidad: " +Nacionalidad+ "/nPuntos Tactica: " + PuntosTactica;
            return datos;
        }

    }
}
