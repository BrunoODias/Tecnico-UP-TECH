using ModelsServicesInterfaces;
using System.Collections.Generic;

namespace ModelsServicesInterfaces
{
    public class ListBook
    {
        public string GenderType
        {
            get
            {
                return Gender.RemoveSpecialCharacter();
            }
        }

        public string Gender { get; set; }
        public List<Book> Books { get; set; }
    }
}
