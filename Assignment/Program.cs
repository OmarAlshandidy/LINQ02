using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.


            //var productOutOfStock = ProductList
            //    .Where(x => x.UnitsInStock == 0).ToList();

            //foreach (var item in productOutOfStock)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var productInStock = ProductList
            //    .Where(x => x.UnitsInStock > 0 && x.UnitPrice > 3);

            //foreach (var item in productInStock)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", 
            //    "five", "six", "seven", "eight", "nine" };

            //var digits = Arr
            //    .Select((name, index) => new {Name = name, Value = index})
            //    .Where(x => x.Name.Length < x.Value)
            //    .Select(x => x.Value);

            //foreach (var Digit in digits)
            //    Console.WriteLine(Digit);

            #endregion

            #endregion
            #region  LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var firstOutOfStock = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutOfStock);
            #endregion
            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(result);


            #endregion
            #region 3. Retrieve the second number greater than 5 

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);

            #endregion
            #endregion
            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name
            //var sortedProducts = ProductList.OrderBy(x => x.ProductName);
            //foreach (var product in sortedProducts)
            //    Console.WriteLine(product);
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(word => word, new CaseInsensitiveComparer());

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var sortedProducts = ProductList
            //    .OrderByDescending(p => p.UnitsInStock).ToList();
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedDigits = Arr.OrderBy(word => word.Length)
            //    .ThenBy(word => word).ToList();

            //foreach (var word in sortedDigits)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = words.OrderBy(word => word.Length)
            //                       .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //                       .ToList();

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var sortedProducts = productList.OrderBy(p => p.Category)
            //                 .ThenByDescending(p => p.UnitPrice)
            //                 .ToList();
            #endregion


            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word.Length)
            //                     .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
            //                     .ToList();

            #endregion
            #endregion

        }
    }
}

