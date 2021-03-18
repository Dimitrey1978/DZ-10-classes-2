using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_classes_2
{
    class Title
    {
        string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
        }
    }
}
