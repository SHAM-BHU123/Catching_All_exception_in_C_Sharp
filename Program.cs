using System;


namespace Catching_All_exception_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
      
            try {
                int a = 0;
                int div = 20 / a;
                Console.WriteLine("I am in try block");
            }

            catch(Exception)
            {
                Console.WriteLine("This block handle all the exceptioin");
            }
            finally
            {
                Console.WriteLine(" i don't want your job");
            }
        }
    }
}
