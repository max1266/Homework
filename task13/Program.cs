Console.Clear();
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
if(a <99){
    Console.WriteLine("нет третьего числа");
}
while(a > 999){
    a = a / 10;
}
a = a % 10;
Console.WriteLine(a);
