﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Composite
{

    // Класс Контейнер содержит сложные компоненты, которые могут иметь
    // вложенные компоненты. Обычно объекты Контейнеры делегируют фактическую
    // работу своим детям, а затем «суммируют» результат.
    class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        // Контейнер выполняет свою основную логику особым образом. Он проходит
        // рекурсивно через всех своих детей, собирая и суммируя их результаты.
        // Поскольку потомки контейнера передают эти вызовы своим потомкам и так
        // далее,  в результате обходится всё дерево объектов.
        public override string Operation()
        {
            int i = 0;
            string result = "Гибрид(";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
