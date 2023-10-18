System.Console.WriteLine($"Введите количество элементов массива");
int lengthArr = int.Parse(Console.ReadLine());
int ifarr =0;
string[] arr = new string[lengthArr];
string[] farr = new string[lengthArr];
int number = 3;
System.Console.WriteLine("Введите массив");
for (int i = 0; i < lengthArr; i++)
{    
    System.Console.WriteLine($"Введите {i+1} член массива");
    arr[i] = Console.ReadLine();
}
for (int i = 0; i < lengthArr; i++)
{
    if(arr[i].Length <= number)
    {
        farr[ifarr] = arr[i];
        ifarr++;
    }
}
var str = string.Join(" ", farr);
System.Console.WriteLine(str);