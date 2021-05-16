using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsServicesInterfaces
{
    public class Book
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string PublicationDate { get; set; }
        public bool isFavorite { get; set; }
    }
}
