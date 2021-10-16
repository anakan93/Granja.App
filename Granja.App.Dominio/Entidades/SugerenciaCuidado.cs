using System;

namespace Granja.App.Dominio
{
    public class SugerenciaCuidado
    {
        public int ID { get; set; }
        public DateTime Fecha_Hora{get;set;}
        public string NivelPrioridad {get;set;}
        public string Descripcion {get;set;}
        public Historial Historial {get;set;}
    }
}