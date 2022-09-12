﻿// See https://aka.ms/new-console-template for more information
// https://linqsamples.com/linq-to-objects/

 

 Sample_Aggregate_Lambda_Simple();
Sample_Aggregate_Lambda_Seed();
Sample_Average_Lambda();
Sample_Count_Lambda(); 
//Sample_LongCount_Lambda();
Sample_Max_Lambda();
Sample_Min_Lambda();
Sample_Sum_Lambda();
Sample_AsEnumerable_Lambda();
Sample_Cast_Lambda();
Sample_Cast_Linq();
Sample_OfType_Lambda();
Sample_OfType_Linq();
Sample_ToArray_Lambda();
Sample_ToArray_Linq();
Sample_ToDictionary_Lambda_Conditional();
Sample_ToDictionary_Linq_Conditional();
Sample_ToList_Lambda();
Sample_ToLookup_Lambda();
Sample_ElementAt_Lambda();
Sample_ElementAtOrDefault_Lambda();
Sample_First_Lambda_Simple();
Sample_First_Lambda_Conditional();
Sample_FirstOrDefault_Lambda();
Sample_Last_Lambda();
Sample_LastOrDefault_Simple();
Sample_LastOrDefault_Conditional();
Sample_Single_Lambda();
Sample_SingleOrDefault_Lambda();
Sample_DefaultIfEmpty_Lambda_Simple();
Sample_DefaultIfEmpty_Lambda_DefaultValue();
Sample_Empty_Lambda();
Sample_Range_Lambda();
Sample_Range_Linq();
Sample_Repeat_Lambda();
Sample_Repeat_Linq();
Sample_GroupBy_Lambda();
Sample_GroupBy_Linq();
Sample_Join_Lambda();
Sample_Join_Linq();
Sample_OrderBy_Lambda_Numbers();
Sample_OrderBy_Linq_Numbers();
Sample_OrderBy_Lambda_Dates();
Sample_OrderBy_Linq_Dates();
Sample_OrderByDescending_Lambda();
Sample_OrderByDescending_Linq();
Sample_Reverse_Lambda();
Sample_Reverse_Linq();
Sample_ThenBy_Lambda();
Sample_ThenBy_Linq();
Sample_ThenByDescending_Lambda();
Sample_ThenByDescending_Linq();
Sample_Concat_Lambda_Numbers();
Sample_Concat_Lambda_Strings();
Sample_SequenceEqual_Lambda();
Sample_Zip_Lambda();


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


//Max

static void Sample_Max_Lambda()
{
    int[] numbers = { 2, 8, 5, 6, 1 };

    var result = numbers.Max();

    Console.WriteLine("Highest number is:");
    Console.WriteLine(result);
}


//Min
static void Sample_Min_Lambda()
{
    int[] numbers = { 6, 9, 3, 7, 5 };

    var result = numbers.Min();

    Console.WriteLine("Lowest number is:");
    Console.WriteLine(result);
}


//Sum


static void Sample_Sum_Lambda()
{
    int[] numbers = { 2, 5, 10 };

    var result = numbers.Sum();

    Console.WriteLine("Summing the numbers yields:");
    Console.WriteLine(result);
}

//AsEnumerable

static void Sample_AsEnumerable_Lambda()
{
    string[] names = { "John", "Suzy", "Dave" };

    var result = names.AsEnumerable();

    Console.WriteLine("Iterating over IEnumerable collection:");
    foreach (var name in result)
        Console.WriteLine(name);
}



// Note: The source we're casting from must contain only elements of the same type.
static void Sample_Cast_Lambda()
{
    List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

    var result = vegetables.Cast<string>();

    Console.WriteLine("List of vegetables casted to a simple string array:");
    foreach (string vegetable in result)
        Console.WriteLine(vegetable);
}



// Note: The source we're casting from must contain only elements of the same type.
static void Sample_Cast_Linq()
{
    List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

    var result = from v in vegetables.Cast<string>()
                 select v;

    Console.WriteLine("List of vegetables casted to a simple string array:");
    foreach (string vegetable in result)
        Console.WriteLine(vegetable);
}



static void Sample_OfType_Lambda()
{
    object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

    var result = objects.OfType<string>();

    Console.WriteLine("Objects being of type string have the values:");
    foreach (string str in result)
        Console.WriteLine(str);
}



static void Sample_OfType_Linq()
{
    object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

    var result = from o in objects.OfType<string>()
                 select o;

    Console.WriteLine("Objects being of type string:");
    foreach (string str in result)
        Console.WriteLine(str);
}


static void Sample_ToArray_Lambda()
{
    int[] numbers = { 1, 2, 3, 4 };

    var result = numbers.ToArray();

    Console.WriteLine("New array contains identical values:");
    foreach (int number in result)
        Console.WriteLine(number);
}


static void Sample_ToArray_Linq()
{
    int[] numbers = { 1, 2, 3, 4 };

    var result = from n in numbers.ToArray<int>()
                 select n;

    Console.WriteLine("New array contains identical values:");
    foreach (int number in result)
        Console.WriteLine(number);
}


static void Sample_ToDictionary_Lambda_Conditional()
{
    int[] numbers = { 1, 2, 3, 4 };

    var result = numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even");

    Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
    foreach (var dic in result)
        Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
}


static void Sample_ToDictionary_Linq_Conditional()
{
    int[] numbers = { 1, 2, 3, 4 };

    var result = from n in numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even")
                 select n;

    Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
    foreach (var dic in result)
        Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
}



static void Sample_ToList_Lambda()
{
    string[] names = { "Brenda", "Carl", "Finn" };

    List<string> result = names.ToList();

    Console.WriteLine(String.Format("names is of type: {0}", names.GetType().Name));
    Console.WriteLine(String.Format("result is of type: {0}", result.GetType().Name));
}


static void Sample_ToLookup_Lambda()
{
    string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

    var result = words.ToLookup(w => w.Length);

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(String.Format("Elements with a length of {0}:", i));
        foreach (string word in result[i])
            Console.WriteLine(word);
    }
}


static void Sample_ElementAt_Lambda()
{
    string[] words = { "One", "Two", "Three" };

    var result = words.ElementAt(1);

    Console.WriteLine("Element at index 1 in the array is:");
    Console.WriteLine(result);
}

static void Sample_ElementAtOrDefault_Lambda()
{
    string[] colors = { "Red", "Green", "Blue" };

    var resultIndex1 = colors.ElementAtOrDefault(1);

    var resultIndex10 = colors.ElementAtOrDefault(10);

    Console.WriteLine("Element at index 1 in the array contains:");
   Console.WriteLine(resultIndex1);

    Console.WriteLine("Element at index 10 in the array does not exist:");
    Console.WriteLine(resultIndex10 == null);
}


// Note: Operator First will throw an exception, if there is not at least one element in the sequence.
static void Sample_First_Lambda_Simple()
{
    string[] fruits = { "Banana", "Apple", "Orange" };

    var result = fruits.First();

    Console.WriteLine("First element in the array is:");
    Console.WriteLine(result);
}


static void Sample_First_Lambda_Conditional()
{
    string[] countries = { "Denmark", "Sweden", "Norway" };

    var result = countries.First(c => c.Length == 6);

    Console.WriteLine("First element with a length of 6 characters:");
    Console.WriteLine(result);
}


// Note: While First() will throw an exception if array...
//       ...is empty, FirstOrDefault gracefully returns null.
static void Sample_FirstOrDefault_Lambda()
{
    string[] countries = { "Denmark", "Sweden", "Norway" };
    string[] empty = { };

    var result = countries.FirstOrDefault();

    var resultEmpty = empty.FirstOrDefault();

    Console.WriteLine("First element in the countries array contains:");
    Console.WriteLine(result);

    Console.WriteLine("First element in the empty array does not exist:");
    Console.WriteLine(resultEmpty == null);
}


static void Sample_Last_Lambda()
{
    int[] numbers = { 7, 3, 5 };

    var result = numbers.Last();

    Console.WriteLine("Last number in array is:");
    Console.WriteLine(result);
}


// Note: While Last will throw an exception if array...
//       ...is empty, LastOrDefault gracefully returns null.
static void Sample_LastOrDefault_Simple()
{
    string[] words = { "one", "two", "three" };
    string[] empty = { };

    var result = words.LastOrDefault();

    var resultEmpty = empty.LastOrDefault();

    Console.WriteLine("Last element in the words array contains:");
    Console.WriteLine(result);

    Console.WriteLine("Last element in the empty array does not exist:");
    Console.WriteLine(resultEmpty == null);
}


// Note: While Last will throw an exception if array...
//       ...is empty, LastOrDefault gracefully returns null.
static void Sample_LastOrDefault_Conditional()
{
    string[] words = { "one", "two", "three" };

    var result = words.LastOrDefault(w => w.Length == 3);

    var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

    Console.WriteLine("Last element in the words array having a length of 3:");
    Console.WriteLine(result);

    Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
    Console.WriteLine(resultNoMatch == null);
}


// Note: Single will throw an Exception, if there is not exactly one element in the array.
static void Sample_Single_Lambda()
{
    string[] names1 = { "Peter" };
    string[] names3 = { "Peter", "Joe", "Wilma" };
    string[] empty = { };

    var result1 = names1.Single();

    Console.WriteLine("The only name in the array is:");
    Console.WriteLine(result1);

    try
    {
        // This will throw an exception because array contains no elements
        var resultEmpty = empty.Single();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    try
    {
        // This will throw an exception as well because array contains more than one element
        var result3 = names3.Single();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


// Note: SingleOrDefault retrieves null value if array is empty, and...
//       ...throws an exception if array contains more than one element.
static void Sample_SingleOrDefault_Lambda()
{
    string[] names1 = { "Peter" };
    string[] names3 = { "Peter", "Joe", "Wilma" };
    string[] empty = { };

    var result1 = names1.SingleOrDefault();

    var resultEmpty = empty.SingleOrDefault();

    Console.WriteLine("The only name in the array is:");
    Console.WriteLine(result1);

    Console.WriteLine("As array is empty, SingleOrDefault yields null:");
    Console.WriteLine(resultEmpty == null);

    try
    {
        // This will throw an exception as well because array contains more than one element
        var result3 = names3.SingleOrDefault();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void Sample_DefaultIfEmpty_Lambda_Simple()
{
    string[] emptyStr = { };
    int[] emptyInt = { };
    string[] words = { "one", "two", "three" };

    var resultStr = emptyStr.DefaultIfEmpty(); // Default is null for string

    var resultInt = emptyInt.DefaultIfEmpty(); // Default is 0 for int

    var resultWords = words.DefaultIfEmpty(); // Not empty, so words array is just copied

    Console.WriteLine("resultStr has one element with a value of null:");
    Console.WriteLine(resultStr.Count() == 1 && resultStr.First() == null);

    Console.WriteLine("resultInt has one element with a value of 0:");
    Console.WriteLine(resultInt.Count() == 1 && resultInt.First() == 0);

    Console.WriteLine("resultWords has same content as words array:");
    Console.WriteLine(resultWords.SequenceEqual(words));
}


static void Sample_DefaultIfEmpty_Lambda_DefaultValue()
{
    int[] empty = { };

    var result = empty.DefaultIfEmpty(5);

    Console.WriteLine("result contains one element with a value of 5:");
    Console.WriteLine(result.Count() == 1 && result.First() == 5);
}


static void Sample_Empty_Lambda()
{
    var empty = Enumerable.Empty<string>();
    // To make sequence into an array use empty.ToArray()

    Console.WriteLine("Sequence is empty:");
    Console.WriteLine(empty.Count() == 0);
}


static void Sample_Range_Lambda()
{
    var result = Enumerable.Range(0, 10);

    Console.WriteLine("Counting from 0 to 9:");
    foreach (int number in result)
        Console.WriteLine(number);
}


static void Sample_Range_Linq()
{
    var result = from n in Enumerable.Range(0, 10)
                 select n;

    Console.WriteLine("Counting from 0 to 9:");
    foreach (int number in result)
        Console.WriteLine(number);
}

static void Sample_Repeat_Lambda()
{
    string word = "Banana";

    var result = Enumerable.Repeat(word, 5);

    Console.WriteLine("String is repeated 5 times:");
    foreach (string str in result)
       Console.WriteLine(str);
}

static void Sample_Repeat_Linq()
{
    string word = "Banana";

    var result = from w in Enumerable.Repeat(word, 5)
                 select w;

    Console.WriteLine("String is repeated 5 times:");
    foreach (string str in result)
        Console.WriteLine(str);
}

static void Sample_GroupBy_Lambda()
{
    int[] numbers = { 10, 15, 20, 25, 30, 35 };

    var result = numbers.GroupBy(n => (n % 10 == 0));

    Console.WriteLine("GroupBy has created two groups:");
    foreach (IGrouping<bool, int> group in result)
    {
        if (group.Key == true)
            Console.WriteLine("Divisible by 10");
        else
            Console.WriteLine("Not Divisible by 10");

        foreach (int number in group)
            Console.WriteLine(number);
    }
}


static void Sample_GroupBy_Linq()
{
    int[] numbers = { 10, 15, 20, 25, 30, 35 };

    var result = from n in numbers
                 group n by (n % 10 == 0) into groups
                 select groups;

    Console.WriteLine("GroupBy has created two groups:");
    foreach (IGrouping<bool, int> group in result)
    {
        if (group.Key == true)
            Console.WriteLine("Divisible by 10");
        else
            Console.WriteLine("Not Divisible by 10");

        foreach (int number in group)
            Console.WriteLine(number);
    }
}


static void Sample_Join_Lambda()
{
    string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
    string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };

    var result = warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm);

    Console.WriteLine("Joined countries which are both warm and Europan:");
    foreach (var country in result) // Note: result is an anomymous type, thus must use a var to iterate.
        Console.WriteLine(country);
}

static void Sample_Join_Linq()
{
    string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
    string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };

    var result = (from w in warmCountries
                  join e in europeanCountries on w equals e
                  select w);

    Console.WriteLine("Joined countries which are both warm and European using Query Syntax:");
    foreach (var country in result)
        Console.WriteLine(country);
}




static void Sample_OrderBy_Lambda_Numbers()
{
    int[] numbers = { 7, 9, 5 };

    var result = numbers.OrderBy(n => n);

    Console.WriteLine("Ordered list of numbers:");
    foreach (int number in result)
        Console.WriteLine(number);
}


static void Sample_OrderBy_Linq_Numbers()
{
    int[] numbers = { 7, 9, 5 };

    var result = from n in numbers
                 orderby n
                 select n;

    Console.WriteLine("Ordered list of numbers:");
    foreach (int number in result)
        Console.WriteLine(number);
}


static void Sample_OrderBy_Lambda_Dates()
{
    var dates = new DateTime[] {
        new DateTime(2015, 2, 15),
        new DateTime(2015, 3, 25),
        new DateTime(2015, 1, 5)
    };

    var result = dates.OrderBy(d => d);

    Console.WriteLine("Ordered list of dates:");
    foreach (DateTime dt in result)
        Console.WriteLine(dt.ToString("yyyy/MM/dd"));
}

static void Sample_OrderBy_Linq_Dates()
{
    var dates = new DateTime[] {
        new DateTime(2015, 2, 15),
        new DateTime(2015, 3, 25),
        new DateTime(2015, 1, 5)
    };

    var result = from d in dates
                 orderby d
                 select d;

    Console.WriteLine("Ordered list of dates:");
    foreach (DateTime dt in result)
        Console.WriteLine(dt.ToString("yyyy/MM/dd"));
}


static void Sample_OrderByDescending_Lambda()
{
    string[] names = { "Ned", "Ben", "Susan" };

    var result = names.OrderByDescending(n => n);

    Console.WriteLine("Descending ordered list of names:");
    foreach (string name in result)
        Console.WriteLine(name);
}


static void Sample_OrderByDescending_Linq()
{
    string[] names = { "Ned", "Ben", "Susan" };

    var result = from n in names
                 orderby n descending
                 select n;

    Console.WriteLine("Descending ordered list of names:");
    foreach (string name in result)
        Console.WriteLine(name);
}

static void Sample_Reverse_Lambda()
{
    char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

    var result = characters.Reverse();

    Console.WriteLine("Characters in reverse order:");
    foreach (char character in result)
        Console.WriteLine(character);
}

static void Sample_Reverse_Linq()
{
    char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

    var result = (from c in characters.Reverse()
                  select c);

    Console.WriteLine("Characters in reverse order:");
    foreach (char character in result)
        Console.WriteLine(character);
}

static void Sample_ThenBy_Lambda()
{
    string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
                          "Athens", "Beijing", "Seoul" };

    var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
    foreach (string capital in result)
        Console.WriteLine(capital);
}

static void Sample_ThenBy_Linq()
{
    string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London", "Athens", "Beijing", "Seoul" };

    var result = (from c in capitals
                  orderby c.Length
                  select c)
                 .ThenBy(c => c);

    Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
    foreach (string capital in result)
        Console.WriteLine(capital);
}


static void Sample_ThenByDescending_Lambda()
{
    var dates = new DateTime[] {
        new DateTime(2015, 3, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2015, 1, 1),
        new DateTime(2015, 7, 1)
    };

    var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

    Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
    foreach (DateTime dt in result)
        Console.WriteLine(dt.ToString("yyyy/MM/dd"));
}

static void Sample_ThenByDescending_Linq()
{
    var dates = new DateTime[] {
        new DateTime(2015, 3, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2015, 1, 1),
        new DateTime(2015, 7, 1)
    };

    var result = from d in dates
                 orderby d.Year descending, d.Month descending
                 select d;

    Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
    foreach (DateTime dt in result)
        Console.WriteLine(dt.ToString("yyyy/MM/dd"));
}

static void Sample_Concat_Lambda_Numbers()
{
    int[] numbers1 = { 1, 2, 3 };
    int[] numbers2 = { 4, 5, 6 };

    var result = numbers1.Concat(numbers2);

    Console.WriteLine("Concatenating numbers1 and numbers2 gives:");
    foreach (int number in result)
        Console.WriteLine(number);
}

static void Sample_Concat_Lambda_Strings()
{
    string[] vegetables = { "Tomato", "Cucumber", "Carrot" };
    string[] fruits = { "Apples", "Grapes", "Banana" };

    var result = vegetables.Concat(fruits);

    Console.WriteLine("Concatinating vegetables and fruits gives:");
    foreach (string piece in result)
        Console.WriteLine(piece);
}

static void Sample_SequenceEqual_Lambda()
{
    string[] words = { "one", "two", "three" };
    string[] wordsSame = { "one", "two", "three" };
    string[] wordsOrder = { "two", "three", "one" };
    string[] wordsCase = { "one", "TWO", "three" };

    var resultSame = words.SequenceEqual(wordsSame);
    var resultOrder = words.SequenceEqual(wordsOrder);
    var resultCase = words.SequenceEqual(wordsCase);
    var resultCaseIgnored = words.SequenceEqual(wordsCase, StringComparer.OrdinalIgnoreCase);

    Console.WriteLine("SequenceEqual on two identical arrays:");
    Console.WriteLine(resultSame);

    Console.WriteLine("SequenceEqual on two differently ordered but otherwise identical arrays:");
    Console.WriteLine(resultOrder);

    Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays:");
    Console.WriteLine(resultCase);

    Console.WriteLine("SequenceEqual on two differently cased but otherwise identical arrays, where case is ignored:");
    Console.WriteLine(resultCaseIgnored);
}

static void Sample_Zip_Lambda()
{
    int[] numbers1 = { 1, 2, 3 };
    int[] numbers2 = { 10, 11, 12 };

    var result = numbers1.Zip(numbers2, (a, b) => (a * b));

    Console.WriteLine("Using Zip to combine two arrays into one (1*10, 2*11, 3*12):");
    foreach (int number in result)
        Console.WriteLine(number);
}