using project1;

Library library1 = new Library();

    library1.AddBook("Danabas kendinin ehvalatlari", "Celil Memmedquluzade", 1960);
    library1.AddBook("Ferrarisini satan rahib", "Robin Sharm", 2006);
    library1.AddBook("Yalnizliqdan sizofreniyaya", "OAR", 1999);
    library1.AddBook("Xeyanet", "Elxan Elatli", 2008);
    library1.AddBook("Menim sirin portagal agacim", "Joseph Maurino", 2013);
    library1.AddBook("Antichrist", "Nitsche", 1895);

    foreach (Book book in library1.books)
    {
        Console.WriteLine(book.Title + " " + book.Author + " " + book.Year);
    }

