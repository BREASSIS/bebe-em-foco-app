using Microsoft.AspNetCore.Mvc;

namespace BebeEmFoco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PregnantsController : ControllerBase
    {
        [HttpGet("buscar-info-gestante")]
        public async Task<IActionResult> GetPregnants()
        {
            return Ok(new { Message = "This is a placeholder for PregnantsController." });
        }

        [HttpGet("buscar-info-gestante/{id}")]
        public async Task<IActionResult> GetPregnantById(int id)
        {
            return Ok(new { Message = $"This is a placeholder for PregnantsController with ID: {id}." });
        }

        [HttpPost("criar-info-gestante")]
        public async Task<IActionResult> CreatePregnant([FromBody] object pregnantData)
        {
            return Ok(new { Message = "This is a placeholder for creating a new pregnant info." });
        }

        [HttpPut("atualizar-info-gestante/{id}")]
        public async Task<IActionResult> UpdatePregnant(int id, [FromBody] object pregnantData)
        {
            return Ok(new { Message = $"This is a placeholder for updating pregnant info with ID: {id}." });
        }

        [HttpDelete("deletar-info-gestante/{id}")]
        public async Task<IActionResult> DeletePregnant(int id)
        {
            return Ok(new { Message = $"This is a placeholder for deleting pregnant info with ID: {id}." });
        }
    }
}
