int[] CreateRandomArray(int size, int minValue, int maxValue)  //Метод для генирации массива с случайными числами
{
    int[] newArray= new int[size];

    for(int i = 0; i < size; i++)
    {
       newArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
   
    return newArray;
}

int[,]CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)//Гегирация случайного двумерного массива
{
    int [,]newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j]= new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

int[] CreateArray( int size)  //Метод для генирации массива с запрашиваем у пользователя!

{
    int[] newArray= new int[size];
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element of {size}: ");
        newArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void PrintArray(int [] array)  //Метод для вывода массива!
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

int SumOfPositive(int []array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >0) sum += array[i];
    }
    return sum;
}

int[]ReverseArray(int[]array)  //Lessen 6. Метод на разворот массива!
{
    for(int i = 0,  j =  array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

void Show2dArray(int[,]array)//Вывод двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
       for(int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write(array[i,j] + " ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
}



/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]array= CreateRandomArray(size, min, max);
PrintArray(array);

Console.WriteLine("Sum of positive elements is " + SumOfPositive(array));
*/
/*
//Для двумерного массива!
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,]array= CreateRandom2dArray(n,m, min, max);
Show2dArray(array);
*/

//Task 1
/*
//Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.
// Аргументы индексы

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangePositions(int[,] array, int row1, int row2)
{
    int temp = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    }

    return array;
}

Console.Write("Введите номер строки 1: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки 2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(5, 7, 0, 10);
Print2DArray(array);

if(row1 > array.GetLength(0) - 1 || row2 > array.GetLength(0) - 1) Console.WriteLine("Невозможно");
else
{
    ChangePositions(array, row1, row2);
    Print2DArray(array);
}

*/

//Task 2
/*
/ Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//     // 1 2 3 4
//     // 5 7 8 9
//     // 0 9 8 2
//        1 2 5 7 

int[,] Reverse(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }

    return array;
}  
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n, min, max);
Print2DArray(array); 

if(m != n) Console.WriteLine("Невозможно");
else 
{
    int[,] newArray = Reverse(array);
    Print2DArray(newArray);
}
*/

//Task 3

/*
/ Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] NewArray(int[,] array)
{
    int min = array[0, 0];
    int indexI = 0;
    int indexJ = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min) 
            {
                indexI = i;
                indexJ = j;
                min = array[i, j];
            }
        }
    }

//     // 1 2 3 4
//     // 5 7 8 9
//     // 0 9 8 2

    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int newX = 0; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        if (i != indexI)  
        { 
            int newY = 0; 
            for (int j = 0; j < array.GetLength(1); j++) 
            { 
                if (j != indexJ) 
                { 
                    result[newX, newY] = array[i, j]; 
                    newY++; 
                } 
            } 
            newX++; 
        } 
    }


    return result;
}
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if( i == indexI) 
//             {
//                 result[i, j] = array[i, j + 1];
//             }

//             if( j == indexJ)
//             {
//                 result[i, j] = array[i + 1, j];
//             }
//         }
//     }
// }


int[,] array = CreateRandom2DArray(3, 5, 0, 10);
Print2DArray(array);
int[,] newArray = NewArray(array);
Print2DArray(newArray);
*/