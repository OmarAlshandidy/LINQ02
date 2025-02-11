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
            #region Aggregate Operators

            #region  Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(num => num % 2 != 0);
            //Console.WriteLine(Result);
            #endregion

            #region list of customers and how many orders each has.
            //var Result = CustomerList.Select(c => new { cutomre=c, totalOreders=c.Orders.Count() });
            //foreach (var item in Result) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Return a list of categories and how many products each has
            //    var Result=ProductList.GroupBy(p=>p.Category).Select(c=>new {category = c.Key ,countProducts= c.Count() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result=Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region Get the total number of characters of all words in dictionary_english.txt 
            //var Result = EnglishDictionary.Sum(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region  Get the length of the shortest word in dictionary_english.txt
            //var Result = EnglishDictionary.MinBy(w => w.Length);
            //Console.WriteLine(Result.length);
            #endregion

            #region Get the length of the longest word in dictionary_english.txt
            //var Result = EnglishDictionary.MaxBy(w => w.Length);
            //Console.WriteLine(Result.Length);
            #endregion

            #region Get the average length of the words in dictionary_english.txt
            //var Result = EnglishDictionary.Average(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region Get the total units in stock for each product category.
            //var Resulr = ProductList.GroupBy(p => p.Category)
            //                       .Select(c => new { category=c.Key , totalUnites = c.Sum(c=>c.UnitsInStock)});
            //foreach (var item in Resulr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the cheapest price among each category's products
            //var Result = ProductList.GroupBy(p => p.Category)
            //                       .Select(c => new { Category = c.Key, cheapestPrice = c.MinBy(p => p.UnitPrice).UnitPrice });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Get the products with the cheapest price in each category
            //var Result = from p in ProductList
            //             group p by p.Category
            //             into category
            //             select new
            //             {
            //                 category = category.Key,
            //                 cheapestPrice = category.MinBy(p => p.UnitPrice).UnitPrice
            //             };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the most expensive price among each category's products.
            //var Result = ProductList.GroupBy(p => p.Category)
            //                    .Select(c => new { Category = c.Key, expensivePrice = c.MaxBy(p => p.UnitPrice).UnitPrice });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the products with the most expensive price in each category.
            //var Result = ProductList.GroupBy(p => p.Category)
            //                       .Select(C => new { Category = C.Key, MaxPriceProduct = C.MaxBy(p => p.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the average price of each category's products.
            //var Result = ProductList.GroupBy(p => p.Category)
            //                      .Select(c => new { Category = c.Key, AvgPrice = c.Average(p => p.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
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
            #region Transformation Operators

            #region  Return a sequence of just the names of a list of products.
            //var Result = ProductList.Select(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(w => new { uppercase = w.ToUpper(), lowercase = w.ToLower() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((num, index) => $"{num}:{num == index}");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };
            //Result = numbersA.SelectMany(n => numbersB, (a, b) => new { a, b }).Where(num => num.a < num.b);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.a} is less than {item.b}");
            //}
            #endregion

            #region Select all orders where the order total is less than 500.00.
            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select all orders where the order was made in 1998 or later
            // var Result=CustomerList.SelectMany(C => C.Orders).Where(O=>O.OrderDate >= new DateTime(1998,1,1,0,0,0));
            //foreach(var O in Result)
            //{
            //    Console.WriteLine(O);
            //}
            #endregion
            #endregion
            #region Set Operators
            #region  Find the unique Category names from Product List
            //var Result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Produce a Sequence containing the unique first letter from both product and customer names
            //var Result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length-3, 3)).Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length-3, 3)));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion#region Set Operators
            #region  Find the unique Category names from Product List
            //var Result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Produce a Sequence containing the unique first letter from both product and customer names
            //var Result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length-3, 3)).Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length-3, 3)));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
#endregion

        }
    }
}

