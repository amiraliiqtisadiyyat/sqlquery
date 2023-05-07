using ConsoleApp16.Pustok.Models;
using P328Pustok.Models;

namespace ConsoleApp16.Pustok.ViewModels
{
    public  class HomeViewModel
    {
        public List<Book> FeaturedBoooks { get; set; }
        public List<Book> NewBoooks { get; set; }
        public List<Book> DiscountedBoooks { get; set; }
    }
}
