using Microsoft.AspNetCore.Mvc;

namespace STB_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly Supabase.Client _supabaseClient;
        public AssetsController(Supabase.Client supabaseClient)
        {
            _supabaseClient = supabaseClient;
        }
        [HttpGet]
        public async Task<IActionResult> GetAssets()
        {
            var assets = await _supabaseClient.From<Asset>().Get();
            return Ok(assets.Models);
        }
    }
}
