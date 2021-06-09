using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new NoQuarterState(), 2, 1);
        }
    }
}
