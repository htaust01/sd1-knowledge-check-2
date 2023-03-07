using SD1_Knowledge_Check_2;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<MathBook>();
        for (int i = 1; i <= numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var mathBook = new MathBook();
            mathBook.Subject = "Math";

            Console.Write($"Enter the value for the title of math book #{i}: ");
            mathBook.Title = Console.ReadLine();
            Console.Write($"Enter the value for the author of math book #{i}: ");
            mathBook.Author = Console.ReadLine();
            Console.Write($"Enter the value for the topic of math book #{i}: ");
            mathBook.Topic = Console.ReadLine();
            Console.Write($"Enter the value for the number of pages of math book #{i}: ");
            mathBook.Pages = int.Parse(Console.ReadLine());
            Console.WriteLine();

            recordList.Add(mathBook);
        }

        // Print out the list of records using Console.WriteLine()
        foreach (var book in recordList)
        {
            book.Print();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}