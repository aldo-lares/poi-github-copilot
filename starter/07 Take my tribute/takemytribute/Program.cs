var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var users = new List<User>();
var userCount = 0;

// endpoint que permita ingresar un usuario que reciba la informacio de un usuario y regrese un id autogenerado y cuente el numero de usuario insertados
app.MapPost("/users", (User newUser) =>
{
    
    newUser.Id = Guid.NewGuid().ToString();
    
    // Incrementar el contador de usuarios
    userCount++;

    newUser.userCount = userCount;
    // Agregar el nuevo usuario a la lista
    users.Add(newUser);  

    // Devolver el ID del nuevo usuario
    return Results.Created($"/users/{newUser.Id}", newUser);
})
.WithName("PostUser")
.WithOpenApi();



app.Run();


public class User
{
    public string Id { get; init; }
    public string Username { get; init; }
    public string Name { get; init; }
    public int userCount { get; init; }
}
