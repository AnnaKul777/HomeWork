Console.WriteLine ("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int start_number = 1;

while (start_number <= number)
{
    if (start_number % 2 ==0 )
    Console.Write (start_number + ", ");
    start_number ++;
}