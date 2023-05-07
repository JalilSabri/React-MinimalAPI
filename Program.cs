var builder = WebApplication.CreateBuilder(args);
builder.Services.InjectServices();
var app = builder.Build();

app.StudentMethods();
app.CourseMethods();
app.CourseStudentMethods();

app.Run();
