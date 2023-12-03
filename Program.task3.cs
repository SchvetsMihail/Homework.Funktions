// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

void ReverseArrayFunc (){
    Console.WriteLine("введите кол-во символов массива");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter first number array");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter second number array");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int[] i = new int[quantity];
    Random array = new Random();
    for (int j = 0; j<quantity; j++){
        i[j] = array.Next(firstNumber, secondNumber);
        Console.Write($"{i[j]}"+" ");
    }
    int[] reverse = Enumerable.Reverse(i).ToArray();
        Console.WriteLine(" ");
        Console.WriteLine(String.Join(' ', reverse));
}
ReverseArrayFunc();
