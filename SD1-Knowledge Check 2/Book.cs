using System;
namespace SD1_Knowledge_Check_2
{
	public class Book
	{
		public string Subject { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

		public Book()
		{
		}

        public Book(string subject, string title, string author, int pages )
		{
			this.Subject = subject;
			this.Title = title;
			this.Author = author;
			this.Pages = pages;
		}

		public virtual void Print()
		{
            Console.WriteLine($"Subject: {this.Subject}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Author: {this.Author}");
            Console.WriteLine($"Pages: {this.Pages}");
        }
	}
}

