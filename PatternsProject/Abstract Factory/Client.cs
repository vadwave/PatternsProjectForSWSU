using PatternsProject.Abstract_Factory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Abstract_Factory
{
    // Клиентский код работает с фабриками и продуктами только через абстрактные
    // типы: Абстрактная Фабрика и Абстрактный Продукт. Это позволяет передавать
    // любой подкласс фабрики или продукта клиентскому коду, не нарушая его.
    class Client
    {
        public void Main()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            Console.WriteLine("Какие продукты завод воспроизводит в стиле 'Модерн'...");
            ClientMethod(new Modern());
            Console.WriteLine();

            Console.WriteLine("Какие продукты завод воспроизводит в стиле 'Ампир'...");
            ClientMethod(new Empire());
            Console.WriteLine();

            Console.WriteLine("Какие продукты завод воспроизводит в стиле 'Викториан'...");
            ClientMethod(new Victorian());
            Console.WriteLine();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateSofa();
            var productB = factory.CreateDesk();
            var productC = factory.CreateChair();

            Console.WriteLine("Завод может собрать " + productA.Show());
            Console.WriteLine("Завод может собрать " + productB.Show());
            Console.WriteLine("Завод может собрать " + productC.Show());
        }
    }
}
