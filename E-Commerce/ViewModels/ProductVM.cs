using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Commerce.ViewModels
{
    public class ProductVM
    {
        public Product Products { get; set; }
        public IEnumerable<SelectListItem>? CategoryList { get; set; }
    }
}
