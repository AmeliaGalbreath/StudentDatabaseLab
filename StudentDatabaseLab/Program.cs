int answer = 1;
bool tryAgain = true;
while (tryAgain)
{
    string[] studentsName = { "Jinki Lee", "Jonghyun Kim", "Kibum Kim", "Minho Choi", "Taemin Lee", "Seungcheol Choi", "Soonyoung Kwon", "Jeonghan Yoon", "Hansol Chwe", "Minghao Xu", "Jihoon Lee", "Mingyu Kim", "Seokmin Lee", "Wonwoo Jeon", "Seungkwan Boo", "Junhui Wen", "Chan Lee", "Joshua Hong" };
    string[] studentsFood = { "Teokkbokki", "Dolsot Bibimbap", "Kimbap", "Pizza", "Sushi", "Gyoza", "Spaghetti", "Steak", "Rice", "Ramyeon", "Pad Thai", "Steak", "BBQ", "Thai", "Tacos", "Steak", "Spaghetti", "Dolsot Bibimbap" };
    string[] studentsHometown = { "Gwangmyeong, Gyeonggi-do, South Korea", "Seoul, South Korea", "Daegu, South Korea", "Incheon, South Korea", "Seoul, South Korea", "Daegu, South Korea", "Namyangju-si, Gyeonggi-do, South Korea", "Hwaseong, South Korea", "New York, USA", "Haicheng, Liaoning, China", "Busan, South Korea", "Anyang-si, Gyeonggi-do, South Korea", "Suji-gu, Yongin-si, Gyeonggi-do, South Korea", "Changwon, Gyeongsangnam-do, South Korea", "Busan, South Korea", "Shenzen, Guangdong, China", "Iksan-si, Jeollakbu-do, South Korea", "Los Angeles, USA" };

    while (true)
    {
        Console.Write("Which student would you like to learn more about? Enter a number 1-18: ");
        answer = int.Parse(Console.ReadLine());

        if (answer > 0 && answer <= studentsName.Length)
        {
            break;
        }
        Console.WriteLine("That was not a number between 1 and 18.");
    }

    int index = answer - 1;
    while (true)
    {
        Console.Write($"Student {answer} is {studentsName[index]}. What would you like to know? Enter 'Hometown' or 'Favorite Food': ");
        string choice1 = Console.ReadLine();

        if ("hometown".Contains(choice1.ToLower().Trim()))
        {
            Console.WriteLine($"{studentsName[index]} is from {studentsHometown[index]}.\n");
        }
        else if ("favorite food".Contains(choice1.ToLower().Trim()))
        {
            Console.WriteLine($"{studentsName[index]}'s favorite food is {studentsFood[index]}.\n");
        }
        else
        {
            Console.WriteLine("That is not a valid option. Please try again.\n");
            continue;
        }
        break;
    }

    while (true)
    {
        Console.Write("Would you like to learn about another student? (y/n): ");
        string continueChoice = Console.ReadLine();
        if (continueChoice.ToLower().Trim() == "y")
        {
            break;
        }
        else if (continueChoice.ToLower().Trim() == "n")
        {
            tryAgain = false;
            break;
        }
    }
}
Console.WriteLine("Goodbye!");


