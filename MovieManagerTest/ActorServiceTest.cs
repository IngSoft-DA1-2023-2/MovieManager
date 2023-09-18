using BusinessLogic;
using Domain;
using Domain.Exceptions;

namespace MovieManagerTest
{
    [TestClass]
    public class ActorServiceTest
    {
        private ActorService _service;

        [TestInitialize]
        public void Initialize() 
        { 
            _service = new ActorService();
        }

        [ExpectedException(typeof(DuplicateEntityException))]
        [TestMethod]
        public void AddDuplicateActorTest()
        {
            var actor = new Actor
            {
                Name = "Joaquin",
                LastName = "Mendez",
                Age = 25,
            };

            _service.Add(actor);
            _service.Add(actor);
        }
    }
}