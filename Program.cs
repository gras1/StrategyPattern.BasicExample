using System;

namespace StrategyPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three contexts following different strategies
            var context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            // Wait for user
            Console.ReadKey();
        }
    }
}
