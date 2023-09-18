using Domain;
using Domain.Exceptions;

namespace BusinessLogic
{
    public class ActorService
    {
        private List<Actor> _actors;

        public ActorService() 
        { 
            _actors = new List<Actor>();
        }

        public void Add(Actor newActor)
        {
            if(_actors.Any(actor => actor.Name == newActor.Name))
            {
                throw new DuplicateEntityException($"El actor {newActor.Name} {newActor.LastName} ya existe");
            }

            _actors.Add(newActor);
        }
    }
}