using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Strategy
{
    // Интерфейс Стратегии объявляет операции, общие для всех поддерживаемых
    // версий некоторого алгоритма.
    //
    // Контекст использует этот интерфейс для вызова алгоритма, определённого
    // Конкретными Стратегиями.
    public interface IStrategy
    {
        bool Check(string data);
        string Name();
    }
}
