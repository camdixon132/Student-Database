



string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington",
        "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll",
           "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

bool StudentLoop = true;
bool validInput = true;
bool validNumber = true;

do
{


    Console.WriteLine("Which student would you like to learn about? Enter a number 1-16");
    int input = int.Parse(Console.ReadLine());
    int IndexNum = input - 1;


        if (IndexNum > 0 && IndexNum <= 16)
        {
       
            Console.WriteLine("Student " + input + " is " + names[IndexNum] + ". What would you like to know? Enter \"hometown\" or \"favorite food\"");

        while (validInput = true)
        {
            string answer = Console.ReadLine();


            
                if (answer == "hometown")
                {
                    Console.WriteLine(names[IndexNum] + " is from " + towns[IndexNum]);
                break;
            }
                else if (answer == "favorite food")
                {
                    Console.WriteLine(names[IndexNum] + "'s favorite food is " + foods[IndexNum]);
                break;
            }
                else
                {
                    Console.WriteLine("That category does not exist. Please try again. Enter \"hometown\" or \"favorite food\"");
                    
                }
            }
            Console.WriteLine("Would you like to learn about another student? Enter \"y\" or \"n\"");
            string again = Console.ReadLine();

            if (again == "y")
            {
                StudentLoop = true;
            }
            else
            {
                StudentLoop = false;
            }
        }
} while (StudentLoop == true);