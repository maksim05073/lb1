using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ласкаво просимо до тесту 'Перевір свої можливості'!");
        int correctAnswers = 0;
        correctAnswers += AskQuestion("1. Професор ліг спати о 8 годині, а встав о 9 годині. Скільки годин проспав професор?", "1");
        correctAnswers += AskQuestion("2. На двох руках десять пальців. Скільки пальців на 10 руках?", "50");
        correctAnswers += AskQuestion("3. Скільки цифр у дюжині?", "2");
        correctAnswers += AskQuestion("4. Скільки потрібно зробити розпилів, щоб розпиляти колоду на 12 частин?", "11");
        correctAnswers += AskQuestion("5. Лікар зробив три уколи в інтервалі 30 хвилин. Скільки часу він витратив?", "30");
        correctAnswers += AskQuestion("6. Скільки цифр 9 в інтервалі від 1 до 100?", "1");
        correctAnswers += AskQuestion("7. Пастух мав 30 овець. Усі, окрім однієї, розбіглися. Скільки овець лишилося?", "1");
        EvaluateResult(correctAnswers);
    }

    static int AskQuestion(string question, string correctAnswer)
    {
        Console.WriteLine(question);
        string answer = Console.ReadLine().Trim();
        if (answer == correctAnswer)
        {
            return 1;
        }
        return 0;
    }

    static void EvaluateResult(int correct)
    {
        Console.WriteLine($"\nВаш результат: {correct} правильних відповідей.");
        switch (correct)
        {
            case 7:
                Console.WriteLine("Ваш рівень: Геній");
                break;
            case 6:
                Console.WriteLine("Ваш рівень: Ерудит");
                break;
            case 5:
                Console.WriteLine("Ваш рівень: Нормальний");
                break;
            case 4:
                Console.WriteLine("Ваш рівень: Здібності середні");
                break;
            case 3:
                Console.WriteLine("Ваш рівень: Здібності нижче середніх");
                break;
            default:
                Console.WriteLine("Ваш рівень: Треба більше тренуватися!");
                break;
        }
    }
}
