void FillArray(double[,] array, int row, int column, int type = 0)
{
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if(type == 0)
            {
                array[i, j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 1);
            }
            else
            {
                array[i, j] = rand.Next(-10, 11);
            }
            
        }
    }
}

void PrintArray(double[,] array, int row, int column)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.Write("\b\b");
        Console.WriteLine();
    }
}

bool Uslov(int row, int column, int rowOne, int columnOne)
{
    return rowOne <= row && rowOne > 0 && columnOne <= column && columnOne > 0;
}

void FillArrayPlus(double[,] array, int row, int column)
{
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
                array[i, j] = rand.Next(0, 11);
        }
    }
}

void PrintAverage(double[] array)
{
    Console.Write("Cреднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b");
}


void Zadacha_47()
{
    Console.Write("Введите количество строк - ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов - ");
    int column = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[row, column];
    FillArray(array, row, column);
    PrintArray(array, row, column);
}
//Zadacha_47();


void Zadacha_50()
{
    int row = 4;
    int column = 4;
    double[,] array = new double[row, column];
    FillArray(array, row, column, 1);
    PrintArray(array, row, column);
    Console.Write("Введите номер строки - ");
    int rowOne = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца - ");
    int columnOne = Convert.ToInt32(Console.ReadLine());

    if(Uslov(row, column, rowOne, columnOne))
    {
        Console.WriteLine($"Число - {array[rowOne-1, columnOne-1]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}
//Zadacha_50();


void Zadacha_52()
{
    int row = 4;
    int column = 5;
    double[,] array = new double[row, column];
    double[] arrayOne = new double[column];
    FillArrayPlus(array, row, column);
    PrintArray(array, row, column);
    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < row; j++)
        {
            arrayOne[i] += array[j, i];
        }
        arrayOne[i] = Math.Round(arrayOne[i] / column, 2);
    }
    PrintAverage(arrayOne);
}
Zadacha_52();