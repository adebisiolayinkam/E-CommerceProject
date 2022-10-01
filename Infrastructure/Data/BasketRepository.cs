using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using StackExchange.Redis;

namespace Infrastructure.Data
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;
        public BasketRepository(IConnectionMultiplexer redis)
        {
            _database = redis.GetDatabase();
        }

        public async Task<bool> DeleteBasketAsync(string basketId)
        {
            return await _database.KeyDeleteAsync(basketId);
        }

        public async Task<CustomerBaskets> GetBasketAsync(string basketId)
        {
            var data = await _database.StringGetAsync(basketId);

            return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerBaskets>(data);
        }

        public async Task<CustomerBaskets> UpdateBasketAsync(CustomerBaskets baskets)
        {
            var created = await _database.StringSetAsync(baskets.Id, 
            JsonSerializer.Serialize(baskets), TimeSpan.FromDays(30));

            if (!created) return null;

            return await GetBasketAsync(baskets.Id);
        }
    }
}