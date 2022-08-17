int[] CreateArray()
{
    int[] array = new int[8];
   
    for (int i = 0; i < 8; i++)
        {
            Console.WriteLine("Введите " + i + " элемент массива");
            array[i] = int.Parse(Console.ReadLine()!);
        }
        
    return array;
}
var array = CreateArray();

for (int i = 0; i < 8; i++)
    Console.Write (" " + array[i]);