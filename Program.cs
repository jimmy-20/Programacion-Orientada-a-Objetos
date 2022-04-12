using System;
using Generico;
using TipoAnimal;

namespace James
{
    class Program
    {
        public static void Main(){
            Terrestre perro = new Terrestre("Pulgas",0.5f,20,"Carnivoro",4);
            
            Console.WriteLine("Tipo animal");
            string animal = Console.ReadLine();

            Console.WriteLine("Ingrese la raza");
            string raza = Console.ReadLine();

            Console.WriteLine("Ingrese el color");
            string color = Console.ReadLine();

            perro.Raza = raza;
            perro.Color = color;
            perro.Tipo = animal;

            Console.WriteLine("Y hace");
            string sonido = Console.ReadLine();

            perro.Sonido = sonido;
            
            perro.Ruido();

        }
    }

    /*
    Paradigmas de la POO:
    -Encapsulamiento
    -Abstraccion
    -Herencia
    -Polimorfismo
    */
}