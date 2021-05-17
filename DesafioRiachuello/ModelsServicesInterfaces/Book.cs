using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsServicesInterfaces
{
    public class Book
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Thumbnail { get; internal set; }
        public string PublishDate { get; set; }
        public string Recommendation { get; set; }
        public bool isFavorite { get; set; }
        public string GoogleBooksURL { get; set; }
        public bool FullVisible { get; set; }
        public int PageCount { get; internal set; }
        public string Publisher { get; internal set; }

        public string GetPhoto(bool completePhoto = false)
        {
            if (completePhoto)
            {
                if (string.IsNullOrWhiteSpace(Photo) == false)
                    return Photo;
                if (string.IsNullOrWhiteSpace(Thumbnail) == false)
                    return Thumbnail;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Thumbnail) == false)
                    return Thumbnail;
                if (string.IsNullOrWhiteSpace(Photo) == false)
                    return Photo;
            }
            return "/nophoto.jpg";
        }
    }
}
