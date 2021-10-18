using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaSimpleFactory
{
    public class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Calabreza";
            Ingredientes = new List<string>{"Calabresa", "Cebola"};
        }

        public override void Preparar()
        {
            Console.WriteLine($"\nPreparando pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }
    }
}
