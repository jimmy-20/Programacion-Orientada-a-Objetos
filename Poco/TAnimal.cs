using System;
using Generico;

namespace TipoAnimal
{
    class Terrestre : Animal
    {
        private string raza;
        private string color;

        //public string Raza => (raza);
        //public string Color => (color);
        public string Raza { get; set; }
        public string Color { get; set; }

        /*public Terrestre(string nombre,float estatura, float peso, string alimentacion, int patas){
            this.Nombre = nombre;
            this.Estatura = estatura;
            this.Peso = peso;
            this.Alimentacion = alimentacion;
            this.Patas = patas;
        }*/

        public Terrestre (string nombre,float estatura, float peso, string alimentacion, int patas) =>
        (Nombre,Estatura,Peso,Alimentacion,Patas) = (nombre,estatura,peso,alimentacion,patas);

        public virtual void Ruido(){
            Console.WriteLine("El " +this.Tipo + " hace " + this.Sonido);
        }

    }
}