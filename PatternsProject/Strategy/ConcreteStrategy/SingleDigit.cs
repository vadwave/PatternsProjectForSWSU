using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PatternsProject.Strategy.ConcreteStrategy
{
    // Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу
    // Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
    class SingleDigit : IStrategy
    {
        public bool Check(string data)
        {
            double number = Double.Parse(data);
            return number < 10;
        }

        public string Name()
        {
            return "Однозначное число";
        }
    }
}
