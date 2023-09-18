using BusinessLogic;
using Domain;
using Domain.Exceptions;

try
{
    var actor = new Actor()
    {
        Name = "Joaquin",
        LastName = "Mendez",
        Age = 25,
    };

    var actorService = new ActorService();
    actorService.Add(actor);
    actorService.Add(actor);
}
catch(DuplicateEntityException exception)
{
    Console.WriteLine("Excepcion producida en la capa de servicios");
    Console.WriteLine(exception.Message);
    Console.ReadLine();
}
catch (RequiredPropertyException exception)
{
    Console.WriteLine("Excepcion producida en la capa de dominio");
    Console.WriteLine(exception.Message);
    Console.ReadLine();
}