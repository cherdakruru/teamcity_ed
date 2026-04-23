using System;
using System.IO;

namespace TeamCityDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TeamCity Demo App ===");
        Console.WriteLine($"Started at: {DateTime.Now}");
        
        var calc = new Calculator();
        
        Console.WriteLine($"Основная логика: 10 + 20 = {calc.Add(10, 20)}");
        Console.WriteLine($"Основная логика: 100 - 30 = {calc.Subtract(100, 30)}");
        
        // Генерация артефакта
        var artifactPath = "result.txt";
        File.WriteAllText(artifactPath, $"Build completed: {DateTime.Now}\nStatus: SUCCESS");
        Console.WriteLine($"Артефакт создан: {artifactPath}");
        
        Console.WriteLine("=== DONE ===");
        
        // Для тестирования ошибок (раскомментировать, чтобы сломать сборку)
        // throw new Exception("Fatal error for CI test");
    }
}