using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
                {
                    Name = "Tesla Model X",
                    Description = "The Tesla Model X is a battery electric mid-size luxury crossover produced by Tesla, Inc. since 2015. ",
                    ImageFile = "product-1.png",
                    Price = 40.000M,
                    Category = "Hybrid"
                },
            new Product()
                {
                    Name = "Audi Q8",
                    Description = "The Audi Q8 is a mid-size luxury crossover SUV coupé made by Audi that was launched in 2018.",
                    ImageFile = "product-2.png",
                    Price = 84.000M,
                    Category = "Diesel"
                },
            new Product()
                {
                    Name = "Mercedes-Benz GLA",
                    Description = "The Mercedes-Benz GLA is a subcompact luxury crossover SUV manufactured and marketed by Mercedes-Benz over two generations.",
                    ImageFile = "product-3.png",
                    Price = 75.000M,
                    Category = "Diesel"
                },
            new Product()
                {
                    Name = "Fiat 500",
                    Description = "The Fiat 500 is a rear-engined, four-seat, small city car that was manufactured and marketed by Fiat Automobiles from 1957 until 1975 over a single generation in two-door saloon and two-door station wagon bodystyles.",
                    ImageFile = "product-4.png",
                    Price = 22.000M,
                    Category = "Petrol"
                },
            new Product()
                {
                    Name = "Chery Tiggo 5",
                    Description = "The Chery Tiggo 5 is a compact crossover produced by Chery under the Tiggo product series.",
                    ImageFile = "product-5.png",
                    Price = 38.000M,
                    Category = "Diesel/Hybrid"
                },
            new Product()
                {
                    Name = "Jeep Compass",
                    Description = "The Jeep Compass is a compact crossover SUV introduced for the 2007 model year,and is now in its second generation. ",
                    ImageFile = "product-6.png",
                    Price = 44.000M,
                    Category = "Hybrid"
                }
    
        };
    }
}