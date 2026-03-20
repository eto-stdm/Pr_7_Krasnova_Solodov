using System;

/// <summary>
/// Класс программы-примера.
/// </summary>
class ArrayExample
{
    /// <summary>
    /// Основная функция.
    /// </summary>
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }

    /// <summary>
    /// Выводит символы и их общее количество.
    /// </summary>
    /// <param name="name">Символы (имя).</param>
    /// <param name="msg">Общее количество символов.</param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}