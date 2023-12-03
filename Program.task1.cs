// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void NewFunc(){
    Console.WriteLine("Введите целое число");
    var input = Console.ReadLine()+"";
    foreach (char q in input)
     if (!Char.IsDigit(q)){
        int length = input.Length;
        if (input [0] == 'q'){
            Console.WriteLine("STOP");
            break;
        }
        else{
            NewFunc();
        }
     }
    else {
        int number = Math.Abs(Int32.Parse(input));
        int sum = 0;
        if (number < 10){
            sum = number;
        }
        else {
            int i = number%10;
            while (i==0){
                sum=i*10+sum;
                number = number/10;
            }
        }
        if (sum%2==0){
            Console.WriteLine("STOP");
            break;
        }
        else{
            NewFunc();
        }
        
    }
}
NewFunc();
        