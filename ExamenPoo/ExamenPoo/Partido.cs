using System;
namespace ExamenPoo
{
    public class Partido
    {
        public DateTime duracion;
        public Equipo equipo1;
        public Equipo equipo2;
        bool corr = false;

        public Partido()
        {
        }

        public Partido(DateTime duracion, Equipo equipo1, Equipo equipo2)
        {
            this.duracion = duracion;
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
        }

        public void CorroborarEquipos()
        {
            if (equipo1.Tipo == equipo2.Tipo)
            {
                corr = true;
            }
            else
            {
                corr = false;
            }


        }

        public string InformacionPartido()
        {
            CorroborarEquipos();
            string datos = "";
            datos += "Equipo 1: " + equipo1.Nombre;
            datos += "Equipo 2: " + equipo2.Nombre;
            datos += "Duracion: " + duracion.Hour;
            datos += "Gol equipo 1: " + equipo1.Goles;
            datos += "Gol equipo 2: " + equipo2.Goles;
            if (equipo1.Goles > equipo2.Goles)
            {
                datos += "Va ganando: " + equipo1.Nombre;
            }
            else if (equipo1.Goles < equipo2.Goles)
            {
                datos += "Va ganando: " + equipo2.Nombre;
            }
            else
            {
                datos += "Equipos empatados";
            }

            return datos;

        }
    }
}
