Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a % 2 == 1)
{
    Console.Write("число" + a + " является: нечетным");
}
else
{
   Console.Write("число" + a + " является: четным");

}
Console.ReadLine();
