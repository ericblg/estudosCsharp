using System;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1 = 0;
            int qtdPeca1 = 0;
            float valorPeca1 = 0;
            int codPeca2 = 0;
            int qtdPeca2 = 0;
            float valorPeca2 = 0;
            float valorTotal = 0;
            Console.WriteLine("Digite codigo peca 1");
            codPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantidade peca 1");
            qtdPeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor peca 1");
            valorPeca1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite codigo peca 2");
            codPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantidade peca 2");
            qtdPeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor peca 2");
            valorPeca2 = float.Parse(Console.ReadLine());

            valorTotal = qtdPeca1 * valorPeca1 + qtdPeca2 * valorPeca2;
            Console.WriteLine("VALOR A PAGAR:{0}", valorTotal);
        }
    }
}
