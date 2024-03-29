﻿using AutoMapper;
using Core.DTOs.Information;
using Core.Entities.DashBoard;
using Core.Entities.Information;
using Core.Entities.Site;
using Core.Interfaces;
using Core.Mapper;
using Core.Specification;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderItems> _orderItemsRepository;
        private readonly IRepository<Bag> _bagRepository;
        private readonly IRepository<BagItems> _bagItemsRepository;
        private readonly UserManager<User> _userManager;
        public OrderService(IRepository<Order> repositoryRepository, IMapper mapper, IRepository<Bag> bagRepository, UserManager<User> userManager, IRepository<BagItems> bagItemsRepository, IRepository<OrderItems> orderItemsRepository)
        {
            _mapper = mapper;
            _orderRepository = repositoryRepository;
            _bagRepository = bagRepository;
            _userManager = userManager;
            _bagItemsRepository = bagItemsRepository;
            _orderItemsRepository = orderItemsRepository;

        }
        public async Task CreateAsync(OrderCreateDTO orderCreateDTO)
        {
            var bag = await _bagRepository.GetItemBySpec(new BagSpecification.GetBagByUserEmail(orderCreateDTO.EmailUser));
            if (bag != null)
            {
                var user = await _userManager.FindByEmailAsync(orderCreateDTO.EmailUser);

                Order order = new Order()
                {
                    Address = orderCreateDTO.Address,
                    Email = orderCreateDTO.Email,
                    EmailUser = orderCreateDTO.EmailUser,
                    FirstName = orderCreateDTO.FirstName,
                    LastName = orderCreateDTO.LastName,
                    OrderDate = DateTime.Now,
                    PhoneNumber = orderCreateDTO.PhoneNumber,
                    Payment = "Not payment",
                    Status = "Not delivered",
                    UserId = user.Id, 
                };
                await _orderRepository.InsertAsync(order);
                await _orderRepository.SaveAsync();

                if (user != null)
                {
                    user.BagId = null;
                    var result = await _userManager.UpdateAsync(user);
                }

                var bagItems = await _bagItemsRepository.GetListBySpec(new BagItemsSpecification.GetBagItemsByBagEmail(orderCreateDTO.EmailUser));

                foreach (var item in bagItems)
                {
                    OrderItems orderItems = new OrderItems()
                    {
                        Quantity = item.Quantity,
                        Name = item.Product.Name,
                        Price = item.Product.Price,
                        Size = item.Size,
                        Article = item.Product.Article,
                        ImagePath = item.Product.Images.FirstOrDefault().ImagePath,
                        OrderId = order.Id,
                        ProductId = item.ProductId,
                    };
                    await _orderItemsRepository.InsertAsync(orderItems);
                    await _orderItemsRepository.SaveAsync();
                }
                //await _bagRepository.DeleteAsync(bag);
                await _bagRepository.DeleteAsync(bag.Id);
                await _bagRepository.SaveAsync();

            }
        }
    }
}
