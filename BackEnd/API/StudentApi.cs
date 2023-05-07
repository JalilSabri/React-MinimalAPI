public static class StudentApi
{
    public static void StudentMethods(this WebApplication app)
    {
        app.MapGet("/student", async (StudentService studentService) =>
        {
            return await studentService.GetAllStudents();
        });

        app.MapGet("/student/{id}", async (HttpContext context, StudentService studentService) =>
        {
            context.Request.RouteValues.TryGetValue("id", out var Id);
            return await studentService.GetStudentById(int.Parse((string)(Id ?? 0)));
        });

        app.MapPost("/student", async (HttpContext context, StudentService studentService) =>
        {
            Student student = await context.Request.ReadFromJsonAsync<Student>() ?? default!;
            var OpertaionResponse = await studentService.AddStudent(student);
            await context.Response.WriteAsJsonAsync($"Student is added with this ID : {OpertaionResponse}");
        });

        app.MapPut("/student", async (HttpContext context, StudentService studentService) =>
        {
            Student student = await context.Request.ReadFromJsonAsync<Student>() ?? default!;
            await context.Response.WriteAsJsonAsync(await studentService.EditStudent(student) == 0 ? $"Not Found ({context.Response.StatusCode})" : "Edit is successful");
        });

        app.MapDelete("/student/{id}", async (HttpContext context, StudentService studentService) =>
        {
            context.Request.RouteValues.TryGetValue("id", out var Id);
            await studentService.RemoveStudent(int.Parse((string)(Id ?? 0)));
            return "Student is deleted";
        });

    }
}
