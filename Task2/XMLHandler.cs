using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML-документ изменен");
        }

        public override void Create()
        {
            Console.WriteLine("XML-документ создан");
        }

        public override void Open()
        {
            Console.WriteLine("XML-документ открыт");
        }

        public override void Save()
        {
            Console.WriteLine("XML-документ сохранен\n");
        }
    }
}
