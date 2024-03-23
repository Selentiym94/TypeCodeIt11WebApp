using TypeCodeIt11.Logic.Interfaces;
using TypeCodeIt11.Logic.Processors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string baseUrl = string.Empty;
builder.Services.AddSingleton<ITypeCodeClient, TypeCodeClient>(item => new TypeCodeClient(baseUrl));
builder.Services.AddSingleton<TypeCodeDataProcessor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())          

{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
