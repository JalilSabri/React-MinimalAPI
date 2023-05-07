public static class FillCoursesInfo
{
    public static List<Course> lstCourses { get; set; }
    = new List<Course>() {
            new Course()
            {
                Id = 101,
                Title = "CSharp",
                Description = "Minimal Api Course"
            },
            new Course()
            {
                Id = 202,
                Title = "React",
                Description = "Using with Minimal Api"
            },
            new Course()
            {
                Id = 303,
                Title = "CQRS"
            }
        };
}
