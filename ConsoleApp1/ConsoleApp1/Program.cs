using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //Aufgabe 1
            // List<int> numbers1 = new List<int>() { 0,1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            // Console.WriteLine("\nBasic structure of LINQ : ");
            // Console.WriteLine("\n--------------------------");
            // var nQuery =
            //     from VrNum in numbers1
            //     where (VrNum % 2) == 0
            //     select VrNum;

            // foreach(int VrNum in nQuery)
            // {
            //     Console.WriteLine("{0}", VrNum);
            // }
            // Console.WriteLine("\n\n");

            // //Aufgabe 2
            // List<int> n2 = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
            //IEnumerable<int> nQuery2 =
            //    from VrNum in n2
            //    where (VrNum % 2) != 0
            //    select VrNum;

            // foreach (int VrNum in nQuery2)
            // {
            //     Console.WriteLine("{0}", VrNum);
            // }
            // Console.WriteLine("\n\n");

            // //Aufgabe 3
            // var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            // var sqNo = from int Number in arr1
            //            let sqrNo = Number * Number
            //            select new { Number, sqrNo };
            // foreach( var b in sqNo)
            // {
            //     Console.WriteLine(b);
            // }
            // //Aufgabe 4 + 6
            // int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            // var n = from x in arr1 group x by x into gruppe select gruppe;
            // foreach (var x in n)
            // {
            //     Console.WriteLine($"Zahl: {x.Key}, Anzahl: {x.Count()} Multiplikation: {x.Key * x.Count()}");
            // }
            //Aufgabe 5
            // Console.WriteLine("Wähle ein Wort aus");
            // string str = Console.ReadLine();
            // var v = from y in str group y by y into Buchstaben select Buchstaben;
            // foreach (var y in v)
            // {
            //     Console.WriteLine($"Buchstabe: {y.Key}, Anzahl: {y.Count()}");
            // }
            //Aufgabe 7
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //Console.WriteLine("Wähle den Buchtsaben, mit dem die gewünschten Städte, die ausgegeben werden starten sollen");
            //string B1 = Console.ReadLine();
            //Console.WriteLine("Wähle nun den Buchtsaben, mit dem die gewünschten Städte, die ausgegeben werden enden sollen");
            //string B2 = Console.ReadLine();
            ////Var ist ein Datentyp//Filtern einer Liste/Array nach ein oder mehr Bedinungen
            //var filtered = cities.Where(c => c.StartsWith(B1) && c.EndsWith(B2));
            //foreach (var f in filtered)
            //{
            //    Console.WriteLine(f);
            //}
            //Console.ReadLine();
            // Aufgabe 8
            //List<int> list = new List<int>();
            //Console.WriteLine("Wie viele Einträge möchtest du in deine Liste hinzufügen?");
            //int eintraege = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < eintraege; i++)
            //{
            //    Console.WriteLine("Füge jetzt nun deine gewünschten Werte in die Liste ein!");
            //    list.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            ////
            //foreach(int i in list)
            //{
            //    if(i > eintraege)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Aufgabe 9
            //List<int> n2 = new List<int>() { 20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1 };
            //Console.WriteLine("Wie viele Einträge möchtest du aus der Liste, die bis 20 geht sehen?");
            //int answer = Convert.ToInt32(Console.ReadLine()); 
            //var result = n2.Take(answer);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //Aufgabe 10
            //Console.WriteLine("Schreibe einen Satz, in dem du manche Wört bewusst in UPPER CASE schreibt.");
            //string UsersAnswer = Console.ReadLine();
            //string[] StringAnswer = UsersAnswer.Split(' ');
            //var filtered = StringAnswer.Where(s => s == s.ToUpper());
            //Console.Clear();
            //foreach(string b in filtered)
            //{

            //    Console.WriteLine(b);
            //}     
            //    //Aufgabe 11
            //    string[] arr4 = new string[4] { "cat", "dog", "cow", "tiger" };
            //    var filtered = arr4.Take(4);
            //    foreach (string s in filtered)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    Console.ReadLine();
            //}
            //Aufgabe 12
            //List<Students> stulist = new List<Students>();
            //stulist.Add(new Students {  StuName = "Joseph ", StuId = 1, GrPoint = 800 });
            //stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            //stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            //stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            //stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            //stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            //stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            //stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            //stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            //stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            //Console.WriteLine("Wähle eine Zahl zwischen 1 und 6");
            //int UsersNumber = Convert.ToInt32(Console.ReadLine());
            //var OrderByUserDescending = from s in stulist
            //                            orderby s.GrPoint 
            //                            select s;
            //foreach(var s in OrderByUserDescending)
            //{

            // Console.WriteLine(s.StuName);
            //}
            string[] arr7 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            var Elements = arr7[1].Count();
            Console.ReadLine();
                            
        }
    }
}
