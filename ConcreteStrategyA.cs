using System;

namespace StrategyPattern.BasicExample
{
    public class ConcreteStrategyA : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}