public static class InjectDependancies
{
    public static void InjectServices(this IServiceCollection services)
    {
        services.AddSingleton(new StudentService());
        services.AddSingleton(new CourseService());
        services.AddSingleton(new CourseStudentService());
    }
}

