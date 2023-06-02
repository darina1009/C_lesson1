
void Task2(){
    
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
Task2();