// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Task1
//int a, b, c;
//a = 150;
//b = 50;
//c = 50;
//if (a >= 10 && a <= 100 && b >= 10 && b <= 100 && c >= 10 && c <= 100)
//{
//    Console.WriteLine(a + b + c);
//}
//else if (a >= 10 && a <= 100 && b >= 10 && b <= 100)
//{
//    Console.WriteLine(a + b);
//}
//else if (b >= 10 && b <= 100 && c >= 10 && c <= 100)
//{
//    Console.WriteLine(b + c);
//}
//else if (a >= 10 && a <= 100 && c >= 10 && c <= 100)
//{
//    Console.WriteLine(a + c);
//}
//else
//{
//    Console.WriteLine("Bir eded 10 ve 100 araliqindadir.");
//}
#endregion

#region Task2
//int month = 5;
//if(month >=3 && month <= 6)
//{
//    Console.WriteLine("Yaz feslidir.");
//}
//else if (month >=7 && month <= 9)
//{
//    Console.WriteLine("Yay feslidir");
//}
//else if(month >=10 && month <= 12)
//{
//    Console.WriteLine("Payiz feslidir.");
//}
//else
//{
//    Console.WriteLine("Qis feslidir.");
//}
#endregion

#region Task3
//int num = 561;
//int a, b, c;
//    a = num % 10;
//    b = (num/10)%10;
//    c=(num/100)%10;
//    Console.WriteLine(a * b * c);
#endregion

#region Task4
int p1, p2, p3;
p1 = 10;
p2 = 5;
p3 = 20;
if(p1<p2 && p1 < p3)
{
    Console.WriteLine(p2+p3);
}
else if(p2<p1 && p2 < p3)
{
    Console.WriteLine(p1+p3);
}
else if (p3 < p2 && p3< p1)
{
    Console.WriteLine(p2+p1);
}
else
{
    Console.WriteLine(p1+p2+p3);
}
#endregion