using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public  class Program
    {
        public  int num1 = 0;
        public int num2 = 0;

        static void Main(string[] args)
        {
            Program pg = new Program(); 
          
            
            Console.WriteLine("Choose a Operation");
            Console.WriteLine("\n 1-> Addition ");
            Console.WriteLine("\n 2-> Multiplication ");
            Console.WriteLine("\n 3-> Substraction ");
            Console.WriteLine("\n 4-> Division ");
            Console.WriteLine("Enter your choice");
            int a  =  Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(a);
            switch (a)
            {
                case 1:
                    Console.WriteLine("Enter number 1");
                    pg.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    pg.num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your result: {pg.num1} + {pg.num2} = " + (pg.num1 + pg.num2));
                    break;
                case 2:
                    Console.WriteLine("Enter number 1");
                    pg.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    pg.num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your result: {pg.num1} * {pg.num2} = " + (pg.num1 * pg.num2));
                    break;
                case 3:
                    Console.WriteLine("Enter number 1");
                    pg.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    pg.num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your result: {pg.num1} - {pg.num2} = " + (pg.num1 - pg.num2));
                    break;
                case 4:
                    Console.WriteLine("Enter number 1");
                    pg.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number 2");
                    pg.num2 = Convert.ToInt32(Console.ReadLine());
                    if (pg.num2 == 0) {
                        Console.WriteLine("num2 cant br 0");
                    } else { 
                    Console.WriteLine($"Your result: {pg.num1} / {pg.num2} = " + (pg.num1 / pg.num2));
            }
                    break;
            }
            
            Console.ReadKey();

        }
    }
}
