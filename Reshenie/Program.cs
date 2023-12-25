
string[] inputArray = { "Hello", "2", "world", ":-)" };

string[] resultArray = FilterArray(inputArray);

Console.WriteLine("Результат:");
foreach (string str in resultArray)
{
    Console.Write($"{str} ");
}

Console.ReadLine();


static string[] FilterArray(string[] inputArray)
{
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];

    int index = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            resultArray[index++] = str;
        }
    }

    return resultArray;
}


