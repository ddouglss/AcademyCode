using AcademyApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Adicione os serviços antes de chamar builder.Build()
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Adiciona suporte ao Swagger
builder.Services.AddControllers(); // Adiciona suporte para controladores

// Configuração do CORS antes de chamar builder.Build()
builder.Services.AddCors(options =>
{
    // Defina a política de CORS com nome
    options.AddPolicy("AllowAnyOriginPolicy", policy =>
    {
        policy.AllowAnyOrigin()   // Permite todas as origens
              .AllowAnyMethod()   // Permite todos os métodos HTTP (GET, POST, etc.)
              .AllowAnyHeader();  // Permite todos os cabeçalhos
    });
});

// Configure o banco de dados
builder.Services.AddDbContext<Contexto>(opcoes =>
{
    opcoes.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoBD"));
});

// Criação do aplicativo
var app = builder.Build();

// Configure o pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();         // Ativa o endpoint do Swagger JSON
    app.UseSwaggerUI();       // Ativa a interface do Swagger UI
}

// Adicione o middleware necessário
app.UseHttpsRedirection(); // Middleware para redirecionar HTTP para HTTPS
app.UseRouting(); // Configuração do roteamento
app.UseAuthorization(); // Middleware de autorização, se aplicável

// Usando a política nomeada para CORS
app.UseCors("AllowAnyOriginPolicy");

// Mapeie os controladores
app.MapControllers();

// Chama app.Run() uma única vez ao final
app.Run();

