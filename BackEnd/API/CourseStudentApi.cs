public static class CourseStudentApi
{
    public static void CourseStudentMethods(this WebApplication app)
    {
        app.MapGet("/CourseStudent", async (CourseStudentService courseStudentService) =>
        {
            return await courseStudentService.GetAllCourseStudents();
        });

        app.MapGet("/CourseStudent/{courseid}/{studentid}", async (HttpContext context, CourseStudentService courseStudentService) =>
        {
            context.Request.RouteValues.TryGetValue("courseid", out var CourseId);
            context.Request.RouteValues.TryGetValue("studentid", out var StudentId);
            return await courseStudentService.GetCourseStudentById(int.Parse((string)(CourseId ?? 0)), int.Parse((string)(StudentId ?? 0)));
        });

        app.MapPost("/CourseStudent", async (HttpContext context, CourseStudentService courseStudentService) =>
        {
            CourseStudent CourseStudent = await context.Request.ReadFromJsonAsync<CourseStudent>() ?? default!;
            var OpertaionResponse = await courseStudentService.AddCourseStudent(CourseStudent);
            await context.Response.WriteAsJsonAsync($"CourseStudent is added with this ID : {OpertaionResponse}");
        });

        app.MapPut("/CourseStudent", async (HttpContext context, CourseStudentService courseStudentService) =>
        {
            CourseStudent CourseStudent = await context.Request.ReadFromJsonAsync<CourseStudent>() ?? default!;
            await context.Response.WriteAsJsonAsync(await courseStudentService.EditCourseStudent(CourseStudent) == 0 ? $"Not Found ({context.Response.StatusCode})" : "Edit is successful");
        });

        app.MapDelete("/CourseStudent/{courseid}/{studentid}", async (HttpContext context, CourseStudentService courseStudentService) =>
        {
            context.Request.RouteValues.TryGetValue("courseid", out var CourseId);
            context.Request.RouteValues.TryGetValue("studentid", out var StudentId);
            await courseStudentService.RemoveCourseStudent(int.Parse((string)(CourseId ?? 0)), int.Parse((string)(StudentId ?? 0)));
            return "CourseStudent is deleted";
        });

    }
}
