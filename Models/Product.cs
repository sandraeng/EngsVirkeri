using System;
using System.ComponentModel.DataAnnotations;

namespace EngsVirkeri.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required, Display(Name = "Titel")]
        public string Title { get; set; }
        [Required, Display(Name = "Beskrivning")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency), Display(Name = "Pris")]
        public double Price { get; set; }
        [Required]
        [Display(Name ="I Lager")]
        public int InStock { get; set; }

        public string ImagePath
        {
            get
            {
                return @"C:\CodeSkola\ASP.NET-MVC\EngsVirkeri\wwwroot\Images\DSC_0952.JPG";
            }

        }
    }
}
