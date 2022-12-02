Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите третье число: ");
int c = Convert.ToInt32 (Console.ReadLine());
if (a>b)
{
    Console.WriteLine (" {0} наибольшее число" , a );
}
else
{
    Console.WriteLine ("{0} наибольшее число" , b );   
}
if (b > c)
{
 Console.WriteLine ("{0} наибольшее число" , b );    
}
else
{
 Console.WriteLine ("{0} наибольшее число" , c );  
}
if (c > a)
{
Console.WriteLine ("{0} наибольшее число" , c );
}
else
{
Console.WriteLine (" {0} наибольшее число" , a );
}
Console. ReadLine(); 