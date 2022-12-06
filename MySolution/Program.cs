class Program
{
    public static void Main()
    {
        var fibonacciResults = FibonnaciSequence(8);
        foreach (var item in fibonacciResults)
        {
            Console.WriteLine(item);
        }
        
        
        var result  = BlowBirthdayCandles(7, new List<int> { 3,2,1,3,6,2,1 });
        Console.WriteLine($"Number of Candles blown is {result}");
        Console.ReadLine();

        MinMax(new List<int> { 1,3,5,7,9});
    }

    static List<int> FibonnaciSequence(int number)
    {
        if (number <= 0) return new();
        
        if (number == 1)
        {
            return new List<int> { 0};
        }
        
        if (number == 2)
        {
            return new List<int> { 0,1};
        }
        
        List<int> results = new();
        results.Add(0);
        results.Add(1);

        for (int i = 3; i <= number; i++)
        {
            var count = results.Count;
            results.Add(results[count - 1] + results[count - 2]);
        }

        return results;
    }

    static int BlowBirthdayCandles(int height, List<int> candleHeights)
    {
        for (var i = height; i >= 1; i--)
        {
            var topHeights = candleHeights.FindAll(e => e == i);
            if (topHeights.Count > 0)
            {
                return topHeights.Count;
            }
        }

        return 0;

    }

    static void MinMax(List<int> arr)
    {
        arr.Sort();
        var min = 0;
        var max = 0;
        
        for (int i = 0; i < 4; i++)
        {
            
            var endIndex = arr.Count - 1;

            min += arr[i];
            max += arr[endIndex];


        }

        Console.WriteLine($"Min: {min}, Max: {max}");}
    }


    
    
    
    //Attempt all questions

/*QUESTION 1

Fibonacci Sequence is a series of numbers in which the next number is gotten by adding up the two numbers before it
0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
Write a method that when passed a number returns the Fibonacci series whose length is equal to the number passed

*/

/* QUESTION 2

You are in charge of the cake for your niece's birthday and have decided the cake will
 have one candle for each year of her total age. When she blows out the candles, 
 she’ll only be able to blow out the tallest ones.
  Your task is to find out how many candles she can successfully blow out.

For example, if your niece is turning 4 years old, 
and the cake will have 4 candles of height 4,4 ,1 ,3 , 
she will be able to blow out 2 candles successfully, 
since the tallest candles are of height of height 4 and there are 2 such candles.

Example 2: 
4
3,2,1,3 
The result is 2 because the tallest candles are of height 3 and they are only 2.

Example 3:
7
3,2,1,3,6,2,1
The result is 1 because the tallest candle is of height 6 and there's only 1.

*/

/* QUESTION 3

Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

For example, ar = [1,3,5,7,9]. Our minimum sum is 1+3+5+7 =16 and our maximum sum is 3+5+7+9 =24 . We would print {min:16, max:24 }

*/
