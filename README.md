# Robot-Factory
This is for the challenge Robot Factory in C# Players Guide Fifth Edition.

Create a new dynamic variable, holding a reference to an ExpandoObject.
Give the dynamic object an ID property whose type is int and assign each robot a new number.
Ask the user if they want to name the robot, and if they do, collect it and store it in a Name property.
Ask if they want to provide a size for the robot. If so, collect a width and height from the user and store those in Widith and Height properties.
Ask if they want to choose a color for the robot. If so, store their choice in a Color property.
Display all existing properties for the robot to the console window using the following code:
foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot)
Console.WriteLine($"{property.Key}: {property.Value}").
Loop repeatedly to allow the user to design and build multiple robots.
