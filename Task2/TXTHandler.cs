using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT-документ изменен");
        }

        public override void Create()
        {
            Console.WriteLine("TXT-документ создан");
        }

        public override void Open()
        {
            Console.WriteLine("TXT-документ открыт");
        }

        public override void Save()
        {
            Console.WriteLine("TXT-документ сохранен\n");
        }
    }
}
