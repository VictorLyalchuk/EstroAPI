using Core.DTOs.User;
using Core.Entities.DashBoard;
using Core.Services;
using Microsoft.AspNetCore.Identity;


namespace Core.Interfaces
{
    public interface IAccountService
    {
        Task<UserEditDTO> Get(string id);
        Task<string> Login(UserLoginDTO loginDTO);
        Task Registration(UserRegistrationDTO registrationDTO);
        Task Edit(UserEditDTO editDTO);
        Task DeleteUserImage(string email);
        Task EditUserImageAsync(ImageUserEditDTO editDTO);

    }
}
