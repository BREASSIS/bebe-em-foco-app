using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BebeEmFoco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationsController : ControllerBase
    {
        [HttpGet("buscar-todos-medicamentos")]
        public async Task<IActionResult> GetMedications()
        {
            return Ok(new { Message = "This is a placeholder for MedicationsController." });
        }

        [HttpGet("buscar-medicamento/{id}")]
        public async Task<IActionResult> GetMedicationById(int id)
        {
            return Ok(new { Message = $"This is a placeholder for MedicationsController with ID: {id}." });
        }

        [HttpPost("criar-medicamento")]
        public async Task<IActionResult> CreateMedication([FromBody] object medicationData)
        {
            return Ok(new { Message = "This is a placeholder for creating a new medication." });
        }

        [HttpPut("atualizar-medicamento/{id}")]
        public async Task<IActionResult> UpdateMedication(int id, [FromBody] object medicationData)
        {
            return Ok(new { Message = $"This is a placeholder for updating medication with ID: {id}." });
        }

        [HttpDelete("deletar-medicamento/{id}")]
        public async Task<IActionResult> DeleteMedication(int id)
        {
            return Ok(new { Message = $"This is a placeholder for deleting medication with ID: {id}." });
        }
    }
}
