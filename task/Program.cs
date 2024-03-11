/*
«адача: Ќаписать программу, котора€ из имеющегос€ массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 ѕервоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнени€ алгоритма. ѕри решении не рекомендуетс€ 
 пользоватьс€ коллекци€ми, лучше обойтись исключительно массивами.
ѕримеры:
[УHelloФ, У2Ф, УworldФ, У:-)Ф] ? [У2Ф, У:-)Ф]
[У1234Ф, У1567Ф, У-2Ф, Уcomputer scienceФ] ? [У-2Ф]
[УRussiaФ, УDenmarkФ, УKazanФ] ? []
*/
string[] arrayOne = new string[] { "^.^", "23", "hello", "work", "mirror", "to"};
string[] arrayTwo = new string[arrayOne.Length];
void SecondArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if (arrayOne[i].Length <= 3)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);