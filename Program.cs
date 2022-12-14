Console.WriteLine("Здравствуйте, Артём! Я немного хлебушек и не понял до конца, как работает TryParse и проверка на число... Я разберусь на выходных и постараюсь добавить в следующем дз. Не бульте меня, плз. (.)_(.) \n");
int rep = 0;
while (rep == 0)
{
    Console.WriteLine("Выберите номер задания \n 1. А в степени B \n 2. Сумма цифр числа \n 3. Массив из 8 элементов \n 0. Выход");
    Console.Write("Ввод: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 1)
    {
        System.Console.Write("Введите основание: ");
        int bas = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Введите показатель степени: ");
        int exponent = Convert.ToInt32(Console.ReadLine());
        double rez = Operation(bas, exponent);
        Console.WriteLine($"Ответ: {bas}^{exponent} = {rez}");

        double Operation(int bas, int exponent)
        {
            double rez = Math.Pow(bas, exponent);
            return rez;
        }

        Console.WriteLine("____________");
    }
    else if (n == 2)
    {
        System.Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int summ = Summator(number);
        System.Console.WriteLine($"Сумма цифр: {summ}");


        int Summator(int number)
        {
            int summ = 0;
            while (number > 0)
            {
                summ += (number % 10);
                number /= 10;
            }
            return summ;
        }

        Console.WriteLine("____________");
    }
    else if (n == 3)
    {
        int arrLength = 8;
        int left = 0;
        int right = 99;
        int[] arr = Auto(arrLength, left, right);
        Console.WriteLine("[" + string.Join(", ", arr) + "]");

        int[] Auto(int arrLength, int left, int right)
        {
            int[] arr = new int[arrLength];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(left, right);
            }
            return arr;
        }

        Console.WriteLine("____________");
    }
    else if (n == 0)
    {
        Console.WriteLine("You kill me :c");
        break;
    }
    else
    {
        rep = 0;
    }

    await Task.Delay(2000);
}
