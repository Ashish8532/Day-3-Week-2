using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price is Required!")]
        [Range(0, 99999999.99, ErrorMessage = "Invalid Target Price; Max 10 digits")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required!")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [NotMapped]
        public string? CategoryName { get; set; }
    }
}
