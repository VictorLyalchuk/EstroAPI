﻿using Core.DTOs.User;
using Core.Helpers;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountControllers : Controller
    {
        private readonly IAccountService _accountService;

        public AccountControllers(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet("{email}")]
        public async Task<IActionResult> Get([FromRoute] string email)
        {
            try
            {
                var user = await _accountService.Get(email);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (CustomHttpException ex)
            {
                return NotFound();
            }
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO loginDTO)
        {
            var token = await _accountService.Login(loginDTO);
            return Ok(new { token });
        }
        [HttpPost("Registration")]
        public async Task<IActionResult> Registration(UserRegistrationDTO registrationDTO)
        {
            await _accountService.Registration(registrationDTO);
            return Ok();
        }


        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(UserEditDTO editDTO)
        {
            await _accountService.Edit(editDTO);
            return Ok();
        }
        [HttpPost("DeleteUserImage")]
        public async Task<IActionResult> DeleteUserImageAsync([FromForm] string email)
        {
            await _accountService.DeleteUserImage(email);
            return Ok();
        }
        [HttpPost("EditUserImage")]
        public async Task<IActionResult> EditUserImageAsync(ImageUserEditDTO editDTO)
        {
            await _accountService.EditUserImageAsync(editDTO);
            return Ok();
        }

    }
}
