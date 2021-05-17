using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModelsServicesInterfaces
{
    public class GoogleAPIConnection
    {
        public WebClient _webClient { get; set; }
        public GoogleAPIConnection(WebClient webClient)
        {
            _webClient = webClient;
        }


        private const string SearchPath = "https://www.googleapis.com/books/v1/volumes?q={term}&maxResults=40&orderBy=relevance&startIndex={startIndex}";
        private const string FindBookPath = "https://www.googleapis.com/books/v1/volumes/{Code}";
        private const string SearchAuthorParameter = "&inauthor={author}";
        private const string SearchCategoryParameter = "&subject={category}";
        private const string AddFullFilter = "&filter=full";
        private const string AddFreeFilter = "&filter=full";
        private const string AddMagazineFilter = "&printType=magazine";
        private const string AddBooksFilter = "&printType=books";
        private List<Book> Request(string url, out int totalPages) {
            try
            {
                return ConvertResponseToListBook(_webClient.DownloadString(url), out totalPages);
            }
            catch (Exception) {
                totalPages = 0;
                return null;
            }
        }
        private List<Book> ConvertResponseToListBook(string param, out int totalPages)
        {
            totalPages = 0;
            var obj = JsonConvert.DeserializeObject<dynamic>(param);
            if (obj == null || obj.totalItems < 1)
                return null;

            totalPages = Convert.ToInt32(obj.totalItems)/obj.items.Count;
            List<Book> retorno = new List<Book>();
            foreach (var current in obj.items)
            {
                try
                {
                    var book = new Book();
                    book.Code = current.id;
                    book.Name = current.volumeInfo?.title;
                    if (current.volumeInfo?.authors != null)
                    {
                        string author = "";
                        bool first = true;
                        foreach (string aut in current.volumeInfo.authors)
                        {
                            if (first)
                                first = false;
                            else
                                author += ", ";

                            author += aut;
                        }
                        book.Author = author;
                    }
                    else
                    {
                        book.Author = "Autor não identificado";
                    }
                    if (current.volumeInfo?.categories != null)
                    {
                        string categorie = "";
                        bool first = true;
                        foreach (string aut in current.volumeInfo.categories)
                        {
                            if (first)
                                first = false;
                            else
                                categorie += ", ";

                            categorie += aut;
                        }
                        book.Gender = categorie;
                    }
                    else
                    {
                        book.Gender = "Categoria não identificada";
                    }
                    book.Description = (current.volumeInfo.description) != null ? ("Não foi encontrada uma descrição") : (current.volumeInfo.description);
                    book.Thumbnail = (current.volumeInfo.imageLinks?.smallThumbnail);
                    book.Photo = (current.volumeInfo.imageLinks?.thumbnail);
                    if (current.volumeInfo.publishedDate != null)
                    {
                        book.PublishDate = Convert.ToDateTime((string)current.volumeInfo.publishedDate).ToString("MM/dd/yyyy");
                    }
                    book.Recommendation = current.volumeInfo.averageRating;
                    book.PageCount = Convert.ToInt32(current.volumeInfo.PageCount);
                    book.Publisher = current.volumeInfo.publisher;
                    book.GoogleBooksURL = current.volumeInfo.previewLink;
                    retorno.Add(book);
                }
                catch (Exception e)
                {
                    continue;
                }
            }
            return retorno;
        }
        public List<Book> GetByCategory(string term, string index, out int totalPages)
            => Request((SearchPath+SearchCategoryParameter).Replace("{term}", term).Replace("{category}", term).Replace("{startIndex}",index),out totalPages);
        public List<Book> GetByAuthor(string term, string index, out int totalPages)
            => Request((SearchPath + SearchAuthorParameter).Replace("{term}", "\"").Replace("{author}", term).Replace("{startIndex}", index), out totalPages);
        public List<Book> GetByTerm(string term, string index, out int totalPages) 
            => Request(SearchPath.Replace("{term}", term).Replace("{startIndex}", index), out totalPages);
        public List<Book> GetNewest()
        {
            int ret = 0;
            return Request(SearchPath.Replace("{term}", "-ajksdhajsldhalskjdalsjkdh14ajchcxam12313vnjswhoj3hlajhsoi").Replace("relevance", "newest").Replace("{startIndex}", "0"), out ret);
        }
    }
}
