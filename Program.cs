using System.Text;

namespace Assingment_Three_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("please Enter string : ");
            //string stri = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();
            //for (int i = stri.Length-1; i >=0; i--)
            //{
            //    sb.Append(stri[i]);
            //}
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q14:Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("please Enter intger : ");
            //int number = int.Parse(Console.ReadLine());
            //StringBuilder sb = new StringBuilder();
            //while(number>0)
            //{
            //    sb.Append(number%10);
            //    number /= 10;
            //}
            //Console.WriteLine(int.Parse(sb.ToString()));

            #endregion

            #region Q15: Write a program in C# Sharp to find prime numbers within a range of numbers
            //Console.WriteLine("enter Starting number");
            //int Start = int.Parse(Console.ReadLine());
            // Console.WriteLine("enter Ending number");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The prime number between {Start} and {end} are :");
            //for(int x=Start; x<=end;x++)
            //{
            //    bool falg = false;
            //    for(int i=2;i<x;i++)
            //    {
            //        if(x%i==0)
            //        {  falg = true; break; }
            //    }
            //    if (!falg && x>1)
            //        Console.Write($"{x} ");

            //}
            #endregion

            #region Q16:Write a program in C# Sharp to convert a decimal number into binary without using an array
            //Console.WriteLine("enter number to convert it to Binary ");
            //int x=int.Parse(Console.ReadLine());
            //StringBuilder sb = new StringBuilder();
            //while (x>0)
            //{

            //     if (x / 2.0 == x / 2)
            //    {
            //        sb.Insert(0, 0);
            //    }
            //    else
            //    {
            //        sb.Insert(0, 1);
            //    }
            //    x /= 2;


            //}
            //int Binrynumber =int.Parse(sb.ToString());
            //Console.WriteLine($"The Binary of {x} is {Binrynumber}");
            #endregion

            #region Q17:Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.WriteLine("enter x and y  of point1 : ");
            string point1 = Console.ReadLine();
            double pointX1 = double.Parse(point1.Split(' ')[0]);
            double pointY1 = double.Parse(point1.Split(' ')[1]);

            Console.WriteLine("enter x and y of point2 : ");
            string point2 = Console.ReadLine();
            double pointX2 = double.Parse(point2.Split(' ')[0]);
            double pointY2 = double.Parse(point2.Split(' ')[1]);

            Console.WriteLine("enter xand y of point3 : ");
            string point3 = Console.ReadLine();
            double pointX3 = double.Parse(point3.Split(' ')[0]);
            double pointY3 = double.Parse(point3.Split(' ')[1]);

            // calculate if they on same line
            double area = 0.5 * Math.Abs(pointX1 * (pointY2 - pointY3) + pointX2 * (pointY3 - pointY1) + pointX3 * (pointY1 - pointY2));
            if(area==0)
            {
                Console.WriteLine("they are on same Line");
            }
            else
            {
                Console.WriteLine("they not on same Line");
            }

            #endregion
        }
    }
}

