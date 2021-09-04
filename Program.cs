using System;

namespace Params
{
    class Program
    {
        class param
        {
            public int even(params int[] lst)
            {
                int count = 0;

                foreach (int x in lst)
                {
                    
                    if (x%2==0)
                    {
                        count++;
                        Console.WriteLine($"{count}:{x}");
                    }
                 
                }
                return 0;
                
            }
        }
        static void Main(string[] args)
        {

            param obj = new param();
            Console.WriteLine(obj.even(20,34, 7,32,15,9));
            
        }
    }
}
