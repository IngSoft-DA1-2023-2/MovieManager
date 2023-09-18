using Domain;

try
{
    var actor = new Actor()
    {
        Name = "",
        LastName = "Mendez",
        Age = 25,
    };
    Console.WriteLine(actor.ToString());
    Console.ReadLine();
}catch(ArgumentException exception)
{
    Console.WriteLine(exception.Message);
    Console.ReadLine();
}