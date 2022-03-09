using EngsVirkeri.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EngsVirkeri.Models
{
    public class SeedDb
    {
       
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EngsVirkeriContext(
                serviceProvider.GetRequiredService<DbContextOptions<EngsVirkeriContext>>()))
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(

                    new Product
                    {
                        Image = "~/Images/DSC_0952.JPG",
                        Title = "Röd virkad korg",
                        Description = "Korg virkad i tjockare garn som ger en bra stabilitet, korgen är 20cm i diameter och 10cm hög.",
                        Price = 149.99,
                        InStock = 1
                    },
                    new Product
                    {
                        Image = "~/Images/DSC_0954.JPG",
                        Title = "Virkade korgar stor och liten",
                        Description = "Korgar virkade i ribbon garn, håller formen bra men är ändå mjuka. Mått stor: 24cm i diameter och 20cm hög, liten; 18cm i diameter och 16cm hög",
                        Price = 249.99,
                        InStock = 2
                    },
                    new Product
                    {
                        Image = "~/Images/IMG_20170420_144726.jpg",
                        Title = "Virkade nyckelringar",
                        Description = "Virkade nyckelringar uggla.",
                        Price = 50,
                        InStock = 3
                    },
                    new Product
                    {
                        Image = "~/Images/IMG_20170420_145514.jpg",
                        Title = "Virkade nyckelringar",
                        Description = "Virkade nyckelringar blommor.",
                        Price = 150.99,
                        InStock = 6
                    },
                    new Product
                    {
                        Image = "~/Images/IMG_20170504_131313.jpg",
                        Title = "Virkade gosseugglor",
                        Description = "Virkade ugglor i olika storlekar, priset är för en stor uggla",
                        Price = 150,
                        InStock = 4
                    },
                    new Product
                    {
                        Image = "~/Images/IMG_20170426_015840.jpg",
                        Title = "Virkad mobil till barnvagn",
                        Description = "Virkad mobil att sätta på suffletten på barnvagnen, görs på beställning i dem färger man vill ha.",
                        Price = 300,
                        InStock = 0
                    },
                    new Product
                    {
                        Image = "~/Images/IMG_20171010_200746.jpg",
                        Title = "Virkad korg med läderhandtag",
                        Description = "Virkad korg i garnet ribbon med läderhantag för lite extra design.",
                        Price = 180.99,
                        InStock = 1
                    },
                    new Product
                    {
                        Image = "~/Images/IMG_20190124_205256.jpg",
                        Title = "Virkad liten mandala duk till ljus",
                        Description = "Liten duk med mandala design, perfekt att ha som dekoration under t.ex värmeljusbehållare.",
                        Price = 50.99,
                        InStock = 1
                    },
                    new Product
                    {
                        Image = "~/Images/DSC_0957.JPG",
                        Title = "Virkad snutte",
                        Description = "Virkad liten snutte, perfekt till nytillskottet i familjen.",
                        Price = 150.99,
                        InStock = 1
                    }
                );
                context.SaveChanges();
            } 

        }
    }
}
