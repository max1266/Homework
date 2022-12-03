Console.Clear();
Console.WriteLine("введите цифру от 1 до 7");
double a = Convert.ToDouble(Console.ReadLine());
    if((a == 1) || (a == 2) || (a == 3) || (a == 4) || (a == 5)){
        Console.WriteLine("no");
    }
    else{
        if((a == 6) || (a == 7)){
            Console.WriteLine("yes");
        }
        else
        Console.WriteLine("введите другую цифру");
    }
    
