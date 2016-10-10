using System;

namespace StrategyPattern.BasicExample
{
    public class ConcreteStrategyC : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}