public static class CourseApi
{
    public static void CourseMethods(this WebApplication app)
    {
        app.MapGet("/course", async (CourseService courseService) =>
        {
            return await courseService.GetAllCourses();
        });

        app.MapGet("/course/{id}", async (HttpContext context, CourseService courseService) =>
        {
            context.Request.RouteValues.TryGetValue("id", out var Id);
            return await  courseService.GetCourseById(int.Parse((string)(Id ?? 0)));
        });

        app.MapPost("/course", async (HttpContext context, CourseService courseService) =>
        {
            Course Course = await context.Request.ReadFromJsonAsync<Course>() ?? default!;
            var OpertaionResponse = await courseService.AddCourse(Course);
            await context.Response.WriteAsJsonAsync($"Course is added with this ID : {OpertaionResponse}");
        });

        app.MapPut("/course", async (HttpContext context, CourseService courseService) =>
        {
            Course Course = await context.Request.ReadFromJsonAsync<Course>() ?? default!;
            await context.Response.WriteAsJsonAsync(await courseService.EditCourse(Course) == 0 ? $"Not Found ({context.Response.StatusCode})" : "Edit is successful");
        });

        app.MapDelete("/course/{id}", async (HttpContext context, CourseService courseService) =>
        {
            context.Request.RouteValues.TryGetValue("id", out var Id);
            await courseService.RemoveCourse(int.Parse((string)(Id ?? 0)));
            return "Course is deleted";
        });

    }
}