var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))); // conexão do banco de dados


builder.Services.AddControllers();

builder.Services.AddScoped<IEnderecoFuncionarioRepository, EnderecoFuncionarioRepository>();
builder.Services.AddScoped<IEnderecoFuncionarioService, EnderecoFuncionarioService>();
builder.Services.AddScoped<IBeneficioService, BeneficioService>();
builder.Services.AddScoped<IBeneficioRepository, BeneficioRepository>();


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
