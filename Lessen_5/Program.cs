//Lessen 5
int[] CreateRandomArray(int size, int minValue, int maxValue)  //Метод для генирации массива с случайными числами
{
    int[] newArray= new int[size];

    for(int i = 0; i < size; i++)
    {
       newArray[i] = new Random().Next(minValue, maxValue + 1); 
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

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]array= CreateRandomArray(size, min, max);
PrintArray(array);

Console.WriteLine("Sum of positive elements is " + SumOfPositive(array));