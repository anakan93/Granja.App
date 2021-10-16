using System;
namespace Granja.App.Dominio
{
    public class Historial
    {
        public int ID { get; set; }
        public int Temperatura {get; set;}
        public bool agua {get;set;}
        public bool Alimento { get;set;}
        public int CantidadHuevos {get;set;}
        public int GallinasEnfermas {get;set;}
    }
}
