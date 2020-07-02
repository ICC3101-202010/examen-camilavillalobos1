using System;
using System.Collections.Generic;
namespace ExamenPoo
{
    public class Equipo
    {
        public string Nombre;
        public string Tipo; //Nacional o Liga
        public List<Jugadores> Jugadores;
        public Entrenador Entrenador;
        public Medico Medico;
        public int Goles;
        

        public Equipo(string nombre, string tipo, List<Jugadores> jugadores, Entrenador entrenador, Medico medico, int goles)
        {
            Nombre = nombre;
            Tipo = tipo;
            Jugadores = jugadores;
            Entrenador = entrenador;
            Medico = medico;
            Goles = goles;
        }

        public void CorroborarEquipo(List<Jugadores> jugadores)
        {
            if (jugadores.Count > 15)
            {
                Console.WriteLine("Debe eliminar un jugador");
                Entrenador.CambiarJugador(jugadores);
            }

        }

        public void CorroborarNacionalidad(Equipo equipo)
        {
            if (equipo.Tipo == "Nacional")
            {
                foreach (var item in Jugadores)
                {
                    if (item.Nacionalidad == "chileno")
                    {
                        Console.WriteLine("Soy nacional");
                    }
                    else
                    {
                        Console.WriteLine("No soy de la misma nacion");
                        Jugadores.Remove(item);
                    }
                }
            }
        }
        public string Informacion()
        {
            string datos = "Entrenador: " + Entrenador;
            datos += "/nJugadores";
            foreach (var item in Jugadores)
            {
                Console.WriteLine(item.Nombre);
            }
            datos += "/nMedico:" + Medico;
            return datos;
        }
        

    }
}
