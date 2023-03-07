using System;
namespace SD1_Knowledge_Check_2
{
	public class MathBook : Book
	{
		public string Topic { get; set; }

		public MathBook()
		{
		}

		public MathBook(string title, string author, string topic, int pages) : base("Math", title, author, pages)
		{
			this.Topic = topic;
		}

        public override void Print()
        {
            Console.WriteLine($"Subject: {this.Subject}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Author: {this.Author}");
            Console.WriteLine($"Topic: {this.Topic}");
            Console.WriteLine($"Pages: {this.Pages}");
        }
    }
}

