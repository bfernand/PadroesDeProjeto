using System;

namespace SimpleFactory
{
    internal class Pizzaria
    {
        public static void SolicitaPizza()
        {
            PizzaCalabreza pizza1;
            PizzaMussarela pizza2;
            System.Console.WriteLine("===============Pizzaria=============");
            System.Console.WriteLine("Informe a Pizza (C)alabreza ou (M)ussarela \n");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            if (pizzaEscolhida.Equals("C"))
            {
                pizza1 = new PizzaCalabreza();
                pizza1.Preparar();
                pizza1.Assar(10);
                pizza1.Embalar();
                Console.WriteLine("Pizza concluída");
            }
            else if(pizzaEscolhida.Equals("M"))
            {
                pizza2 = new PizzaMussarela();
                pizza2.Preparar();
                pizza2.Assar(10);
                pizza2.Embalar();
                Console.WriteLine("Pizza concluída");
            }
            else
            {
                Console.WriteLine("Essa pizza não existe!");
            }
        }
    }
}