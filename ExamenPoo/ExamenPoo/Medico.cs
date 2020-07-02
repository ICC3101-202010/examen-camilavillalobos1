using System;
using System.Collections.Generic;
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

        public delegate void LesionEventHandler(object source, EventArgs args);

        public event LesionEventHandler Lesion;

        protected virtual void OnLesion()
        {
            if (Lesion != null)
            {
                Console.WriteLine("Jugador Lesionado");
            }
        }

        public void OnLesion(object source, EventArgs e)
        {
            Console.WriteLine("Jugador Lesionado");
        }


        public void Evaluar(List<Jugadores> jugadores)
        {
            foreach (var item in jugadores)
            {
                if (item.Estado == "Lesionado")
                {
                    OnLesion();
                }
            }
        }
        public void Curar(Jugadores jugador)
        {
            jugador.Estado = "Estable";
        }


    }
}
