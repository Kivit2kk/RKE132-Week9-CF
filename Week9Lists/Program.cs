string folderPath = @"C:\Users\Kasutaja\Desktop\TKTK\Programmeerimise algkursus\Week9Lists";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath,fileName);

List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetitemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetitemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}


static List<string> GetitemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (a)/Exit (e):");
        string userChoice = Console.ReadLine();

        if (userChoice == "a")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }

        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
   Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {

        Console.WriteLine($"{i}. {item}");
        i++;
    }
}