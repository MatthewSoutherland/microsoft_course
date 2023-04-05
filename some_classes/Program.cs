using System;

var book_one = new LibraryBook("Slave runner", "Harriot Tubman", 122);
var book_two = new LibraryBook("Victim_Hood", "Al Sharpton", 222);
var book_three = new LibraryBook("Mind_comp", "Adolph Hitler", 1240);

Console.WriteLine(book_one.Author);

Console.WriteLine(book_three.NumPages);

book_two.Borrow("Libral Liz");
book_two.Borrow("Libral Amy");

book_two.Return();

book_one.Borrow("Tyron Bigums");

book_one.IsAvailable();

book_three.Borrow("SkinHead Larry");