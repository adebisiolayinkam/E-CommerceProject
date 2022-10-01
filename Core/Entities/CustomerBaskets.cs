using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CustomerBaskets
    {
        public CustomerBaskets()
        {
        }

        public CustomerBaskets(string id)
        {
            Id = id;
          
        }

        public string  Id { get; set; }
        public List<BasketItems> Items {get; set;} = new List<BasketItems>();
    }
}