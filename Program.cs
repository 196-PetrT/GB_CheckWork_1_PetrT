Console.Clear();

string[] Words = GetArr(10);
Words = Words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
Console.WriteLine("Создан массив строк: ");
PrintArr(Words);
int InsertNum = InsertNumber();

string[] Words1 = new string[Words.Length];
GetNewArr(Words1, InsertNum);
Words1 = Words1.Where(x => !string.IsNullOrEmpty(x)).ToArray();

Console.WriteLine("Создан новый массив строк по заданной выборке: ");
PrintArr(Words1);

string[] GetArr(int Length)
{
    string[] words;
    string text = string.Empty;

    Console.WriteLine("Введите новую строку:");

    words = new string[Length];
    for (int i = 0; i < Length - 1; i++)
    {
        text = Console.ReadLine()!;
        if (text != "")
            words[i] = text;
        else
            words[i] = "";
    }
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

void GetNewArr(string[] args, int InsertNumber)
{
    int size = 0;
    for (int i = 0; i < Words.Length; i++)
    {
        if (Words[i].Length < InsertNumber + 1)
        {
            args[size] = Words[i];
            size++;
        }
    }
}
