

void Task3(){
        Console.WriteLine("Введите первое число");
    int num3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int num5 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(new int[] {num3,num4,num5}.Max()); //создаем масив и ввыводим максимальное число
}

Task3();