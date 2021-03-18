using System;

namespace DZ_10_classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Название книги";
            string author = "Автор книги";
            string content = "Текст книги";

            Book book = new Book(title, author, content);
            book.Show();
            //Console.WriteLine("Hello World!");
        }
    }
}
