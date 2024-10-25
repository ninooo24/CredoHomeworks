using System;
using System.Collections.Generic;

public class Book
{
    private string _title;
    private string _author;
    private string _isbn;
    private int _copiesAvailable;

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            if (value.Length < 1 || value.Length > 50)
                throw new ArgumentException("Title must be at least 3 characters long and cannot exceed 50 characters.");
            _title = value;
        }
    }

    public string Author
    {
        get
        {
            return _author;
        }
        set
        {
            if (value.Length < 3 || value.Length > 100)
                throw new ArgumentException("Author's name must have a minimum of 3 characters.");
            _author = value;
        }
    }

    public int CopiesAvailable
    {
        get
        {
            return _copiesAvailable;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("CopiesAvailable cannot be negative.");
            if (value > 500)
                throw new ArgumentException("CopiesAvailable cannot exceed 500.");
            _copiesAvailable = value;
        }
    }

    public string ISBN
    {
        set
        {
            if (value.Length != 13 || !long.TryParse(value, out _))
                throw new ArgumentException("ISBN must be a 13-digit number.");
            _isbn = value;
        }
    }

    public Book(string title, string author, string isbn, int copiesAvailable)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        CopiesAvailable = copiesAvailable;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nISBN: {_isbn}\nCopies Available: {CopiesAvailable}");
    }

    public bool BorrowBook()
    {
        if (CopiesAvailable > 0)
        {
            CopiesAvailable --;
            Console.WriteLine($"{Title} has been borrowed. Copies left: {CopiesAvailable}");
            return true;
        }
        else
        {
            Console.WriteLine($"No copies of {Title} are available for borrowing.");
            return false;
        }
    }

    public void ReturnBook()
    {
        CopiesAvailable++;
        Console.WriteLine($"{Title} has been returned. Copies available now: {CopiesAvailable}");
    }
}

public class Library
{
    private List<Book> books;
    public Library()
    {
        books = new List<Book>(); // Initialize the books list
    }
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");

    }

    public void RemoveBook(Book book) 
    { 
        books.Remove(book);
        Console.WriteLine($"Book '{book.Title}' removed to the library");

    }

    public void DisplayAllBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }
    }

    // searchis functionali vikitxe :(
    public Book SearchBookByTitle(string title)
    {
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }
        return null;
    }

    internal void RemoveBook(string? title)
    {
        throw new NotImplementedException();
    }
}

// class program gamichirda da ragac  nawilebi vikitxe
class Program
{
    static void Main()
    {
        Library library = new Library();
        string option;

        do
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();
            if (option == "1")
            {
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter Author: ");
                string author = Console.ReadLine();
                Console.Write("Enter ISBN: ");
                string isbn = Console.ReadLine();
                int copiesAvailable;

                while (true)
                {
                    Console.Write("Enter Copies Available: ");
                    if (int.TryParse(Console.ReadLine(), out copiesAvailable) && copiesAvailable >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a valid number of copies available (0 or more).");
                }

                Book newBook = new Book(title, author, isbn, copiesAvailable);
                library.AddBook(newBook);
            }
            else if (option == "2")
            {
                library.DisplayAllBooks();
            }
            else if (option == "3")
            {
                Console.Write("Enter the title of the book to borrow: ");
                string title = Console.ReadLine();
                Book book = library.SearchBookByTitle(title);
                if (book != null)
                {
                    if (book.BorrowBook())
                    {
                        Console.WriteLine($"{book.Title} has been successfully borrowed.");
                    }
                    else
                    {
                        Console.WriteLine($"No copies of {book.Title} are available for borrowing.");
                    }
                }
                else
                {
                    Console.WriteLine($"Book with title '{title}' not found.");
                }
            }
            else if (option == "4")
            {
                Console.Write("Enter the title of the book to return: ");
                string title = Console.ReadLine();
                Book book = library.SearchBookByTitle(title);
                if (book != null)
                {
                    book.ReturnBook();
                    Console.WriteLine($"{book.Title} has been successfully returned.");
                }
                else
                {
                    Console.WriteLine($"Book with title '{title}' not found.");
                }
            }
            else if (option == "5")
            {
                Console.Write("Enter the title of the book to remove: ");
                string title = Console.ReadLine();
                library.RemoveBook(title);
            }
        } while (option != "6");

        Console.WriteLine("Exiting the library system. Goodbye!");
    }
}