using System;

namespace StrategyPattern.BasicExample
{
    public class ConcreteStrategyB : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}