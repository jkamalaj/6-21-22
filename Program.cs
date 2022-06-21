using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    List<Book> books = new List<Book>();

            //    Library booklist = new Library();

            //    string answer;
            //    do
            //    {
            //        Console.WriteLine("Seciminizi edin");
            //        Console.WriteLine("1.Kitab daxil et.");
            //        Console.WriteLine("2.Kitab tap.");
            //        Console.WriteLine("3.Kitab sil");
            //        Console.WriteLine("4.Kitab axtar.");
            //        answer = Console.ReadLine();


            //        switch (answer)
            //        {
            //            case "1":
            //                Console.WriteLine("1.Kitabin adini daxil edin:");
            //                string name = Console.ReadLine();
            //                Console.WriteLine("2.Kitabin Authorunun adini daxil edin:");
            //                string author=Console.ReadLine();
            //                Console.WriteLine("3.Kitabin sehife sayini daxil edin:");
            //                string pagecount=Console.ReadLine();
            //                Console.WriteLine("4.Kitabin nomresini daxil edin:");
            //                string no=Console.ReadLine();

            //                break;
            //            case "2":
            //                booklist.FindAllBooksByName();
            //                break;
            //            case "3":
            //                booklist.SearchBook();
            //                break;
            //            case "4":
            //                booklist.RemoveAllBookByName();
            //                break;
            //            default:
            //                break;
            //        }

            //    } while (answer!="1" && answer!="2" && answer!="3" && answer!="4");

            //}
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("1");
            list.Add("cagatay");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

           


            ArrayList arlist5 = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            arlist5.Insert(1, "Second Item");

            foreach (var val in arlist5)
                Console.WriteLine(val);

            ArrayList arlist1 = new ArrayList()
                {
                    100, 200, 600
                };

            ArrayList arlist2 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist1.InsertRange(2, arlist2);

            foreach (var item in arlist1)
                Console.Write(item + ", ");





            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };

            arList.Remove(null); 
            arList.RemoveAt(4); 
            arList.RemoveRange(0, 2);
            foreach(var item in arList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arList.Capacity);
            Console.WriteLine(arList.Count);




            ArrayList arList2 = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f,
                    300
                };

            Console.WriteLine(arList2.Contains(300)); 
            Console.WriteLine(arList2.Contains("Bill")); 
            Console.WriteLine(arList2.Contains(10)); 
            Console.WriteLine(arList2.Contains("Steve")); 
        }
    }
}
