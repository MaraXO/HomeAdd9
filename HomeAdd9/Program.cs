using System.Text;
using System.Text.RegularExpressions;





public class Validator
{

    public static bool ValidateHomePhoneNumber(string phoneNumber)
    {
        try
        {
            string pattern = @"^\d{1,7}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка підтвердження номера домашнього телефону: {ex.Message}");
            return false;
        }
    }


    public static bool ValidateMobilePhoneNumber(string phoneNumber)
    {
        try
        {
            string pattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return false;
        }
    }


    public static bool ValidateEmail(string email)
    {
        try
        {
            string pattern = @"^[^\s@]+@[^\s@]+\.(com|net|org|edu|gov|mil|biz|info|mobi|name|aero|jobs|museum)$";
            return Regex.IsMatch(email, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return false;
        }
    }


    public static bool ValidateFullName(string fullName)
    {
        try
        {
            string pattern = @"^([A-Za-zА-Яа-яІіЇїЄєҐґ]{2,20}\s){2}[A-Za-zА-Яа-яІіЇїЄєҐґ]{2,20}$";
            return Regex.IsMatch(fullName, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return false;
        }
    }


    public static bool ValidatePassword(string password)
    {
        try
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,16}$";
            return Regex.IsMatch(password, pattern);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return false;
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string[] homePhoneNumbers = { "528389", "7589236", "284579", "7925846", "504179", "123" };
        string[] mobilePhoneNumbers = { "+380501234567", "0661234567", "380931234567", "+1235678954", "52" };
        string[] emails = { "example@gmail.com", "test@example.net", "invalidemail@", "user@domain" };
        string[] fullNames = { "Іван Іванов Іванович", "Петро Петров Петрович", "Олег Сидоров", "А" };
        string[] passwords = { "Password1!", "password1!", "PASSWORD1!", "Passw1!" };


        foreach (var phoneNumber in homePhoneNumbers)
        {
            Console.WriteLine($"{phoneNumber}: {ValidateHomePhoneNumber(phoneNumber)}");
        }


        foreach (var phoneNumber in mobilePhoneNumbers)
        {
            Console.WriteLine($"{phoneNumber}: {ValidateMobilePhoneNumber(phoneNumber)}");
        }


        foreach (var email in emails)
        {
            Console.WriteLine($"{email}: {ValidateEmail(email)}");
        }


        foreach (var fullName in fullNames)
        {
            Console.WriteLine($"{fullName}: {ValidateFullName(fullName)}");
        }


        foreach (var password in passwords)
        {
            Console.WriteLine($"{password}: {ValidatePassword(password)}");
        }

        Console.ReadLine();
    }
}