using System.Dynamic;
using System.Linq.Expressions;

int nextID = 1;
while (true)
{
    dynamic robot = new  ExpandoObject();
    robot.Id = nextID;
    nextID++;

    Console.WriteLine($"You are producing robot #{robot.Id}");

    Console.WriteLine("Do you want to name this robot? ");
    if(Console.ReadLine() == "yes")
    {
        Console.WriteLine("what would you like its name to be?");
        robot.name = Console.ReadLine();
    }

    Console.WriteLine("Do you want this robot to have a specific size?");
    if(Console.ReadLine() == "yes")
    {
        Console.WriteLine("What height would you like it to have?");
        robot.Height = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("What would you like its width to be?");
        robot.Width = Convert.ToSingle(Console.ReadLine());
    }

    Console.WriteLine("Do you want the robot to be a specific color?");
    if(Console.ReadLine() == "yes")
    {
        Console.WriteLine("What color would like this robot to be?");
        robot.Color = Console.ReadLine();
    }

    foreach(KeyValuePair<string, object> property in (IDictionary<string, object>) robot)
    {
        Console.WriteLine($"{property.Key}: {property.Value}");
    }
}