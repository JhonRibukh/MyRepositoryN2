using System.Collections.Generic;

bool q = false;





do
{
    char operation = '\0';
    try
    {
        Console.WriteLine("1. Игра Угадай число");
        Console.WriteLine("2. Вывод делителей числа");
        Console.WriteLine("3. выход");
        Console.Write("Укажите операцию: ");
        operation = char.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("ошибка не верное значение");
    }



    switch (operation)
    {
        case '1':

            try
            {
                int x = 0;
                int y = 100;
                Random r = new Random();
                int a = r.Next(x, y);
                int c = 0;
                Console.WriteLine(a);
                while (true)
                {
                    Console.WriteLine("Введите число");
                    int b = int.Parse(Console.ReadLine());
                    if (b == a)
                    {
                        Console.WriteLine("Вы угадали!", c);
                        break;
                    }
                    else if (b > a)
                    {
                        Console.WriteLine("Ваше число больше");
                    }
                    else
                    {
                        Console.WriteLine("Ваше число меньше");
                    }
                }
            }
            catch
            {
                Console.WriteLine("ошибка не верное значение");
            }
            break;
        case '2':

            try
            {
                Console.Write("Введи число ");
                int o = int.Parse(Console.ReadLine());
                for (int p = 1; p <= o; p++)
                {
                    if (o % p == 0) Console.Write("{0} ", p);
                }
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("ошибка не верное значение");
            }
            break;
      
        case '3': q = true; break;
    }



} while (!q) ;


    Console.WriteLine("окончание работы");
