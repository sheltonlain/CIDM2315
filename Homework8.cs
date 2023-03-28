namespace Homework8;
class Program
{
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
            Console.Write(num +" ");
        }  
    }




    // **Compete the following methods, then run the program to check outputs**
    // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array)
    {
        //put your answer below
        int sum= int_array.Sum();
        Console.WriteLine("The sum of int_array is: "+sum);
    }

    //Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[ , ] array_2d)
    {
        //put your answer below
        foreach(int val in array_2d)
        {
            if(val%2>0)
            {
                Console.Write(val +" ");
            }
        }  
    }
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] array_2d)
    {
        //put your answer below 
        int sum = 0;
        foreach(int item in array_2d)
        {
            sum+=item;
        }
            return sum;
    }

    // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[ , ] DoubleArray(int[ , ] array_2d)
    {
        int n;
         //put your answer below
        for(int row=0; row<3; row++)
        {
            for(int col=0; col<3; col++)
            {
              n=array_2d[row,col];
              n*=2;
              array_2d[row,col]=n;  
            }
        }
        return array_2d;
       
    }  



  
}
