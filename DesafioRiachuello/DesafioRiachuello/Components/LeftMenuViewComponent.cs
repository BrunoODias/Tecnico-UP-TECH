using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModelsServicesInterfaces;

namespace DesafioRiachuello.Components
{
    public class LeftMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(List<ListBook> favorites = null) {
            if (favorites == null)
                favorites = GetDefaultModel();
            return View("LeftMenu", favorites);
        }
        private List<ListBook> GetDefaultModel()
        {
            return new List<ListBook>() {
                new ListBook(){
                    Gender = "Aventura",
                    Books = new List<Book>(){
                        new Book(){
                            Author = "JK Hollins",
                            Code = 12345,
                            Name = "Harry Potter e a Pedra Filosofal",
                            Gender = "Aventura",
                            Description = "Primeiro livro da franquia de Harry Potter",
                            isFavorite=true,
                            Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQRwQkIGIMQie0FFeqt1ezlT31BMqqbm7bCq40UNBjkuF_HnO5Dv-TM0UHNIA&usqp=CAc",
                            PublicationDate = "20/07/1994"
                        },
                        new Book(){
                            Author = "Não sei",
                            Code = 14345,
                            Name = "Percy Jackson E o Ladrão de raios",
                            Gender = "Aventura",
                            Description = "Primeiro livro da franquia de Percy Jackson"
                        },
                        new Book(){
                            Author = "Disney",
                            Code = 1265,
                            Name = "Piratas do Caribe",
                            Gender = "Aventura",
                            Description = "Primeiro livro da franquia de Piratas do Caribe"
                        },
                    }
                },
                new ListBook(){
                    Gender = "Romance",
                    Books = new List<Book>(){
                        new Book(){
                            Author = "Não sei",
                            Code = 1245,
                            Name = "Tristão e Izolda",
                            Gender = "Romance",
                            Description = "História de um casal... lorem ipsum"
                        },
                        new Book(){
                            Author = "william shakespeare ",
                            Code = 1236875,
                            Name = "Romeu e Julieta",
                            Gender = "Romance",
                            Description = "Primeiro livro da franquia de Percy Jackson"
                        },
                        new Book(){
                            Author = "Sei Não",
                            Code = 123432,
                            Name = "50 Tons de Cinza",
                            Gender = "Romance",
                            Description = "50 Tons de Cinza"
                        },
                    }
                }
            };
        }

    }
}
