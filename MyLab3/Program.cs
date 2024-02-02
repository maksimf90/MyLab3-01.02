using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Проверка корректности электронной почты
        string email = GetValidEmailFromConsole();

        // Проверка номера телефона
        string phoneNumber = GetValidPhoneNumberFromConsole();

        // Далее вы можете использовать полученные значения
        Console.WriteLine($"Введенная электронная почта: {email}");
        Console.WriteLine($"Введенный номер телефона: {phoneNumber}");
    }

    static string GetValidEmailFromConsole()
    {
        string email;
        do
        {
            Console.Write("Введите электронную почту: ");
            email = Console.ReadLine().Trim();

            if (!IsValidEmail(email))
            {
                Console.WriteLine("Некорректный формат электронной почты. Попробуйте снова.");
            }

        } while (!IsValidEmail(email));

        return email;
    }

    static string GetValidPhoneNumberFromConsole()
    {
        string phoneNumber;
        do
        {
            Console.Write("Введите номер телефона (в формате 8-9XX-XXX-XX-XX): ");
            phoneNumber = Console.ReadLine().Trim();

            if (!IsValidPhoneNumber(phoneNumber))
            {
                Console.WriteLine("Некорректный формат номера телефона. Попробуйте снова.");
            }

        } while (!IsValidPhoneNumber(phoneNumber));

        return phoneNumber;
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(email);
    }

    static bool IsValidPhoneNumber(string phoneNumber)
    {
        string pattern = @"^8-9\d{2}-\d{3}-\d{2}-\d{2}$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(phoneNumber);
    }
}