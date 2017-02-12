﻿using System;
using System.Collections.Generic;

namespace _07.Sales_Report
{
    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleParts = Console.ReadLine()
                    .Split(' ');

                var currentSale = new Sale
                {
                    Town = currentSaleParts[0],
                    Product = currentSaleParts[1],
                    Price = decimal.Parse(currentSaleParts[2]),
                    Quantity = decimal.Parse(currentSaleParts[3])
                };

                sales.Add(currentSale);
            }

            var result = new SortedDictionary<string, decimal>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }

                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}")
            }
        }
    }
}
