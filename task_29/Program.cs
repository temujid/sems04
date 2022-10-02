/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/


Console.Write("Введите длину массива: ");
int elementCount = int.Parse(Console.ReadLine());
int [] myArray = new int [elementCount];
    

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write("Введите элемент массива: ");

        myArray[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < myArray.Length; i++)
    {
    }
    
{
int[] array = new int[] { 1, 2, 3 };

Console.WriteLine("[{0}]", string.Join(", ", myArray));
}
