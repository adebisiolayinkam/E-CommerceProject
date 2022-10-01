using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepository;
        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBaskets>> GetBasketById(string id)
        {
            var baskets = await _basketRepository.GetBasketAsync(id);

            return Ok(baskets ?? new CustomerBaskets(id));
        }

         [HttpPost]
        public async Task<ActionResult<CustomerBaskets>> UpdateBasket(CustomerBaskets baskets)
        {
          var  UpdateBasket = await _basketRepository.UpdateBasketAsync(baskets);

          return Ok(UpdateBasket);
        }

         [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }
    }
}