string folderpath = @"C:\Users\henri\Documents\data";
string filename = "shoppingList.txt";
string filePath = Path.Combine(folderpath, filename);
List<string> myshoppinglist = new List<string>();


if (File.Exists(filePath))
{
    myshoppinglist = getitems();
    File.WriteAllLines(filePath, myshoppinglist);
}
else
{
   File.Create(filePath).Close();
    Console.WriteLine($"File {filename} has been created.");
    myshoppinglist = getitems();
    File.WriteAllLines(filePath, myshoppinglist);
}


static List<string> getitems()
{
    List<string> shoppinglist = new List<string>();

    while (true)
    {
        Console.WriteLine("Add item please (add) / Exit (exit)");
        string choice = Console.ReadLine();


        if (choice == "add")
        {
            Console.WriteLine("Enter an item:");
            string items = Console.ReadLine();
            shoppinglist.Add(items);
        }
        else
        {
            Console.WriteLine("Alright then.");
            break;
        }
    }
    return shoppinglist;
} 


static void showitems(List<string> somelist)
{
    Console.Clear();

    int listlength = somelist.Count;
    Console.WriteLine($"You added {listlength} items to your list.");

    int i = 0;

    foreach (string item in somelist)
    {
        Console.WriteLine($"{i + 1}. {item}");
        i++;
    }
}
