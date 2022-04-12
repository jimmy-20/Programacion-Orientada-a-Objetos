namespace Generico
{
    class Animal
    {
        private string tipo;
        private string nombre;
        private float estatura;
        private float peso;
        private string alimentacion;
        private int patas;
        private string sonido;

        public string Nombre{
            get{
                return nombre;
            }
            set{
                this.nombre = value;
            }
        }

        public float Estatura{
            get{
                return estatura;
            }
            set{
                this.estatura = value;
            }
        }

        public float Peso{
            get{
                return this.peso;
            }
            set{
                this.peso = value;
            }
        }

        public string Alimentacion{
            get{
                return alimentacion;
            }
            set{
                this.alimentacion = value;
            }
        }

        public int Patas{
            get{
                return patas;
            }
            set{
                this.patas = value;
            }
        }

        public string Sonido { get; set; }

        public string Tipo { get; set; }

        public void Ruido(){

        }
    }
}