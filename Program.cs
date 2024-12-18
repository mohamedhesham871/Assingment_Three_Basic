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
            Console.WriteLine("enter Starting number");
            int Start = int.Parse(Console.ReadLine());
             Console.WriteLine("enter Ending number");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"The prime number between {Start} and {end} are :");
            for(int x=Start; x<=end;x++)
            {
                bool falg = false;
                for(int i=2;i<x;i++)
                {
                    if(x%i==0)
                    {  falg = true; break; }
                }
                if (!falg && x>1)
                    Console.Write($"{x} ");

            }
            #endregion
        }
    }
}

