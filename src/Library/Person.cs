using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public string Nombre;
        public int Edad;

        public Person(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
    }
}