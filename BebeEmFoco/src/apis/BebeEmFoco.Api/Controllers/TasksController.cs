using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BebeEmFoco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet("buscar-todas-tarefas")]
        public async Task<IActionResult> GetTasks()
        {
            return Ok(new { Message = "This is a placeholder for TasksController." });
        }

        [HttpGet("buscar-tarefa/{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            return Ok(new { Message = $"This is a placeholder for TasksController with ID: {id}." });
        }

        [HttpPost("criar-tarefa")]
        public async Task<IActionResult> CreateTask([FromBody] object taskData)
        {
            return Ok(new { Message = "This is a placeholder for creating a new task." });
        }

        [HttpPut("atualizar-tarefa/{id}")]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] object taskData)
        {
            return Ok(new { Message = $"This is a placeholder for updating task with ID: {id}." });
        }

        [HttpDelete("deletar-tarefa/{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            return Ok(new { Message = $"This is a placeholder for deleting task with ID: {id}." });
        }
    }
}
