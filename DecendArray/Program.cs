using System;

namespace DecendArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] newNumbers = new int[14] { 4, 8, 5, 4, 9, 5, 73, 9, 2, 65, 43, 24, 16, 76 };
            int i,j, num;
            Console.WriteLine("Elements: \n");
            for (i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine("{0}", newNumbers[i]);
            }

            
            for ( i = 0; i < newNumbers.Length; i++)
                { 
                    for (j = i+1; j< newNumbers.Length; j++)
                    {
                      if( newNumbers[i] < newNumbers[j])
                    {
                        num = newNumbers[i];
                        newNumbers[i] = newNumbers[j];
                        newNumbers[j] = num;

                    }
                }
            }
            Console.WriteLine("\nDescending order : \n");
            for (i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine("{0}", newNumbers[i]);
            }
            Console.WriteLine("\n\n");
           
        
           
        }
    }
}