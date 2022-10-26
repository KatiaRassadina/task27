// Программа приниает на вход число и выдает сумму цифр в этом числе
Console.WriteLine("Input an integer number");
string number = Console.ReadLine();
int Length = number.Length;
int result = 0; 
for (int i = 0; i < Length; i++)
{
    result = result + Convert.ToInt32(Convert.ToString(number[i]));
}
Console.WriteLine(result);