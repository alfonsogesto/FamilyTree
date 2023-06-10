using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person ("Francisco", 87);
            Person person2 = new Person ("Aitana", 18);
            Person person3 = new Person ("Alfonso", 19);
            Person person4 = new Person ("Mike", 26);
            Person person5 = new Person ("Jacqueline", 65);
            Person person6 = new Person ("Mateo", 21);
            Person person7 = new Person ("Agustin", 47);
            Person person8 = new Person ("Sol", 32);
            
            Node<Person> n1 = new Node<Person>(person1);
            Node<Person> n2 = new Node<Person>(person2);
            Node<Person> n3 = new Node<Person>(person3);
            Node<Person> n4 = new Node<Person>(person4);
            Node<Person> n5 = new Node<Person>(person5);
            Node<Person> n6 = new Node<Person>(person6);
            Node<Person> n7 = new Node<Person>(person7);
            Node<Person> n8 = new Node<Person>(person8);
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            VisitorSumaEdad suma = new VisitorSumaEdad();
            
            System.Console.WriteLine(suma.getAgeSum(n6));

            MayorEdad mayor = new MayorEdad();
            System.Console.WriteLine(mayor.Older(n6));

            VisitorNameLength largo = new VisitorNameLength();
            System.Console.WriteLine(largo.NameLength(n6));
        }
    }
}
           
