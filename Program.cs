string[] days = {"рабочим","рабочим","рабочим","рабочим","рабочим","выходным","выходным"};
Console.Write("Введите день недели числом: ");
int date = Convert.ToInt32(Console.ReadLine());
if(date<=7&&date>0)
{
    Console.Write($"Данный день является {days[date-1]}");
}
else
{
    Console.WriteLine("Неверно задан день!");
}