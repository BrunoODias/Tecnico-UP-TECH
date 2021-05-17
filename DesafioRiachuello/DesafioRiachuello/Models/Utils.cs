using ModelsServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioRiachuello.Models
{
    public static class Utils
    {
        public static List<ListBook> getListListBook(List<Book> books)
        {
            List<ListBook> toDisplay = new List<ListBook>();
            if (books != null && books.Count > 0)
            {
                List<string> categories = new List<string>();
                foreach (var book in books)
                {
                    if (categories.Contains(book.Gender) == false)
                        categories.Add(book.Gender);
                }

                foreach (var category in categories)
                {
                    toDisplay.Add(
                        new ListBook()
                        {
                            Gender = category,
                            Books = books.FindAll(x => x.Gender == category)
                        }
                    );
                }
            }
            return toDisplay;
        }
    }
}
