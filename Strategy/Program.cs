using System;

namespace Strategy
{
    class Program
    {
        private static ISymbolStrategy symbolStrategy;
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;

            symbolStrategy = new MinusSymbol();
            Console.WriteLine(symbolStrategy.Calculate(a, b));

            symbolStrategy = new PlusSymbol();
            Console.WriteLine(symbolStrategy.Calculate(a, b));

            symbolStrategy = new MultiplySymbol();
            Console.WriteLine(symbolStrategy.Calculate(a, b));

            symbolStrategy = new DivideSymbol();
            Console.WriteLine(symbolStrategy.Calculate(a, b));
        }
    }
}
