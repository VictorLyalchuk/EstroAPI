﻿using Core.DTOs.Site;
using Core.Entities.Site;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageControllers : Controller
    {
        private readonly IStorageService _storage;
        public StorageControllers(IStorageService storage)
        {
            _storage = storage;
        }
        [HttpPost("AddQuantityStorage")]
        public async Task<IActionResult> AddQuantityStorage(StorageDTO [] storagesDTO)
        {
            await _storage.AddQuantityStorageAsync(storagesDTO);
            return Ok();
        }
    }
}
