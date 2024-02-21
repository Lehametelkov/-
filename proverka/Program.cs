Console.WriteLine("Введите целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
      {
        Console.WriteLine("первое число больше");
      }
      else if (firstNumber == secondNumber)
      {
        Console.WriteLine("числа равны"); 
      }
     
      else if(firstNumber < secondNumber)
      {
        Console.WriteLine("второе число больше");        
      }
    