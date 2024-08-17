using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите скорость ветра (м/с):");

        // Читаем ввод пользователя
        string wind = Console.ReadLine();
        double windSpeed;

        // Проверяем и конвертируем ввод в число
        if (double.TryParse(wind, out windSpeed))
        {
            // Определяем характер ветра с помощью switch
            int windCategory;

            if (windSpeed >= 1 && windSpeed <= 4)
            {
                windCategory = 1; // слабый
            }
            else if (windSpeed >= 5 && windSpeed <= 10)
            {
                windCategory = 2; // умеренный
            }
            else if (windSpeed >= 11 && windSpeed <= 18)
            {
                windCategory = 3; // сильный
            }
            else if (windSpeed > 19)
            {
                windCategory = 4; // ураган
            }
            else
            {
                Console.WriteLine("Скорость ветра должна быть больше или равна 1 м/с.");
                return; // Выход из программы
            }

            // Используем switch для вывода результата
            switch (windCategory)
            {
                case 1:
                    Console.WriteLine("Скорость ветра: {0} м/с - слабый ", windSpeed);
                    break;
                case 2:
                    Console.WriteLine("Скорость ветра: {0} м/с - умеренный ", windSpeed);
                    break;
                case 3:
                    Console.WriteLine("Скорость ветра: {0} м/с - сильный ", windSpeed);
                    break;
                case 4:
                    Console.WriteLine("Скорость ветра: {0} м/с - ураган ", windSpeed);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное число.");
        }
    }
}
