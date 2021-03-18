using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_classes_2
{
    class Content
    {
        string content;

        public Content (string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
        }
    }
}
