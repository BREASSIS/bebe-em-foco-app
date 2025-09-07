using Microsoft.AspNetCore.Mvc;

namespace BebeEmFoco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        [HttpGet("buscar-todos-apontamentos")]
        public async Task<IActionResult> GetAppointments()
        {
            return Ok(new { Message = "This is a placeholder for AppointmentsController." });
        }

        [HttpGet("buscar-apontamento/{id}")]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            return Ok(new { Message = $"This is a placeholder for AppointmentsController with ID: {id}." });
        }

        [HttpPost("criar-apontamento")]
        public async Task<IActionResult> CreateAppointment([FromBody] object appointmentData)
        {
            return Ok(new { Message = "This is a placeholder for creating a new appointment." });
        }

        [HttpPut("atualizar-apontamento/{id}")]
        public async Task<IActionResult> UpdateAppointment(int id, [FromBody] object appointmentData)
        {
            return Ok(new { Message = $"This is a placeholder for updating appointment with ID: {id}." });
        }

        [HttpDelete("deletar-apontamento/{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            return Ok(new { Message = $"This is a placeholder for deleting appointment with ID: {id}." });
        }
    }
}
