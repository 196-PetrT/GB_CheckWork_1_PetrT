Console.Clear();

string[] Words = GetArr(10);

Console.WriteLine("Создан массив строк: ");
PrintArr(Words);

int InsertNum = InsertNumber();

string[] Words1 = GetNewArr(Words, InsertNum);

Console.WriteLine("Создан новый массив строк по заданной выборке: ");
PrintArr(Words1);

string[] GetArr(int Length)
{
    string[] words;
    string text = string.Empty;

    Console.WriteLine("Введите новую строку:");

    words = new string[Length];
    for (int i = 0; i < Length; i++)
    {
        text = Console.ReadLine()!;
        if (text != "")
            words[i] = text;
        else
            words[i] = "";
    }
    words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    return words;
}

void PrintArr(string[] args)
{
    for (int i = 0; i < args.Length; i++)
        Console.WriteLine("args[{0}] = {1}", i, args[i]);
}

int InsertNumber()
{
    int InsertNum = 0;
    Console.WriteLine("Введите требуемый размер для выборки элементов");

    string text = Console.ReadLine()!;

    if (text != "")
        InsertNum = int.Parse(text);
    return InsertNum;
}

string[] GetNewArr(string[] args, int InsertNumber)
{
    string[] words1 = new string[args.Length];
    int size = 0;
    for (int i = 0; i < args.Length; i++)
    {
        if (args[i].Length < InsertNumber + 1)
        {
            words1[size] = args[i];
            size++;
        }
    }
    words1 = words1.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    return words1;
}
