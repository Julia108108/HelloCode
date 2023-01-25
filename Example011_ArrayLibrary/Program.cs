// Возьмем метод, который будет выводить элемента массива по 
// порядку. Превратим код поиска нужного нам индекса в метод.
// В новом массиве будет по умолчанию 10 элементов. 
// По умолчанию он наполнен нулями. Чтобы наполнить его другими
// числами воспользуемся меnодом, который сами опишем.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection[index] = new Random().Next(1, 10);
       //index = index +1;
       index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count) 
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);