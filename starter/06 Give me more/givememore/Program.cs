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

//endopint que regrese una lista de usuarios con nombre y username
app.MapGet("/users", () =>
{
    var users = new[]
    {
        new { Name = "John Doe", Username = "johndoe" },
        new { Name = "Jane Doe", Username = "janedoe" },
        new { Name = "Alice", Username = "alice" },
        new { Name = "Bob", Username = "bob" }
    };
    return users;
})
.WithName("GetUsers")
.WithOpenApi();

//endopint que regrese un usuario especifico por username
app.MapGet("/users/{username}", (string username) =>
{
    var users = new[]
    {
        new { Name = "John Doe", Username = "johndoe" },
        new { Name = "Jane Doe", Username = "janedoe" },
        new { Name = "Alice", Username = "alice" },
        new { Name = "Bob", Username = "bob" }
    };
    return users.FirstOrDefault(u => u.Username == username);
})
.WithName("GetUser")
.WithOpenApi();




app.Run();
