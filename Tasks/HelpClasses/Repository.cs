﻿using System;
using System.Collections.Generic;

namespace Tasks.HelpClasses
{
    public class Repository
    {
        public List<student> Students;
        public List<Product> Products;

        public Repository()
        {
            Students = GetStudents();
            Products = GetProducts();
        }

        private static List<student> GetStudents()
        {
            List<student> students = new List<student>();

            students.Add(new student(1, $"Student1", new DateTime(2020, 1, 1)));
            students.Add(new student(2, $"Student2", new DateTime(2010, 1, 1)));
            students.Add(new student(3, $"Student3", new DateTime(2011, 1, 1)));
            students.Add(new student(4, $"Student4", new DateTime(2012, 1, 1)));
            students.Add(new student(5, $"Student5", new DateTime(2013, 1, 1)));
            students.Add(new student(6, $"Student6", new DateTime(2014, 1, 1)));
            students.Add(new student(7, $"Student7", new DateTime(2015, 1, 1)));
            students.Add(new student(8, $"Student8", new DateTime(2016, 1, 1)));
            students.Add(new student(9, $"Student9", new DateTime(2017, 1, 1)));
            students.Add(new student(10, $"Student10", new DateTime(2018, 1, 1)));
            students.Add(new student(11, $"Student11", new DateTime(2019, 1, 1)));
            students.Add(new student(12, $"Student12", new DateTime(2020, 10, 31)));

            return students;
        }

        private static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            int[] stocks = new int[] { 0, 200, 500, 600 };
            int selectedStock = 0;

            for (int i = 0; i < 20; i++)
            {
                Stock stock = new Stock(i, stocks[selectedStock]);
                products.Add(new Product(i, $"Product{i}", stock));

                selectedStock++;
                if (selectedStock > 3)
                    selectedStock = 0;
            }

            return products;
        }
    }
}
