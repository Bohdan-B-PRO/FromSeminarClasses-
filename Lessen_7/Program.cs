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
