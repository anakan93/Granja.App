﻿using System;

namespace Granja.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
        public string Apellido {get;set;}
        public string  NumeroTelefono {get;set;}
        public string CorreoElectronico{get;set;}
        public Genero genero {get;set;}
    }
}
