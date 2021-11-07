using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var phoneBook = new PhoneBook();
            phoneBook.DisplayList();
            System.Console.WriteLine();
            phoneBook.SortByName();
            phoneBook.DisplayList();
System.Console.WriteLine("Table");
            phoneBook.FillTable();
            phoneBook.DisplayTable();
        
        }
    }
}
