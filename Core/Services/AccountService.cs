using AutoMapper;
using Core.DTOs.Site;
using Core.DTOs.User;
using Core.Entities.DashBoard;
using Core.Entities.Site;
using Core.Helpers;
using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AccountService(UserManager<User> userManager, IConfiguration configuration, IMapper mapper)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<UserEditDTO> Get(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                return _mapper.Map<UserEditDTO>(user);
            }
            else
                throw new CustomHttpException(ErrorMessages.UserNotFoundById, HttpStatusCode.NotFound);
        }
        public async Task<string> Login(UserLoginDTO loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.Email);
            var pass = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.UserNotFoundById, HttpStatusCode.BadRequest);
            }
            if (user == null || !pass)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }

            var claimsList = new List<Claim>()
            {
                new Claim("Email", loginDTO.Email),
                new Claim("FirstName", user.FirstName),
                new Claim("LastName", user.LastName),
                new Claim("ImagePath", user.ImagePath),
                new Claim("Role", user.Role),
                new Claim("Id", user.Id),
            };
            var jwtOptions = _configuration.GetSection("Jwt").Get<JwtOptions>();
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions!.Key));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtOptions.Issuer,
                claims: claimsList,
                expires: DateTime.Now.AddMinutes(jwtOptions.LifeTime),
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task Registration(UserRegistrationDTO registrationDTO)
        {
            User user = new User()
            {
                Email = registrationDTO.Email,
                UserName = registrationDTO.Email,
                FirstName = registrationDTO.FirstName,
                LastName = registrationDTO.LastName,
            };
            var result = await _userManager.CreateAsync(user, registrationDTO.Password);
            if (!result.Succeeded)
            {
                var messageError = string.Join(",", result.Errors.Select(er => er.Description));
                throw new CustomHttpException(messageError, System.Net.HttpStatusCode.BadRequest);
            }
        }
        public async Task Edit(UserEditDTO editDTO)
        {
            var user = await _userManager.FindByEmailAsync(editDTO.Email);
            var pass = await _userManager.CheckPasswordAsync(user, editDTO.Password);

            if (user == null || !pass)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }
            if (user.Email != editDTO.Email)
            {
                user.EmailConfirmed = false;
                var confirmationResut = await _userManager.UpdateAsync(user);
            }
            if (user != null)
            {
                User updatedUser = _mapper.Map<User>(user);
                updatedUser.UserName = editDTO.Email;
                updatedUser.Email = editDTO.Email;
                updatedUser.FirstName = editDTO.FirstName;
                updatedUser.LastName = editDTO.LastName;
                updatedUser.PhoneNumber = editDTO.PhoneNumber;
                updatedUser.ImagePath = editDTO.ImagePath;
                updatedUser.Birthday = editDTO.Birthday;
                var result = await _userManager.UpdateAsync(updatedUser);
            }
        }
        public async Task DeleteUserImage(string email)
        {

            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                user.ImagePath = "";
                await _userManager.UpdateAsync(user);

            }
        }
        public async Task EditUserImageAsync(ImageUserEditDTO editDTO)
        {
            var user = await _userManager.FindByEmailAsync(editDTO.Email);
            if (user != null)
            {
                User updatedUser = _mapper.Map<User>(user);
                updatedUser.ImagePath = editDTO.ImagePath;
                var result = await _userManager.UpdateAsync(updatedUser);
            }
        }
    }
}
