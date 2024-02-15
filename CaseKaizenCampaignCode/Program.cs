using System;

class Program
{
    static void Main(string[] args)
    { 
        string generatedCode = GenerateCode(8);
        Console.WriteLine("Generated Code: " + generatedCode);
         
        Console.Write("Enter your code: ");
        string userCode = Console.ReadLine();
         
        bool isValid = ValidateCode(userCode);
        if (isValid)
        {
            Console.WriteLine("Congratulations! You've joined the campaign.");
        }
        else
        {
            Console.WriteLine("Invalid code. Please try again.");
        }
    }

    static string GenerateCode(int length)
    {
        string characterSet = "ACDEFGHKLMNPRTXYZ234579";
        Random random = new Random();
        string code = "";
        for (int i = 0; i < length; i++)
        {
            code += characterSet[random.Next(0, characterSet.Length)];
        }
        return code;
    }

    static bool ValidateCode(string code)
    {
        if (code.Length != 8)
        {
            return false;
        }

        string characterSet = "ACDEFGHKLMNPRTXYZ234579";
        foreach (char c in code)
        {
            if (!characterSet.Contains(c))
            {
                return false;
            }
        }

        // Geçerlilik kontrolüne başka özel kriterler de eklenebilir.
        return true;
    }
}