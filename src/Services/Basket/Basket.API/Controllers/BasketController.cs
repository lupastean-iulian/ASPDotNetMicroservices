﻿using Basket.API.Entities;
using Basket.API.GrpcServices;
using Basket.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Basket.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository _basketRepository;
        private readonly DiscountGrpcService _discountGrpcService;
        public BasketController(IBasketRepository basketRepository, DiscountGrpcService discountGrpcService)
        {
            _basketRepository = basketRepository;
            _discountGrpcService = discountGrpcService;
        }

        [HttpGet("{userName}", Name = "GetBasket")]
        [ProducesResponseType(typeof(ShopingCart), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ShopingCart>> GetBasket(string userName)
        {
            var basket = await _basketRepository.GetBasketAsync(userName);
            return Ok(basket ?? new ShopingCart(userName));
        }

        [HttpPost]
        [ProducesResponseType(typeof(ShopingCart), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ShopingCart>> UpdateBasket([FromBody] ShopingCart basket)
        {
            foreach (var item in basket.Items)
            {
                var coupon = await _discountGrpcService.GetDiscount(item.ProductName);

                item.Price -= coupon.Amount;
            }
            return Ok(await _basketRepository.UpdateBasketAsync(basket));
        }

        [HttpDelete("{userName}", Name = "DeleteBasket")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ShopingCart>> DeleteBasket(string userName)
        {
            await _basketRepository.DeleteBasketAsync(userName);
            return Ok();
        }
    }
}
