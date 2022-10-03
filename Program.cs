string[] arr = { "Good morning", ":-)", "12", "123", "1234"};
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
        Console.Write($"{arr[i]} ");

};
