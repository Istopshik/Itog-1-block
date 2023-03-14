//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//пользоваться коллекциями, лучше обойтись исключительно массивами. 
Console.Clear();
System.Console.WriteLine("Введите количество элементов массива: ");
int number = int.Parse(Console.ReadLine());
string[] massive = new string[number];
for (int i = 0; i < number; i++)
{
    System.Console.WriteLine("Введите значение: ");
    massive[i] = Console.ReadLine();
}
System.Console.Write("Введеный вами массив получился таким: [");
System.Console.Write(String.Join(", ", massive));
System.Console.WriteLine("]");
System.Console.WriteLine();
System.Console.Write("Значения, длина которых меньше 3 символов = [");
for (int i = 0; i < number; i++)
{
    if (massive[i].Length <= 3)
    {
        System.Console.Write($"{massive[i]} ");
    }
}
System.Console.WriteLine("]");






