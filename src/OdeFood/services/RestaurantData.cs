using System.Collections.Generic;
using OdeFood.Models;

namespace OdeFood.services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Tersiguelss" },
                new Restaurant {Id = 2, Name ="Tersias dfasdfs" },
                new Restaurant {Id = 3, Name ="Terasdf asdfelss" }

            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

    }
}
