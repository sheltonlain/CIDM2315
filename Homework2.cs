namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        string grade=Console.ReadLine();

        if(grade=="A"){
            Console.WriteLine("GPA point: 4\n");
        }
        else if(grade=="B"){
            Console.WriteLine("GPA point: 3\n");
        }
        else if(grade=="C"){
            Console.WriteLine("GPA point: 2\n");
        }
        else if(grade=="D"){
            Console.WriteLine("GPA point: 1\n");
        }
        else if(grade=="F"){
            Console.WriteLine("GPA point: 0\n");
        }
        else{
            Console.WriteLine("Wrong Letter Grade!\n");
        }


        int one, two, three;

        Console.WriteLine("Please input the first num:");
        one=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num:");
        two=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num:");
        three=Convert.ToInt16(Console.ReadLine());

        if(one>two){
            if(two>three){
                Console.WriteLine("The smallest value is: "+three);
            }
        }
        if(two>one){
            if(three>one){
                Console.WriteLine("The smallest value is: "+one);
            }
        }
        if(one>two){
            if(three>two){
                Console.WriteLine("The smallest value is: "+two);
            }
        }


        Console.WriteLine("\nPlease input a year: ");
        int year=Convert.ToInt16(Console.ReadLine());

        if(year%4==0){
            if(year%100>0){
                Console.WriteLine(year+" is a Leap Year.");
            }
            else if(year%400==0){
                Console.WriteLine(year+" is a Leap Year.");
            }
            else{
                Console.WriteLine(year+" is not a Leap Year.");
            }
        }
    }
}
