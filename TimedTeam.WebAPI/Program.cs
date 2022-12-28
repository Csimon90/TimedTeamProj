using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using TimedTeam.Services.Comment;
using TimedTeam.Services.Post;
using TimedTeam.Services.Reply;
using TimedTeam.Services.Token;
using TimedTeam.Services.User;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add Connection String
        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Add User Service/Interface for Dependency Injection
        builder.Services.AddScoped<IUserService, UserService>();

        // Add Token Service/Interface for Dependency Injection
        builder.Services.AddScoped<ITokenService, TokenService>();

        // Add Post Service/Interface for Dependency Injection
        builder.Services.AddScoped<IPostService, PostService>();

        // Add Comment Service/Interface for Dependency Injection
        builder.Services.AddScoped<ICommentService, CommentService>();

        // Add Reply Service/Interface for Dependency Injection
        builder.Services.AddScoped<IReplyService, ReplyService>();

        // Add Jwt Authentication
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                ValidAudience = builder.Configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
            };
        });

        // Add Swagger Authentication
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "TimedTeam.WebAPI", Version = "v1"});
            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme.\n\n Enter 'Bearer' [space] and then your token in the text input below. \n\n Example: \"Bearer 12345abcdef\""
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        // Add AuthenticationMiddleware to the IApplicationBuilder, enabling authentication capabilities
        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}


services.AddScoped<IUserService, UserService>();
services.AddScoped<IToken, TokenService>();

.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
options.RequireHttpsMetadata = false;
options.SaveToken = true;
options.TokenValidationParameters = new TokenValidationParameters
{
ValidateIssuer = true,
ValidateAudience = true,
ValidIssuer = Configuration["Jwt:Issuer"],
ValidAudience = Configuration["Jwt:Audience"],
IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
};

});

app.UseAuthentication();

app.UseAuthorization();




