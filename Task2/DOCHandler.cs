using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC-документ изменен");
        }

        public override void Create()
        {
            Console.WriteLine("DOC-документ создан");
        }

        public override void Open()
        {
            Console.WriteLine("DOC-документ открыт");
        }

        public override void Save()
        {
            Console.WriteLine("DOC-документ сохранен\n");
        }
    }
}
