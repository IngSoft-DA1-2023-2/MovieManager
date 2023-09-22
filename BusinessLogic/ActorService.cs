using Domain;
using Domain.Exceptions;

namespace BusinessLogic
{
    public class ActorService
    {
        private readonly MemoryDatabase _database;

        public ActorService(MemoryDatabase memoryDatabase) 
        {
            _database = memoryDatabase;
        }

        public void Add(Actor newActor)
        {
            if(_database.Actors.Any(actor => actor.Name == newActor.Name))
            {
                throw new DuplicateEntityException($"El actor {newActor.Name} {newActor.LastName} ya existe");
            }

            _database.Actors.Add(newActor);
        }
    }
}