namespace mathes4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            Console.WriteLine("Введите число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число:");
            double num4 = Convert.ToDouble(Console.ReadLine());
            double sum = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Среднее арифметическое числа:");
            Console.WriteLine(sum);



            //2 задание
            Console.WriteLine("Введите два числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели числа " + a + " и " + b);
            Console.WriteLine("Какое действие выполнить?\r\n1. Сложение\r\n2. Вычитание\r\n3. Умножение\r\n4. Деление\r\n5. Нахождение остатка");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                double suma = a + b;
                Console.WriteLine("Результат: " + a + " + " + b + " = " + suma);
            }
            else if (choice == 2)
            {
                double subtraction = a - b;
                Console.WriteLine("Результат: " + a + " - " + b + " = " + subtraction);
            }
            else if (choice == 3)
            {
                double multiply = a * b;
                Console.WriteLine("Результат: " + a + " * " + b + " = " + multiply);
            }
            else if (choice == 4)
            {
                double divide = a / b;
                Console.WriteLine("Результат: " + a + " / " + b + " = " + divide);
            }
            else if (choice == 5)
            {
                double rema = a % b;
                Console.WriteLine("Результат: " + a + " % " + b + " = " + rema);
            }
            else
            {
                Console.WriteLine("Вы ввели не корректное число! Попробуйте ещё раз. ");
                choice = Convert.ToInt32(Console.ReadLine());
            }


            //3 задание
            Console.WriteLine("Выберите шкалу вводимой температуры:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт");
            int nam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите показатель температура (градусы):");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите тип шкалы для конвертации:\r\n1. Цельсий\r\n2. Кельвин\r\n3. Фаренгейт\r\n");
            int nam2 = Convert.ToInt32(Console.ReadLine());
            if (nam == 1 & nam2 == 1)
            {
                Console.WriteLine("Вы выбрали: Цельсий > Цельсий");
                Console.WriteLine("Результат конвертации: " + temp);
            }
            else if (nam == 1 & nam2 == 2)
            {
                Console.WriteLine("Вы выбрали: Цельсий > Кельвин");
                double kel = temp + 273;
                Console.WriteLine("Результат конвертации: " + kel);

            }
            else if (nam == 1 & nam2 == 3)
            {
                Console.WriteLine("Вы выбрали: Цельсий > Фаренгейт");
                double far = (temp + 273) * 1.8 - 459;
                Console.WriteLine("Результат конвертации: " + far);
            }
            else if (nam == 2 & nam2 == 1)
            {
                Console.WriteLine("Вы выбрали: Кельвин > Цельсий");
                double cel = temp - 273;
                Console.WriteLine("Результат конвертации: " + cel);
            }
            else if (nam == 2 & nam2 == 2)
            {
                Console.WriteLine("Вы выбрали: Кельвин > Кельвин ");
                Console.WriteLine("Результат конвертации: " + temp);
            }
            else if (nam == 2 & nam2 == 3)
            {
                Console.WriteLine("Вы выбрали: Кельвин > Фаренгейт");
                double far2 = temp * 1.8 - 459;
                Console.WriteLine("Результат конвертации: " + far2);

            }
            else if (nam == 3 & nam2 == 1)
            {
                Console.WriteLine("Вы выбрали: Фаренгейт > Цельсий");
                double cel2 = (temp - 32) / 1.8;
                Console.WriteLine("Результат конвертации: " + cel2);
            }
            else if (nam == 3 & nam2 == 2)
            {
                Console.WriteLine("Вы выбрали: Фаренгейт > Кельвин");
                double kel2 = (temp + 459) / 1.8;
                Console.WriteLine("Результат конвертации: " + kel2);
            }
            else if (nam == 3 & nam2 == 3)
            {
                Console.WriteLine("Вы выбрали: Фаренгейт > Фаренгейт");
                Console.WriteLine("Результат конвертации: " + temp);

            }



            // 6 задание 
            double[] array1 = new Double[10] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] array2 = new Double[5] { 0, 1, 2, 3, 4 };
            double[] array3 = new double[10];
            int hold = 1;
            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (i < array2.Length)
                {
                    array3[i] = array1[i] * array2[i];
                }
                else
                {
                    array3[i] = (array1[i] * hold);
                }
            }

            foreach (int j in array3)
            {
                Console.WriteLine(j);
            }












        }
    }
}

        
   