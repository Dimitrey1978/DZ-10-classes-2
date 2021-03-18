using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_classes_2
{
    class Author
    {
        string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
        }
    }
}
