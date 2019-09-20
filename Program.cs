using System;



namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 0;
            try
            {
                int num3 = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Divide by any other number.");
            }


            int[] joseph = new int[7];

            try
            {
                Console.WriteLine(joseph[27]);
            }
            catch (Exception ew)
            {
                Console.WriteLine(ew.Message);
            }
            finally
            {
                Console.WriteLine("A number between 0 and 6");
            }

            try
            {
                test(0);
            }
            catch(invalidTemp t)
            {
                Console.WriteLine(t.Message);
            }

           
        }
        static void test(int temp)
        {
            if(temp == 0)
            {
                throw new invalidTemp("Sorry, no zero temperature");
            }
        }
        
    }
    public class invalidTemp : Exception
    {
        public invalidTemp(string message) : base(message)
        {

        }
    }
}
