namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            Add( 8, 9);
            Add( 2.3m, 5.7m);
            Add(0, 1, true);
            
        }
        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 + num2);
        }
        
        public static void Add(int num1, int num2, bool isMoney)
            {
             
                int total= num1 + num2;
                if (isMoney == true && total > 1) 

                {
                Console.WriteLine($"{total} dollars");
                }
                else if (total == 1 && isMoney == true)
                    
                {
                    Console.WriteLine($"{total} dollar");
                }
                else
                {
                    Console.WriteLine($"{total}");
                }
                


            }
        
    }
}
