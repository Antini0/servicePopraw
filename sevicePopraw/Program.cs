using sevicePopraw.Repositories;
using sevicePopraw.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IStudentsService, StudentsService>();
builder.Services.AddScoped<IStudentsRepository, StudentsRepository>();
var app = builder.Build();

//Get api/students
// new StudentsController(new StudentsService(new StudentsRepository));


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();


app.Run();


//definicja koncowek w KONTROLERZE ktora definiuje koncówki

//SERWISY które mają logikę biznesową

//REPOZYTORIA które 

//task to obietnica ze kiedys polacze sie do bazy danych
