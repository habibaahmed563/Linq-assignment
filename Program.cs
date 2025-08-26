
using System.ComponentModel;
using System.Globalization;
using static Linq_assignment.ListGenerator;
namespace Linq_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators 
            //LiNQ - Restriction Operators 

            //1. 
            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //2.
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.UnitPrice > 3.00M
            //             select P;

            //foreach(var item in result )
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            /* --------------------------------------------------------------*/

            #region Element Operators

            //LiNQ - Element Operators 

            //1.

            //var result = (from P in ProductList
            //              where P.UnitsInStock == 0
            //              select P).First();


            //2.

            //var result = (from P in ProductList
            //              where P.UnitPrice > 1000
            //              select P).FirstOrDefault();

            //Console.WriteLine(result); 
            #endregion

            /* --------------------------------------------------------------*/

            #region Aggregate Operators 
            //LINQ - Aggregate Operators 

            //1.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result =( from P in Arr
            //             where P % 2 != 0
            //             select P).Count();

            //2.

            //var result = (from P in Arr
            //              select P).Sum();

            //Console.WriteLine(result);

            //3.

            //String[] Words = File.ReadAllLines("dictionary_english.txt");
            //var result = (from W in Words
            //              select W.Length).Sum();
            //Console.WriteLine(result);

            //4.

            //string[] Words = File.ReadAllLines("dictionary_english.txt");
            //var result = (from W in Words
            //              select W.Length).Min();
            //Console.WriteLine(result);

            //5.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into newcategory
            //             select new
            //             {
            //                 Category = newcategory.Key,
            //                 TotalUnits = newcategory.Sum(x => x.UnitsInStock)
            //             };
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Category} , {item.TotalUnits}");
            //}


            //6.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into N
            //             select new
            //             {
            //                 Category = N.Key,
            //                 ChepestPrice = N.Min(x => x.UnitPrice)
            //             };
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Category}, {item.ChepestPrice}");
            //}

            //7.

            //var result = from P in ProductList
            //             group P by P.Category into N
            //             let MinPrice = N.Min(x => x.UnitPrice)
            //             from P in N
            //             where P.UnitPrice == MinPrice
            //             select new
            //             {
            //                 Category = N.Key,
            //                 Product = P.ProductName,
            //                 Price=P.UnitPrice
            //             };
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item.Category} , {item.Product} , {item.Price}");
            //}

            //8.

            //var result = from P in ProductList
            //             group P by P.Category
            //             into N
            //             select new
            //             {
            //                 Category = N.Key,
            //                 Avgprice = N.Average(x => x.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} , {item.Avgprice}");
            //} 
            #endregion

            /* --------------------------------------------------------------*/

            #region Ordering Operators 

            //LiNQ - Ordering Operators 

            //1. 

            //var result = from P in ProductList
            //             orderby P.ProductName
            //             select P;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.

            //var result = from P in ProductList
            //             orderby P.UnitsInStock descending
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.

            //string[] Arr = { "Zero", "One", "two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            //var result = from P in Arr
            //             orderby P.Length, P
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.

            //var result = from P in ProductList
            //             orderby P.Category, P.UnitPrice descending
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BIUeBeRrY", "CIOvEr", "cHeRry" };
            //var result = from P in Arr
            //             orderby P.Length, P.ToLower() descending
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //6.

            //string[] Arr = { "Zero", "One", "two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            //var result = (from P in Arr
            //              where P.Length > 0 && P[1] == 'i'
            //              select P).Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            /* --------------------------------------------------------------*/

            #region Transformation Operators 
            //LINQ - Transformation Operators 

            //1.

            //var result = from P in ProductList
            //             select P.ProductName;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.

            //string[] Words = { "aPPLe", "BlUeBeRrY", "cHeRry" };
            //var result = from W in Words
            //             select new
            //             {
            //                 UpperCase = W.ToUpper(),
            //                 LowerCase = W.ToLower()
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" UpperCase : {item.UpperCase} , LowerCase : {item.LowerCase}");
            //}

            //3.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };
            //Console.WriteLine("Pairs where a<b");
            //foreach(var item in result )
            //{
            //    Console.WriteLine($" {item.A } is less than {item.B} ");
            //} 
            #endregion

            /* --------------------------------------------------------------*/

            #region Set Operators 
            //LiNQ - Set Operators 

            // 1. 

            //var result = (from P in ProductList
            //              select P.Category).Distinct();
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2.

            //var result01 = from P in ProductList
            //               select P.ProductName[0];
            //var result02 = from C in CustomerList
            //               select C.CustomerName[0];
            //var result = result01.Union(result02);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.
            //var result = result01.Intersect(result02);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.
            //var result = result01.Except(result02);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            /* --------------------------------------------------------------*/

            #region Partitioning Operators 

            //LiNQ - Partitioning Operators 

            //1.

            //var result = (from C in CustomerList
            //              where C.City == "Washinton"
            //              from O in C.Orders
            //              select O).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.OrderID);
            //}

            //2.
            //var result = (from C in CustomerList
            //              where C.City == "Washinton"
            //              from O in C.Orders
            //              select O).Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //3.

            //int[] numbers = { 5, 3, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = (from n in numbers.Select((num, I) => new { num, I })
            //              select n.num)
            //             .TakeWhile(x => x >= numbers.ToList().IndexOf(x));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = (from n in numbers
            //              select n).SkipWhile(n => n % 3 != 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            /* --------------------------------------------------------------*/

        }
    }
}
