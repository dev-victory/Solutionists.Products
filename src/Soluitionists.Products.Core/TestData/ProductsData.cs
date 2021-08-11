using System;
using System.Collections.Generic;

namespace Soluitionists.Products.Core
{
    public static class ProductsData
    {
        private static Random random = new();
        private static readonly string imageProviderBaseUrl = "https://spoonacular.com/cdn/ingredients_100x100/";

        public static IReadOnlyDictionary<Guid, Product> LoadDataSet()
        {
            return new Dictionary<Guid, Product>()
            {
                { Guid.Parse("6A2FFA8D-2226-40C7-A24A-61DED316CCA0"),
                    new(
                        Guid.Parse("6A2FFA8D-2226-40C7-A24A-61DED316CCA0"),
                        "Apple", random.Next(0, 10),
                        $"{imageProviderBaseUrl}apple.jpg",
                        2.5m)
                },
                { Guid.Parse("F3BD3E81-019C-4C7E-9401-DF8652B33F1A"),
                    new(
                        Guid.Parse("F3BD3E81-019C-4C7E-9401-DF8652B33F1A"),
                        "Orange",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}orange.jpg",
                        3.5m)
                },
                { Guid.Parse("7FAB08D2-BB9D-4694-AF26-16BFBA834C29"),
                    new(
                        Guid.Parse("7FAB08D2-BB9D-4694-AF26-16BFBA834C29"),
                        "Milk",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}milk.jpg",
                        3.5m)
                },
                { Guid.Parse("5F307890-9C25-4399-A5F2-BB36C835836C"),
                    new(
                        Guid.Parse("5F307890-9C25-4399-A5F2-BB36C835836C"),
                        "Bread",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}bread.jpg",
                        1.5m)
                },
                { Guid.Parse("8F435450-F093-49E5-BBCD-7B49D00DC628"),
                    new(
                        Guid.Parse("8F435450-F093-49E5-BBCD-7B49D00DC628"),
                        "Beer",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}beer.jpg",
                        10.5m)
                },
                { Guid.Parse("196679C6-A399-4C68-9084-14F56ACCDD79"),
                    new(
                        Guid.Parse("196679C6-A399-4C68-9084-14F56ACCDD79"),
                        "Chips",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}chips.jpg",
                        2.5m)
                },
                { Guid.Parse("FF114DC2-4720-45A8-904F-E4465C70117A"),
                    new(
                        Guid.Parse("FF114DC2-4720-45A8-904F-E4465C70117A"),
                        "Hummus",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}sauce.jpg",
                        12.5m)
                },
                { Guid.Parse("4CC39F0B-F16E-4953-9696-63D5B1EBC3BF"),
                    new(
                        Guid.Parse("4CC39F0B-F16E-4953-9696-63D5B1EBC3BF"),
                        "Cream",
                        random.Next(0, 10),
                        $"{imageProviderBaseUrl}cream.jpg",
                        4.5m)
                }
            };
        }
    }
}
