namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Console.WriteLine("Input an integer:");
        int input1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input an integer:");
        int input2=Convert.ToInt32(Console.ReadLine());

        int result=Compare(input1, input2);

        Console.WriteLine($"\na = {input1}; b = {input2}");
        Console.WriteLine($"The largest number is: {result}\n");

        //Question 2
        Console.WriteLine("Input an integer:");
        int input3=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input an integer:");
        int input4=Convert.ToInt32(Console.ReadLine());                

        int result2=Compare(input3, input4);

        int max=Compare(result,result2);

        Console.WriteLine($"\na = {input1}; b = {input2}; c = {input3}; d = {input4}");
        Console.WriteLine($"The largest number is: {max}\n");    

        //Question 3
        createAccount();    
    }

    //Questions 1 and 2 Method
    static int Compare(int a, int b)
    {
        int largest;

        if(a>b)
        {
            largest=a;
        }
        else
        {
            largest=b;
        }

        return largest;
           
        }
        //Question 3 Methods
        static bool checkAge(int birth_year)
        {
            int age=2023-birth_year;

            if(age>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void createAccount()
        {
            Console.WriteLine("Enter Your Username:");
            string username=Console.ReadLine();

            Console.WriteLine("Enter Your Password:");
            string password=Console.ReadLine();

            Console.WriteLine("Enter Your Password Again:");
            string password_confirm=Console.ReadLine();

            Console.WriteLine("Enter Your Birthyear:");
            int birthyear=Convert.ToInt32(Console.ReadLine());

            bool test=checkAge(birthyear);

            if(test==true)
            {
                if(password==password_confirm)
                {
                    Console.WriteLine("\nAccount is created successfully");
                }
                else
                {
                    Console.WriteLine("\nWrong password");
                }
            }
            else
            {
                Console.WriteLine("\nCould not create an account");
            }
    
    }
}
