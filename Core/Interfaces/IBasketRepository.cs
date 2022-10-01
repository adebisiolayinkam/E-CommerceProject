using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<CustomerBaskets> GetBasketAsync (string basketId);
        Task<CustomerBaskets> UpdateBasketAsync (CustomerBaskets baskets);
        Task<bool> DeleteBasketAsync(string basketId);
    }
}