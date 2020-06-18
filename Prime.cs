using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program prints Prime numbers");
            bool notPrime = false;  
            int j;  
  
            Console.Write("What is your limit:");  
            int limit = Int32.Parse(Console.ReadLine());  
  
            for (int i = 2; i <= limit; i++)  
            {  
                for (j = 2; j < i; j++)  
                {  
                    if (i % j == 0)  
                    {  
                        notPrime = true;  
                        break;  
                    }  
                }  
                  
                if (!notPrime)  
                    Console.WriteLine("{0}", j);  
                else  
                    notPrime = false;  
            }

            Console.ReadLine();
        }  
    }
}