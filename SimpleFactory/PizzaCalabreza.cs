using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class PizzaCalabreza
    {
        public string Nome { get; set; }

        public PizzaCalabreza()
        {
            Nome = "Calabreza";
        }

        public void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }
    }
}
