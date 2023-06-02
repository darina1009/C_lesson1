
void Task5(){
    Console.WriteLine("Введите число");
    int num7 = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num7; i++ ){
        if (i%2 == 0){
            Console.WriteLine(i);
        }
    }
}


//вариант для умных

void Task6(){
    Console.WriteLine("Введите число");
    int num7 = Convert.ToInt32(Console.ReadLine());

   Enumerable.Range(1,num7).Where(x => x%2 == 0).ToList().ForEach(x => Console.WriteLine(x));
}

Task5();