using System.Text;

namespace Assingment_Three_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q13- Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.WriteLine("please Enter string : ");
            string stri = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = stri.Length-1; i >=0; i--)
            {
                sb.Append(stri[i]);
            }
            Console.WriteLine(sb.ToString());
            #endregion
        }
    }
}
