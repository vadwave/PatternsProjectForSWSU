using PatternsProject.Abstract_Factory;
using PatternsProject.Composite;
using PatternsProject.Composite.Components;
using PatternsProject.Strategy;
using PatternsProject.Strategy.ConcreteStrategy;
using System;
using System.Collections.Generic;

namespace PatternsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Launch_Composite();
            Console.Read();
        }

        public static void Launch_AbstractFactory()
        {
            new Abstract_Factory.Client().Main();
        }

        public static void Launch_Composite()
        {
            Composite.Client client = new Composite.Client();

            Gasoline leaf = new Gasoline();
            Electric leaf2 = new Electric();
            Composite.Composite branch1 = new Composite.Composite();
            branch1.Add(new Electric());
            branch1.Add(new Gasoline());
            Composite.Composite branch2 = new Composite.Composite();
            branch2.Add(new Gas());
            branch2.Add(new Gasoline());

            Component auto = new Gas();
            Component auto2 = new Gasoline();
            List<Component> list_auto2 = new List<Component>();
            list_auto2.Add(auto);
            list_auto2.Add(auto2);
            list_auto2.Add(auto);
            list_auto2.Add(auto);


            List<Component> list_auto = new List<Component>();
            list_auto.Add(leaf);
            list_auto.Add(leaf2);
            list_auto.Add(branch1);
            list_auto.Add(branch2);
            Console.WriteLine("\nАвтосалон A имеет автомобиль:");
            client.ClientCode(list_auto);

            Console.WriteLine("\nАвтосалон B имеет автомобиль:");
            client.ClientCode(list_auto2);
        }
        
        public static void Launch_Strategy()
        {
            // Клиентский код выбирает конкретную стратегию и передаёт её в
            // контекст. Клиент должен знать о различиях между стратегиями,
            // чтобы сделать правильный выбор.
            var context = new Context();

            Console.WriteLine("Однозначное число");
            context.SetStrategy(new SingleDigit());
            context.Action();

            Console.WriteLine();

            Console.WriteLine("Двухзначное число");
            context.SetStrategy(new DoubleDigit());
            context.Action();

            Console.WriteLine();

            Console.WriteLine("Многозначное число");
            context.SetStrategy(new ManyDigit());
            context.Action();
        }
    }

















 


}
