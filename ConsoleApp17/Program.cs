using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        string inputString = " иванов иван,петров петр, сидорова Анна, бобров БОРИС ";
        
        List<string> formattedNames = FormatNames(inputString);
       
        
        Console.WriteLine("--- Форматирование списка пользователей ---");
        Console.WriteLine("Исходная строка: \"" + inputString + "\"");
        Console.WriteLine("Отформатированный список:");
        for (int i = 0; i < formattedNames.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {formattedNames[i]}");
        }
    }
    static List<string> FormatNames(string inputString)
    {
        inputString = inputString.Trim();
        string[] namesArray = inputString.Split(',');
        List<string> formattedNames = new List<string>();
        foreach (string name in namesArray)
        {
            string trimmedName = name.Trim();
            string[] parts = trimmedName.Split();
            string formattedName =
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(parts[0].ToLower()) + " " +
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(parts[1].ToLower());
            
            formattedNames.Add(formattedName);
        }
        return formattedNames;
    }
}