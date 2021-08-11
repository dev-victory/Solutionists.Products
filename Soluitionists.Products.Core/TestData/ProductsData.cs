using System;
using System.Collections.Generic;

namespace Soluitionists.Products.Core
{
    public static class ProductsData
    {
        private static Random random = new Random();

        public static IReadOnlyDictionary<Guid, Product> LoadDataSet()
        {
            return new Dictionary<Guid, Product>()
            {
                { new Guid("6A2FFA8D-2226-40C7-A24A-61DED316CCA0"),
                    new Product (
                        new Guid("6A2FFA8D-2226-40C7-A24A-61DED316CCA0"),
                        "Apple", random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/apple.jpg",
                        2.5m)
                },
                { new Guid("F3BD3E81-019C-4C7E-9401-DF8652B33F1A"),
                    new Product (
                        new Guid("F3BD3E81-019C-4C7E-9401-DF8652B33F1A"),
                        "Orange",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/orange.jpg",
                        3.5m)
                },
                { new Guid("7FAB08D2-BB9D-4694-AF26-16BFBA834C29"),
                    new Product (
                        new Guid("7FAB08D2-BB9D-4694-AF26-16BFBA834C29"),
                        "Milk",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/milk.jpg",
                        3.5m)
                },
                { new Guid("5F307890-9C25-4399-A5F2-BB36C835836C"),
                    new Product (
                        new Guid("5F307890-9C25-4399-A5F2-BB36C835836C"),
                        "Bread",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/bread.jpg",
                        1.5m)
                },
                { new Guid("8F435450-F093-49E5-BBCD-7B49D00DC628"),
                    new Product (
                        new Guid("8F435450-F093-49E5-BBCD-7B49D00DC628"),
                        "Beer",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/beer.jpg",
                        10.5m)
                },
                { new Guid("196679C6-A399-4C68-9084-14F56ACCDD79"),
                    new Product (
                        new Guid("196679C6-A399-4C68-9084-14F56ACCDD79"),
                        "Chips",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/chips.jpg",
                        2.5m)
                },
                { new Guid("FF114DC2-4720-45A8-904F-E4465C70117A"),
                    new Product (
                        new Guid("FF114DC2-4720-45A8-904F-E4465C70117A"),
                        "Hummus",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/sauce.jpg",
                        12.5m)
                },
                { new Guid("4CC39F0B-F16E-4953-9696-63D5B1EBC3BF"),
                    new Product (
                        new Guid("4CC39F0B-F16E-4953-9696-63D5B1EBC3BF"),
                        "Cream",
                        random.Next(0, 10),
                        "https://spoonacular.com/cdn/ingredients_100x100/cream.jpg",
                        4.5m)
                }
            };
        }
    }
}
