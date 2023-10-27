using Domain;
using Domain.Exceptions;

namespace BusinessLogic
{
    public class ActorService
    {
        private readonly MovieManagerContext _database;

        public ActorService(MovieManagerContext database) 
        {
            _database = database;
        }

        public void Add(Actor newActor)
        {
            if(_database.Actors.Any(actor => actor.Name == newActor.Name))
            {
                throw new DuplicateEntityException($"El actor {newActor.Name} {newActor.LastName} ya existe");
            }

            _database.Actors.Add(newActor);
            _database.SaveChanges();
        }

        public Actor Get(string name)
        {
            return _database.Actors.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}