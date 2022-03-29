using EngsVirkeri.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EngsVirkeri.ViewModel
{
    public class ProductImagesViewModel
    {
        public List<IFormFile> Images { get; set; }
        public Product Product { get; set; }
    }
}
