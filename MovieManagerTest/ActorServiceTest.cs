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
            _service = new ActorService(TestContextFactory.CreateContext());
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

        [TestMethod]
        public void AddActorTest()
        {
            var actor = new Actor
            {
                Name = "Joaquin",
                LastName = "Mendez",
                Age = 25,
            };

            _service.Add(actor);
            var result = _service.Get(actor.Name);
            
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Name, actor.Name);
        }
    }
}