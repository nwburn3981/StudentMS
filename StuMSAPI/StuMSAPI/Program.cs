using StuMSAPI;
using Microsoft.EntityFrameworkCore;
using StuMSAPI.Repo;
using StuMSAPI.Repo.IRepo;
using StuMSAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddScoped<IStudentRepo, StudentRepo>();
//builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
//builder.Services.AddScoped<IGradeRepo, GradeRepo>();
//builder.Services.AddScoped<ICourseRepo, CourseRepo>();
//builder.Services.AddAutoMapper(typeof(MappingConfig));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);



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
