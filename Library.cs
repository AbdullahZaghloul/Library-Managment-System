namespace Library_Managment_System
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);

        }

        public bool SearchBook(string titleOrAuthor)
        {
            bool found = false;

            foreach (Book book in books)
            {
                if (book.GetTitle().ToLower().Contains(titleOrAuthor.ToLower())
                || book.GetAuthor().ToLower().Contains(titleOrAuthor.ToLower()))
                    found = true;
            }
            return found;
        }

        public void BorrowBook(string titleOrAuthor)
        {
            bool searchResult = SearchBook(titleOrAuthor); //check if the book is exist or not
            if (searchResult)
            {
                foreach (Book book in books) // get this book and set it is availability to false
                {
                    if (book.GetTitle().ToLower().Contains(titleOrAuthor.ToLower())
                    || book.GetAuthor().ToLower().Contains(titleOrAuthor.ToLower()))
                    {
                        book.SetAvailability(false);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("This book is not in the library");
            }
        }
        public void ReturnBook(string titleOrAuthor)
        {
            bool searchResult = SearchBook(titleOrAuthor); //check if the book is exist or not
            if (searchResult)
            {
                foreach (Book book in books) // get this book and check it is availability if false set it true again
                {
                    if (book.GetTitle().ToLower().Contains(titleOrAuthor.ToLower())
                    || book.GetAuthor().ToLower().Contains(titleOrAuthor.ToLower()))
                    {
                        if (book.GetAvailability() == false)
                            book.SetAvailability(true);
                        else
                            Console.WriteLine("This book is not borrowed");
                        break;
                    }

                }
            }
            else
                Console.WriteLine("This book is not borrowed");

        }


    }
}
