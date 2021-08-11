using System;
using System.Collections.Generic;

namespace Soluitionists.Products.Core
{
    public static class ProductsData
    {
        public static IReadOnlyDictionary<Guid, Product> LoadDataSet()
        {
            return new Dictionary<Guid, Product> ()
            {
                { new Guid("6A2FFA8D-2226-40C7-A24A-61DED316CCA0"), 
                    new Product (new Guid("6A2FFA8D-2226-40C7-A24A-61DED316CCA0"), "Apple", 4, "URL", 2.5m)
                },
                { new Guid("F3BD3E81-019C-4C7E-9401-DF8652B33F1A"),
                    new Product (new Guid("F3BD3E81-019C-4C7E-9401-DF8652B33F1A"), "Orange", 2, "URL", 3.5m)
                },
                { new Guid("7FAB08D2-BB9D-4694-AF26-16BFBA834C29"),
                    new Product (new Guid("7FAB08D2-BB9D-4694-AF26-16BFBA834C29"), "Milk", 4, "URL", 3.5m)
                },
                { new Guid("5F307890-9C25-4399-A5F2-BB36C835836C"),
                    new Product (new Guid("5F307890-9C25-4399-A5F2-BB36C835836C"), "Bread", 4, "URL", 1.5m)
                },
                { new Guid("8F435450-F093-49E5-BBCD-7B49D00DC628"),
                    new Product (new Guid("8F435450-F093-49E5-BBCD-7B49D00DC628"), "Beer", 4, "URL", 10.5m)
                },
                { new Guid("196679C6-A399-4C68-9084-14F56ACCDD79"),
                    new Product (new Guid("196679C6-A399-4C68-9084-14F56ACCDD79"), "Chips", 4, "URL", 2.5m)
                },
                { new Guid("FF114DC2-4720-45A8-904F-E4465C70117A"),
                    new Product (new Guid("FF114DC2-4720-45A8-904F-E4465C70117A"), "Hummus", 4, "URL", 12.5m)
                },
                { new Guid("4CC39F0B-F16E-4953-9696-63D5B1EBC3BF"),
                    new Product (new Guid("4CC39F0B-F16E-4953-9696-63D5B1EBC3BF"), "Cream", 4, "URL", 4.5m)
                }
            };
        }
    }
}
