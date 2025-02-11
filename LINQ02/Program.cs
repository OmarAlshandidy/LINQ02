using System.Collections;
using System.ComponentModel.DataAnnotations;
using static LINQ02.ListGenerator;

namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session02
            #region Filteration - Where


            // Filteration - Where/ OfType

            // Get Product Which In Out Of Stock
            //Fleunt Syntax 

            // var result =   ProductList.Where(P => P.UnitsInStock == 0);


            //Query Syntex [Query Exprition ]

            //var result = from P in ProductList
            //             where P.UnitsInStock == 0
            //            
            //             select  P;

            //  var result = ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;
            //  var result = ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;


            //indexed Where Valid Only Fluent Syntax
            //Can`t Be Written Using Query Syntax 
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P, Index) => Index < 5 );
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);

            // var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, I) => I < 5);


            // ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };

            //var result = arrayList.OfType<int>();
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }

            //Get All  Product Which price Geater Than 30
            //var result = ProductList.w
            #endregion

            #region Transformtion Operator - Select , Select Many
            //Fluent Syntex
            //var result = ProductList.Select(P => P);
            // var result = ProductList.Select(P => P.ProductName);
            // Query Syntex
            //var result = from P in ProductList
            //             select P.ProductName;
            //var result = ProductList.Where(P=>P.UnitsInStock>0&& P.Category== "Seafood")
            //    .Select(P=> new {
            //                        P.ProductName,
            //                            P.Category,
            //                            OldPrice = P.UnitPrice,
            //                            NewPrice = P.UnitPrice *0.1M});

            // Query Syntax
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice =P.UnitPrice - P.UnitPrice * 0.1M
            //             };



            // SelectMany Fluent Syntax 
            //var result = CustomerList.Select(C => C.CustomerName);
            //var result = CustomerList.Select(C => C.Orders); // if one of property is Sequnce
            //  var result = CustomerList.SelectMany(C => C.Orders);// if one of property is Sequnce


            //SelectMany Query Syntax 

            //var result = from C in CustomerList
            //             from O in C.Orders 
            //             select O;

            // Indexed Select Vailed Only In  Fluent Syntax 
            // Can`t Be Wrriten Query Syntax [Query Expression]
            //  var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion
            #region Ordering Operators 
            //   var result = ProductList.OrderBy(P => P.UnitPrice);
            //   var result = ProductList.OrderByDescending(P => P.UnitPrice);
            //var result = ProductList.OrderByDescending(P => P.UnitPrice)
            //    .ThenBy(P => P.UnitPrice)
            //    .ThenBy(P=> P.UnitsInStock)
            //    .Select(P => new { P.ProductName, P.UnitsInStock });

            //var result = from P in ProductList
            //             orderby P.UnitPrice
            //             select new { P.ProductName, P.UnitPrice, P.UnitsInStock };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Elements Operators - Immdiate Exection 
            //var result = ProductList.First(); /// May Throw Exeption 
            //var result = new ProductList.Last();
            //var result = ProductList.First(P=> P.UnitsInStock==1000); /// May Throw Exeption 
            //var result = ProductList.Last(P => P.UnitsInStock == 0); /// May Throw Exeption 

            // var result = ProductList.FirstOrDefault(new Product() { ProductName =  " Defult Product"}  );

            // Elmenent 

            //  var result = ProductList.ElementAt(0); // May Throw Exception [Index Was Out Of Range]
            //var result = ProductList.ElementAtOrDefault(1);
            //var result = ProductList.Single(); // May Throw Exception 

            //var result = ProductList.SingleOrDefault();// May Throw Exception
            //  Sequence contains more than one element
            // Return Defult Value [Null] if The Sequence Is Empty 
            //  var result = ProductList.DefaultIfEmpty();
            //
            //Console.WriteLine(result?.ProductName??"Na");
            #endregion
            #region Aggregate Operator - Immediate Execution 
            // Count - Sum - Max - Min - Avg 

            //  var result = ProductList.Count;

            //var result = ProductList.Count(p => p.UnitsInStock == 0); //5

            //Sum 
            //var result = ProductList.Sum(P => P.UnitPrice);//2222.7100
            // var result = ProductList.Sum(P=> P.UnitsInStock);//3180

            //Avg
            // var result = ProductList.Average(P => P.UnitPrice);//28.866363636363636363636363636

            //Max

            //   var result = ProductList.Max(); //263.50 , Based On IComparable (Price)
            //var result = ProductList.Max(new ProductCompareUnitInStock() ); //125 , Based On IComparable (UnitInStock)


            //var maxprice = ProductList.Max(P=>P.UnitPrice);
            //var result = ProductList.Where(P => P.UnitPrice == maxprice);
            //  var result = ProductList.MaxBy(P=>P.UnitPrice);

            /// ====== Min==========

            //var result = ProductList.Min();
            //    var result = ProductList.Min(new ProductCompareUnitInStock() );
            //  var result = ProductList.Min(new ProductCompareNameLength());
            // var result = ProductList.Max(new ProductCompareNameLength());
            // var result = ProductList.Min(P => P.UnitPrice);//2.5000

            // var result = ProductList.MinBy(P => P.ProductName,new ProductCompareNameLength());

            // Aggregate 

            // List<string> list = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };
            //var result = list.Aggregate ((S01, S02) => $"{S01},{S02}");



            //Console.WriteLine(result);
            #endregion
            #region Casting Operators -  Immediate Execution 
            //List<Product> list =  (List<Product>)ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //foreach (var product in list)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Generation Operators  
            // the only way to call this  method as -> class member throught  "enumerable" class

            // Range - Empty - Repeat
            //var result = Enumerable.Range(1, 100);
            //var result = Enumerable.Empty<Product>().ToList();
            //result.Add(new Product() { ProductName = "Product01" });
            //result.Add(new Product() { ProductName = "Product02" });

            //var result = Enumerable.Repeat(1, 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Set  Operators - Union Family 
            // Union - Unoin All - Intersect - Execpt
            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var result = Seq01.Union(Seq02);// Like Union in SQl Without Doublication 
            //var result = Seq01.Concat(Seq02);// Like UnionAll in SQl Without Doublication 
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} "); 
            //}

            #endregion
            #region Quantifiers Operators  - Return  Boolean
            //Any  - All  -  SequenceEqual - Contains
            // var Seq01 = Enumerable.Range(1, 100);
            // var Seq02 = Enumerable.Range(50, 100);

            //  Any --> return True if There Are At Least One Element [In Sequence Or Match the Condidtion ]
            // var result = Seq01.Any(N=>N%2==0);
            //  var result = ProductList.Any();

            //All()  ---> Retutn true All Element In The Sequence Match The Conditions Or Sequence  Is  Empty
            // var result = ProductList.All(p => p.UnitsInStock == 0);
            // var result = Seq01.SequenceEqual(Seq02);

            // Console.WriteLine(result);
            #endregion
            #region Zipping Operators
            //Zip
            //  List<string> words = new List<string>() { "Ten", "Twenty", "thirty", "Foutry" };
            //  List<int> numbers = new List<int>() { 10,20,30,40,50,60 };
            //  var result = words.Zip(numbers, (W, N) => $"{N}-->{W}");
            //foreach ( var i in result )
            //  {
            //      Console.WriteLine(i);

            //}
            #endregion
            #region Partioning  Operartor - Take ,TakeLast ,Skip  , SkipLast ,TAKE While , SkipWhile
            //var result = ProductList.Where(P=>P.UnitsInStock ==  0).Take(3);
            //var result = ProductList.Where(P => P.UnitsInStock == 0).TakeLast(3);
            //  var result = ProductList.TakeLast(3);
            //var result = ProductList.Skip(10);

            //int[] numbers = { 9,6, 1, 2, 4, 5 };
            // var result= numbers.TakeWhile((N)=>N%3==0); 
            // var result = numbers.SkipWhile((N) => N % 3 == 0);
           /// var result = numbers.TakeWhile((N,I) => N >I);
           // var result = numbers.SkipWhile((N, I) => N > I);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
    }
}
