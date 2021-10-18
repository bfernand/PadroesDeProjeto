using System;

namespace PizzariaSimpleFactory
{
    internal class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("===============Pizzaria=============");
            Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");
            var tipo = Console.ReadLine().ToUpper();

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("Pizza concluída.");

                Pizza pizza2 = new PizzaCalabreza();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}