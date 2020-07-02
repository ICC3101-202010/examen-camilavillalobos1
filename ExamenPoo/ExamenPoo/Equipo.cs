using System;
using System.Collections.Generic;
namespace ExamenPoo
{
    public class Equipo
    {
        public string Nombre;
        public string Tipo;
        public List<Jugadores> Jugadores;
        public Entrenador Entrenador;
        public Medico Medico;
        public int Goles;
        
        public Equipo(List<Jugadores> jugadores, Entrenador entrenador, Medico medico, int goles)
        {
            Jugadores = jugadores;
            Entrenador = entrenador;
            Medico = medico;
            Goles = goles;
        }

        public void CorroborarNacionalidad()
        {
            if (Tipo == "Nacional")
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
