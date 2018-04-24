using System;

namespace LetrasComTraco
{
    class Program
    {
        static void Main(string[] args)
        {
        

            string texto;
            Console.Clear();

            Console.WriteLine("Olá, Bem Vindo ao Separador de Texto");
            Console.WriteLine("Digite um Texto");
            texto = Console.ReadLine();
            for(int i = 0 ; i <  texto.Length; i ++)
                Console.Write(texto[i]+"-");

        }
    }
}
