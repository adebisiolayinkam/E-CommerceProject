using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;
        public BasketController(IBasketRepository basketRepository, IMapper mapper)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBaskets>> GetBasketById(string id)
        {
            var baskets = await _basketRepository.GetBasketAsync(id);

            return Ok(baskets ?? new CustomerBaskets(id));
        }

         [HttpPost]
        public async Task<ActionResult<CustomerBaskets>> UpdateBasket(CustomerBasketDto baskets)
        {
          var customerBasket = _mapper.Map<CustomerBasketDto, CustomerBaskets>(baskets);

          var  updatedBasket = await _basketRepository.UpdateBasketAsync(customerBasket);

          return Ok(updatedBasket);
        }

         [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }
    }
}