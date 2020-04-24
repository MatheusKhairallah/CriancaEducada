using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um insulto para uma pessoa: ");
            string insulto=Console.ReadLine().Replace("chato", "#*$#*").Replace("feio", "@**%");

            Console.Clear();
            
            string mensagem="" +insulto+ "";

            Console.WriteLine(mensagem);
        }
    }
}
