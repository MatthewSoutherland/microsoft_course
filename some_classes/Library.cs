using System;
using System.Collections;

public class LibraryBook
{
    private string _title;
    private string _author;
    private int _numPages;
    private string _borrower;

    public LibraryBook(string title, string author, int numPages)
    {
        _title = title;
        _author = author;
        _numPages = numPages;
        _borrower = null;
        Console.WriteLine("Constructor triggered");
    }

    public string Title
    {
        get
        {
            Console.WriteLine("Title getter triggered");
            return _title;
        }
        private set
        {
            Console.WriteLine("Title setter triggered");
            _title = value;
        }
    }

    public string Author
    {
        get
        {
            Console.WriteLine("Author getter triggered");
            return _author;
        }
        private set
        {
            Console.WriteLine("Author setter triggered");
            _author = value;
        }
    }

    public int NumPages
    {
        get
        {
            Console.WriteLine("NumPages getter triggered");
            return _numPages;
        }
        private set
        {
            Console.WriteLine("NumPages setter triggered");
            _numPages = value;
        }
    }

    public bool Borrow(string borrower)
    {
        if (_borrower == null)
        {
            _borrower = borrower;
            Console.WriteLine($"{_borrower} has checked out: {_title}");
            return true;
        }
        else
        {
            Console.WriteLine($"This book is checked out by: {_borrower}");
            return false;
        }
    }

    public bool Return()
    {
        if (_borrower != null)
        {
            _borrower = null;
            Console.WriteLine($"{_title} has been returned");
            return true;
        }
        else
        {
            Console.WriteLine("Book is not checked out");
            return false;
        }
    }

    public bool IsAvailable()
    {
        if (_borrower == null)
        {
            Console.WriteLine("Book is available");
            return true;
        }
        else
        {
            Console.WriteLine($"{_borrower} has this book");
            return false;
        }
    }
}
