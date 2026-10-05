using Microsoft.AspNetCore.Mvc;
using STB_backend.DTOs;
using Supabase.Gotrue;


namespace STB_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly Supabase.Client _supabaseClient;
        public UsersController(Supabase.Client supabaseClient)
        {
            _supabaseClient = supabaseClient;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _supabaseClient.From<AppUser>().Get();
            return Ok(users.Models);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserCreateDTO userDto)
        {
            var userToInsert = new AppUser
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                PhoneNumber = userDto.PhoneNumber,
                CreditBalance = 0,
                UserType = Role.USER,
                PartnerTier = PartnerTier.NONE,
                DiscountRate = 0,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsDeleted = false,
                DeletedAt = null
            };
            var response = await _supabaseClient.From<AppUser>().Insert(userToInsert);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDTO userDto)
        {
            //
            return Ok();
        }
    }
}