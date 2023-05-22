// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа

int lengthOfString = 3; 
char[] exceptions = new char[]{',', '.', ' ', ';'};

Console.WriteLine("Введи значения через пробел, точку, запятую или точку с запятой: ");

string[] specifiedArray = Input(exceptions);
string[] filtrationArray = Filtration(specifiedArray, Sum (specifiedArray,lengthOfString), lengthOfString);
Output(filtrationArray);





//Console.WriteLine($"Сумма = {Sum (specifiedArray,lengthOfString)}");



//\\//\\//\\//\\//\\//\\//\\//\\

string[] Input (char[]exp)
{
    string num = Console.ReadLine();
    string[] stringOfNum = num.Split(exp);

    return stringOfNum;
}

int Sum (string[]a, int los)
{
    int j = 0;

    for (int i = 0; i < a.GetLength(0); i++)
    {
         if (a[i].Length < los+1 && a[i] !="") j++;//////////////
    }
    return j;
}

string[] Filtration(string[]a, int size, int los)
{
    int j = 0;
    string [] b = new string[size];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        if (a[i].Length < los+1 && a[i] !="") ///////////////////
        {
            b[j] = a[i]; 
            j++;
        }
    }
    return b;
}

void Output(string[]str)
{
for (int i = 0; i < str.GetLength(0); i++)
{
    Console.Write ($"{str[i]}, ");
}
Console.Write("\b\b.");
}