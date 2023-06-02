void Task4(){
    
    Console.Write("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2){
        Console.WriteLine("max =" + num1);
    }
    else{
    Console.WriteLine("max =" + num2);
    }

}

void Task5(){
        Console.WriteLine("Введите первое число");
    int num3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int num5 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(new int[] {num3,num4,num5}.Max()); //создаем масив и ввыводим максимальное число
}

void Task6(){
    Console.WriteLine("Введите число");
    int num6 = Convert.ToInt32(Console.ReadLine());

    if (num6%2 == 0){
Console.WriteLine("ДА");
    }
    else {
        Console.WriteLine("НЕТ");
    }
    
}

void Task7(){
    Console.WriteLine("Введите число");
    int num7 = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num7; i++ ){
        if (i%2 == 0){
            Console.WriteLine(i);
        }
    }
}


//вариант для умных

void Task8(){
    Console.WriteLine("Введите число");
    int num7 = Convert.ToInt32(Console.ReadLine());

   Enumerable.Range(1,num7).Where(x => x%2 == 0).ToList().ForEach(x => Console.WriteLine(x));
}

Task4();
