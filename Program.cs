// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        GreetUser();
    }

    static void GreetUser()
    {
        Console.Write("당신의 이름을 입력하세요: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("이름을 입력하지 않으셨군요. 안녕하세요, 사용자님!");
        }
        else
        {
            Console.WriteLine($"안녕하세요, {name}님! .NET 세계에 오신 것을 환영합니다!");
        }

        Console.WriteLine($"현재 시각은 {DateTime.Now} 입니다.");
    }
}