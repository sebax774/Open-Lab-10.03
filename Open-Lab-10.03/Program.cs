using System;



namespace Open_Lab_10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetTitle("The Return of the King");
            LOTR.SetPages(416);
            LOTR.SetCategory("Fantasy book");
            LOTR.SetAuthor("J.R.R. Tolkien");
            LOTR.SetReleaseDate( 2003);
            LOTR.PrintBookInfo();
            Console.ReadKey();
        }
    }
    class Book
    {
        public string empty = ", ";
        public string title;
        public int pages;
        public string category;
        public string author;
        public int releaseDate;

        public void SetTitle(string ttl)
        {
            title = ttl;
        }
        public void SetPages(int pgs)
        {
            if (pgs >= 0)
                pages = pgs;
            else
                pages = 1;

        }
        public void SetCategory(string ctgr)
        {
            category = ctgr;
        }
        public void SetAuthor(string athr)
        {
            author = athr;
        }
        public void SetReleaseDate(int dt)
        {
            if (dt < 1450 || dt > 2021)
                releaseDate = -1;

            else
                releaseDate = dt;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine(author + empty + title + empty + pages + empty + category + empty + releaseDate);
        }
    }
}