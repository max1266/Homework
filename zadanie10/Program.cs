Console.Clear();
Console.WriteLine("введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if((a > 99) && (a < 999)){
    int result1 =a / 10;
    int result =  result1 % 10;
    Console.WriteLine(result);
    
}
else
Console.WriteLine("неверное число, попробуйте заново");
