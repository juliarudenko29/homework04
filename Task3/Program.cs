void setArray(int count) {
    int[] array = new int[count];  

    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Ввелите {i} число: ");
        array[i-1] = int.Parse(Console.ReadLine()!);
    }

    printArray(array);
}

void printArray(int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        var number = array[i];
        Console.Write($"{number} ");
    }
}

setArray(5);