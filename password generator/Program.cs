using System.Text;

static int GetPasswordLenght()
{
    Console.WriteLine("Введите длину пароля: ");
    return Convert.ToInt32(Console.ReadLine());
}

static string GeneratePassword(int lenght)
{
    const string chars =
        "abcdefghijklmnopqrstuvwxyz" +
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
        "0123456789!@#$%^&*";

    var random = new Random();
    var result = new StringBuilder();

        for (int i = 0; i < lenght; i++)    
        result.Append(chars[random.Next(chars.Length)]);
        return result.ToString();
    
}

static void Main()
{
    int length = GetPasswordLenght();
    string password = GeneratePassword(length);
    
    Console.WriteLine($"Ваш случайный пароль: {password}");
}