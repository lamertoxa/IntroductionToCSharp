bool checkExit = true;
List<string> todoList = new List<string>();

Console.WriteLine("Hello!");

void readToDo()
{
    if (todoList.Count > 0)
    {
        Console.WriteLine("ToDo List:");
        for (int i = 1; i <= todoList.Count; ++i)
        {
            Console.WriteLine($"{i}) {todoList[i - 1]}.");
        }
    }
    else
    {
        Console.WriteLine("ToDo list is empty.");
    }
    
}
do
{
    Console.WriteLine("What do you want to do?\r\n[S]ee all TODOs\r\n[A]dd a TODO\r\n[R]emove a TODO\r\n[E]xit");
    var selectOption = Console.ReadLine();
    switch (selectOption.ToUpper())
    {
        case "S":
            readToDo();
            break;
        case "A":
            Console.Write("Add new note in ToDo List:");
            var addNewNoteToDo = Console.ReadLine();
            if (todoList.Contains(addNewNoteToDo))
            {
                Console.WriteLine("The description must be unique.");
            }
            else
            {
                todoList.Add(addNewNoteToDo);
                Console.WriteLine($"New note succefully added: {addNewNoteToDo}");
            }
            break;
        case "R":
            Console.Write("Select the index of the TODO you want to remove: ");
            var indexToRemoveToDo = int.TryParse(Console.ReadLine(), out int number);
            if (!indexToRemoveToDo)
            {
                Console.WriteLine("Empty index.");
            }
            else
            {
                
                
                if (todoList.ElementAtOrDefault(number - 1) != null)
                {
                    string descriptionToDo = todoList[number - 1];
                    bool checkRemove = todoList.Remove(descriptionToDo);
                    Console.WriteLine($"TODO removed:{descriptionToDo}");
                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }
            }
            break;
        case "E":
            checkExit = false;
            break;

        default:
            Console.WriteLine("Incorrect or empty input");
            break;
    }
}

while (checkExit);

