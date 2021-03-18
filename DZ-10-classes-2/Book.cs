using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_classes_2
{
    class Book
    {
        Title title;
        Author autor;
        Content content;

        public Book(string title, string autor, string content)
        {
            this.title = new Title(title);
            this.autor = new Author (autor);
            this.content = new Content(content);

        }

        public void Show()
        {
            title.Show();
            autor.Show();
            content.Show();

            //Console.WriteLine(book);
        }
}
}
