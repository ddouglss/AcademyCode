using AcademyApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly Contexto _context;

        public UsuarioController(Contexto context)
        {
            _context = context;
        }

        // Endpoint para listar todos os usuários
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return Ok(usuarios);
        }

        // Endpoint de Login (sem token)
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            if (string.IsNullOrEmpty(loginRequest.Email) || string.IsNullOrEmpty(loginRequest.Senha))
            {
                return BadRequest(new { message = "Email e Senha são obrigatórios" });
            }

            

            return Ok(new { message = "Login realizado com sucesso", nome = "Usuário de Exemplo" });
        }

        // Endpoint de Cadastro
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Retorna os erros de validação no modelo
            }

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        // Endpoint para buscar um usuário por ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound(); // Retorna 404 se não encontrar o usuário
            }
            return Ok(usuario); // Retorna o usuário se encontrado
        }

        // Endpoint para listar cursos
        [HttpGet("cursos")]
        public async Task<IActionResult> GetCursos()
        {
            var cursos = await _context.Cursos.ToListAsync();
            return Ok(cursos);
        }



        // Endpoint para atualizar um usuário (PUT)
        [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Usuario usuario)
    {
        var existingUser = await _context.Usuarios.FindAsync(id);
        if (existingUser == null)
        {
            return NotFound();
        }

        // Atualização dos dados do usuário
        existingUser.Nome = usuario.Nome;
        existingUser.Sobrenome = usuario.Sobrenome;
        existingUser.Telefone = usuario.Telefone;
        existingUser.Email = usuario.Email;
        existingUser.Cidade = usuario.Cidade;
        existingUser.Senha = usuario.Senha;
        existingUser.AreaCurso = usuario.AreaCurso;

        await _context.SaveChangesAsync();

        return NoContent(); 
    }


        // Endpoint para deletar um usuário (DELETE)
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound(); // Retorna 404 se o usuário não for encontrado
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent(); // Retorna 204 No Content indicando que a exclusão foi bem-sucedida
        }
    }
}
