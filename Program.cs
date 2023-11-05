Console.Clear();

string[] Words = GetArr();

Console.WriteLine("Создан массив строк: ");
PrintArr(Words);

string[] Words1 = new string[Words.Length];
GetNewArr(Words1);
Words1 = Words1.Where(x => !string.IsNullOrEmpty(x)).ToArray();

Console.WriteLine("Создан новый массив строк по заданной выборке: ");
PrintArr(Words1);


string[] GetArr()
{
    string[] words;
    int Legth = default;
    string text;
    string[] boofer;
    Console.WriteLine("Введите новую строку:");

    words = new string[Legth]; 

    do
    {
        text = Console.ReadLine()!;

        if (text != "")
        {
            Legth++;

            boofer = new string[Legth];

            for (int i = 0; i < boofer.Length - 1; i++)
                boofer[i] = words[i];

            boofer[Legth - 1] = text;
            words = boofer;
        }
    } while (text != "");
    return words;
}

void PrintArr(string[] args)
{
    for (int i = 0; i < args.Length; i++)
        Console.WriteLine("args[{0}] = {1}", i, args[i]);
}

void GetNewArr(string[] args)
{
    Console.WriteLine("Введите требуемый размер для выборки элементов");
    int InsertNumber = Int32.Parse(Console.ReadLine()!);

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
