using System;
using System.Linq;

namespace query
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 20);
            }
                
            var query = from i in numbers
                        orderby i ascending
                        select i;
                      


            foreach (var item in query)
            {
                Console.WriteLine($"{item}");
            }
            query = from i in numbers
                    where i % 2== 0
                    orderby i ascending
                    select i;
            Console.WriteLine("luwi");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }



            string[] text = { "bindis feria sofeli", "tandatan ufro", "binddeba", "ra aris chveni sicocxle", "wava da gagvifrindeba" };
            var stringQuery = from t in text
                              let words = t.Split('a', 'e', 'i', 'o', 'u')
                              from word in words
                              select word;

            foreach (var item in stringQuery)
            {
                Console.Write(item);
            }
            

                              
        }
    }
}
