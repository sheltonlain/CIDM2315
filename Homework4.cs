class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Input an integer");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input an integer");
        int b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {Compare(a,b)}");


        //Q2
        Console.WriteLine("\nInput an integer");
        int s=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type \"right\" or \"left\"");
        string shape=Console.ReadLine();
        
        Console.WriteLine($"N is: {s}; shape is {shape}");
        
        Triangle(s,shape);
    }

    static int Compare(int x, int y)
    {
        if(x>y)
        {
            return x;
        }
        else if(x<y)
        {
            return y;
        }
        else if(x==y)
        {
            return x;
        }
        return 0;
    }

    static void Triangle(int x, string y)
    {
        if(y=="right")
        {
            for(int i=1; i<=x; i++)
            {
                for(int w=x; w>i; w--)
                {
                    Console.Write(" "); 
                }
                for(int o = 1; o<=i; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        else if(y=="left")
        {
            for(int i=1; i<=x; i++)
            {
                Console.WriteLine("*");

                for(int p=i-1; p>=0; p--)
                {
                    if(p==x-1)
                    {
                    break;
                    }

                Console.Write("*");
    
                }         
            }
        }
    }
}





