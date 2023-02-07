namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Console.WriteLine("Input an integer:");

        int n=Convert.ToInt32(Console.ReadLine());

        for(int i=2; i<=n; i++)
        {
            if(n==2)
            {
                Console.WriteLine("N is prime");
                break;
            }

            if(n%i==0)
            {
                Console.WriteLine("N is non-prime");
                break;
            }

            if(n%i>0)
            {
                Console.WriteLine("N is prime");
                break;
            }
            
        }

        //Question 2
        Console.WriteLine("\nAssign an int value to N:");

        int num=Convert.ToInt32(Console.ReadLine());

        for(int i=0; i<num; i++)
        {
            for(int x=1; x<num; x++)
            {
                Console.Write("#");
            }
            Console.WriteLine("#");
        }
        
        //Question 3
        Console.WriteLine("\nAssign an int value to N:");

        int input=Convert.ToInt32(Console.ReadLine());

        for(int i=1; i<=input; i++)
        {
            Console.WriteLine("*");

            for(int x=i-1; x>=0; x--)
            {
                if(x==input-1)
                {
                    break;
                }

                Console.Write("*");
    
            }
            
        }

        //Question 4
        Console.WriteLine("\nAssign an int value to N:");

        int n1=Convert.ToInt32(Console.ReadLine());

        for(int i=1; i<=n1; i++)
        {
            for(int x=n1; x>i; x--)
            {
                Console.Write(" "); 
            }
            for(int y = 1; y<=i; y++)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }
        
    }
}
