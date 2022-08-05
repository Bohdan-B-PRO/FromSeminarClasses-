//Lessen2
//Task 1
/*
int FindBiggerDigit(int num)
{
    int ed = num % 10;
      int dec = num / 10;
      int max;
      if (ed < dec) max = ed;
    else max= dec;
    return max;
}
int number= new Random().Next(10,100);
int digit= FindBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {digit}" );
*/
//Task 2
/*
bool IsKratno(int num1, int num2)
{
   if(num1 % num2 ==0)return true;
   else return false;
}
Console.Write("Inmput first intenger number");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Inmput second intenger number");
int num2=Convert.ToInt32(Console.ReadLine());
bool kratno = IsKratno(num1, num2);
Console.WriteLine(kratno);
*/