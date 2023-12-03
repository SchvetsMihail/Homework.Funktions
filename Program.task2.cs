// Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void ArrayFunc (){
    Console.WriteLine("введите кол-во символов массива");
    int quantity = Convert.ToInt32(Console.ReadLine());
    int[] i = new int[quantity];
    Random array = new Random();
    for (int j = 0; j<quantity; j++){
        i[j] = array.Next(100, 999);
        Console.Write($"{i[j]}"+" ");
    }
    int a = 0;
    int count = 0;
    while (a < quantity){
        if ((i[a])%2==0){
            count++;
            a++;
        }
        else{
            a++;
        }
    }    
    Console.WriteLine($"{count}");
}

ArrayFunc();
