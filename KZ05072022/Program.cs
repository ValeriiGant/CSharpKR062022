// Из имеющегося массива строк сформировать массив из строк, длина которых меньше либо равна 3 символам.
Console.Clear();
void PrintArray(string[] array) ///метод печати массива
{
    int len = array.Length;
    for (int i = 0; i < len; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int CountArrayLess(string[] countarray) /// метод подсчета количества элементов с длиной меньше 4
{
    int count = 0;
    foreach (string element in countarray) if (element.Length < 4) count++;
    return count;
}

string[] ArrayNew(string[] arraynew) /// метод, формирующий новый массив с длиной элементов меньше 4
{
    int len = CountArrayLess(arraynew);  //длина нового массива равна количеству 
    string[] newArray = new string[len];              //элементов исходного массива с длиной меньше 4
    if (len == 0) return newArray;
    else
    {
        int index = 0;
        foreach (string element in arraynew) if (element.Length < 4)
            {
                newArray[index] = element;
                index++;
            }
        return newArray;
    }
}

string[] a = new string[] { "hello", "2", "world", ":-)" };
string[] b = new string[] { "1234", "1567", "-2", "computer scince" };
string[] c = new string[] { "Russia", "Denmark", "Kazan" };
Console.Write($"Пример 1: " );
PrintArray(a);
Console.Write($"Пример 2: " );
PrintArray(b);
Console.Write($"Пример 3: " );
PrintArray(c);

Console.Write($"Решение 1: " );
PrintArray(ArrayNew(a));
Console.Write($"Решение 2:  " );
PrintArray(ArrayNew(b));
Console.Write($"Решение 3: " );
PrintArray(ArrayNew(c));
