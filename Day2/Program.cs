using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class person {
        public int Age;
    }
    internal class Program
    {
        public enum ShipMethod
        {
            Laod = 1,
            Register = 2,
            Execute = 3


        }
        static void Main(string[] args)
        {
            //  string name1 = "jeet";
            //  string name2 = " R ";
            //  String name3 = "kini";


            //  string name = string.Format("My name is {0}{1}{2}",name1,name2,name3);
            //  Console.WriteLine(name);

            //  String[] s = new string[3] { "hii","hello","bye"};
            //  var s1 = string.Join(",",s);
            //  Console.WriteLine(s1);
            ////  int[] i = new int[3] { 1,2,3};
            //  var ii = string.Join(",", i);
            //  Console.WriteLine(ii);

            //  String ss = "hii\n my name is jeet\n I am an Developer.  ";
            //  Console.WriteLine(ss);

            //  var method = ShipMethod.Execute;
            //  Console.WriteLine((int)method);
            //  var id = 2;
            //  Console.WriteLine((ShipMethod)id);

            //  Console.WriteLine("Converted");
            //  var methoddname = "Execute";
            //  var result=(ShipMethod)Enum.Parse(typeof(ShipMethod),methoddname);
            //  Console.WriteLine(result);

            //  Console.WriteLine("Types :");

            //  int number1 = 1;
            //  Increment(number1);
            //  Console.WriteLine(number1);

            //  person p = new person();
            // p.Age = 20;
            //  Console.WriteLine(p.Age);
            //  Console.WriteLine(Obj(p.Age));


            //Task:

            //  var user = Console.ReadLine();
            // var result1 = (user =="10") ? "Valid" : "Invalid";
            // Console.WriteLine(result1);

            //Console.WriteLine("Conditional Statement");

            //int a=Convert.ToInt32(Console.ReadLine());
            // int b = Convert.ToInt32(Console.ReadLine());
            // int c = 0;

            // if (a >= b)
            // { c = a; }
            // else if (b >= a)
            //     c = b;
            // else {
            //     Console.WriteLine("Both Number are Same");
            // }
            // Console.WriteLine("Largest is "+c);

            //Console.WriteLine("Enter the height");
            //int h=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Width");
            //int w = Convert.ToInt32(Console.ReadLine());
            //if (h > w)
            //{
            //    Console.WriteLine("It is Portriat");
            //}
            //else if (w > h)
            //{
            //    Console.WriteLine("It is Landscape");
            //}
            //else
            //{
            //    Console.WriteLine("Cannot be  determine");
            //}

            // Console.WriteLine("Enter the Speed Limit");
            // int speed=Convert.ToInt32(Console.ReadLine());  
            //Console.WriteLine("Enter the Speed of the  Car");
            // int speedCar = Convert.ToInt32(Console.ReadLine());

            // if (speed > speedCar)
            // {
            //     Console.WriteLine("OK");
            //     return;

            // }
            // else
            // {
            //     int km=5;
            //     int dp = (speedCar - speed) / km;
            //     if (dp > 12)
            //     {
            //         Console.WriteLine("Your License Suspended");
            //     }
            //     else {

            //         Console.WriteLine(dp);
            //     }

            // }

            var nn = "jeet kini";
            //for (var v = 0; v < nn.Length; v++)
            //{
            //    Console.WriteLine(nn[v]);
            //}

            //foreach (var na in nn)
            //{
            //    Console.WriteLine(na);
            //}
            // To Generate ramdom otp..

            //Random r = new Random();
            //Console.WriteLine(r.Next(1000,9999));//random digits

            //To generate random characters;
            //for (int c = 0; c < 4; c++)
            //{
            //    Console.Write((char)+'a'+r.Next(0,32));
            //}

            //int count = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            //var user =Console.ReadLine();
            //while (user != "ok")
            //{
            //    Console.WriteLine("Enter the number");
            //   user= Console.ReadLine();

            //}
            //int p = 1;
            //int input=Convert.ToInt32(Console.ReadLine());   
            //for (int i = 1; i  <=input; i++)
            //{
            //    p = p * i;
            //}
            //Console.WriteLine(p);

            //To pick random number;

            //Random r= new Random();
            //int s = r.Next(1,10);
            //int user = 0;
            //int i = 1;
            //while (i < 5)
            //{
            //    if (s == user)
            //    {
            //        Console.WriteLine("You Won");
            //        break;
            //    }
            //    i++;
            //    Console.WriteLine("Enter the number");
            //    user = Convert.ToInt32(Console.ReadLine());
            //}


            // var user=Console.ReadLine();

            // var numb = user.Split(',');
            // var max = Convert.ToInt32(numb[0]);
            // foreach (var n in numb) { 
            //var num=Convert.ToInt32(n);
            //     if (max < num)
            //     {
            //         max = num;
            //     }

            // }
            //Console.WriteLine(max);

            int[] array = new int[5] { 1, 3, 4, 6, 8 };

            //indexof method
            //  Console.WriteLine(Array.IndexOf(array, 6));

            //clear();
            Array.Clear(array, 0, 3);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //copy
            int[] array1 = new int[3];
            //Array.Copy(array, array1, 3);
            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Reverse(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Sort(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //List

            //var list = new List<int>() {1,2,3,5,4 };
            //list.Add(8);
            //list.AddRange(new int[3] {  2, 2 ,6});
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //list.RemoveAt(3);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //if we want to remove all 2 object from list 
            //for (int i = 0; i <list.Count; i++)
            //{
            //    if (list[i] == 2)
            //    {
            //        list.Remove(list[i]);
            //    }
            //}
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            var list = new List<int>() { 1, 2, 3, 5, 4, 2 };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == 2)
            //    {
            //        list.Remove(list[i]);
            //    }
            //}
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //list.Clear();
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //List Exercise:

            //var l=new List<string>();

            //while(true) {
            //    Console.WriteLine("Enter the Name");
            //   var  user = Console.ReadLine();

            //    if (String.IsNullOrEmpty(user))
            //    {
            //        break;
            //    }
            //    else {

            //       l.Add(user);
            //    }

            //}
            //switch (l.Count)
            //{

            //    case 0:
            //        Console.WriteLine("None like your post");
            //        break;

            //        case 1:
            //        Console.WriteLine("Your Friend" + l[0]);
            //        break;
            //        case 2:
            //        Console.WriteLine("Your Frined " + l[1] +" " + l[0]);
            //        break;
            //    default:
            //        Console.WriteLine("Many More Like your post" + l[0] + l[1]+ l[l.Count-2]);
            //        break;
            //}

            //var name=Console.ReadLine();
            //string s = "";
            //for (int i = name.Length-1; i>=0; i--)

            //{ 
            //  s=s+ name[i]; 
            //}
            //Console.WriteLine(s);

            //var l= new List<int>();
            // while (l.Count < 5)
            // {
            //     Console.WriteLine("Enter the  Number");
            //     var s=Convert.ToInt16(Console.ReadLine());
            //     if (l.Contains(s))
            //     {
            //         Console.WriteLine("Error Occured");
            //     }
            //     else { 
            //     l.Add(s);
            //     }
            // }

            // l.Sort();   
            // foreach (int i in l)
            // {
            //     Console.WriteLine(i);
            // }

            //var unique = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Enter a number ");
            //    var input = Console.ReadLine();

            //    if (input.CompareTo("exit") == 0)
            //        break;
            //    else
            //    {
            //        var number = Convert.ToInt32(input);
            //        if (unique.Contains(number))
            //            continue;
            //        else
            //            unique.Add(number);
            //    }
            //}

            //foreach (var output in unique)
            //    Console.Write("{0} ", output);

          








        }

       












    






    }
    //static public int Increment(int num)
    //{
    //    num = num + 10;
    //    return num; }
    //static public int Obj(int num)
    //{
    //    num = num + 10;
    //    return num;
    //}
}


