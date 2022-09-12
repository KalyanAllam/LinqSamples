// See https://aka.ms/new-console-template for more information
// https://linqsamples.com/linq-to-objects/

 Sample_Aggregate_Lambda_Simple();
Sample_Aggregate_Lambda_Seed();
Sample_Average_Lambda();
Sample_Count_Lambda(); 
Sample_LongCount_Lambda();


//Aggregate Simple
 static void Sample_Aggregate_Lambda_Simple()
{
    var numbers = new int[] { 1, 2, 3, 4, 5 };

    var result = numbers.Aggregate((a, b) => a * b);

   Console.WriteLine("Aggregated numbers by multiplication:");
    Console.WriteLine(result);
}

//Aggregate Seed
  static void Sample_Aggregate_Lambda_Seed()
{
    var numbers = new int[] { 1, 2, 3 };

    var result = numbers.Aggregate(10, (a, b) => a + b);

    Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
    Console.WriteLine(result);
}


//Average

static void Sample_Average_Lambda()
{
    int[] numbers = { 10, 10, 11, 11 };

    var result = numbers.Average();

    Console.WriteLine("Average is:");
    Console.WriteLine(result);
}


//Count

static void Sample_Count_Lambda()
{
    string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

    var result = names.Count();

    Console.WriteLine("Counting names gives:");
    Console.WriteLine(result);
}

// Use LongCount() when you expect the result to be greater than Int32.MaxValue()
static void Sample_LongCount_Lambda()
{
    // Create array which is 5 elements larger than Int32.MaxValue
    var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

    Int64 result = largeArr.LongCount();

    Console.WriteLine("Counting largeArr elements:");
    Console.WriteLine(result);
}