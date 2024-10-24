using System;
class Program
{

    delegate void MenuParagraph();

    static void Main(string[] args)
    {
        MenuParagraph[] paragraph = new MenuParagraph[6];
        paragraph[1] = NewGame;
        paragraph[2] = LoadGame;
        paragraph[3] = ShowRules;
        paragraph[4] = ShowAbout;
        paragraph[0] = Exit;

        while (true)
        {
            ShowMenu();

            int choice = GetUserChoice();

            if (choice >= 0 && choice <= 5)
            {
                paragraph[choice]();
            }
            else
            {
                Console.WriteLine("ошибка попробуйте заново");
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1: Новая игра");
        Console.WriteLine("2: Загрузить игру");
        Console.WriteLine("3: Правила");
        Console.WriteLine("4: Об авторе");
        Console.WriteLine("0: Выход");
    }

    static int GetUserChoice()
    {
        Console.Write("Выберите пункт меню (введите число): ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("ошибка ввода");
            Console.Write("Выберите пункт меню (введите число): ");
        }
        return choice;
    }

    static void NewGame()
    {
        Console.WriteLine("Новая игра");
    }

    static void LoadGame()
    {
        Console.WriteLine("Загрузка игры");
    }

    static void ShowRules()

    {
        Console.WriteLine("Правила:");
    }

    static void ShowAbout()
    {
        Console.WriteLine("Автор:");
    }

    static void Exit()
    {
        Console.WriteLine("Выход");
        Environment.Exit(0);
    }
}