//Задача: Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которыхменьше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
string[] FillArray(int n)
{
    string[] textarray = new string[n];
    for (int i = 0; i < n; i++)
    {
        textarray[i] = Console.ReadLine();
    }
    return textarray;
}
void PrintArray(string[] text)
{
    Console.Write("[ ");
    foreach (string item in text)
    {
        Console.Write($"\"{item}\" ");
    }
    Console.Write("]");
}
Console.Write("Введите количество элементов массива  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива с клавиатуры, разделяя их клавишей 'enter'");
string[] array = FillArray(n);
PrintArray(array);
Console.Write(" -> ");
