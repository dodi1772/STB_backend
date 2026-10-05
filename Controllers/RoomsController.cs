using Microsoft.AspNetCore.Mvc;

namespace STB_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly Supabase.Client _supabaseClient;
        public RoomsController(Supabase.Client supabaseClient)
        {
            _supabaseClient = supabaseClient;
        }
        [HttpGet]
        public async Task<IActionResult> GetRooms()
        {
            var rooms = await _supabaseClient.From<Room>().Get();
            return Ok(rooms.Models);
        }
    }
}
