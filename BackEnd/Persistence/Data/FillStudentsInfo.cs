public static class FillStudentsInfo
{
    public static List<Student> lstStudents { get; set; }
    = new List<Student>() {
            new Student()
            {
                Id = 2020,
                FullName = "Jalil Sabri",
                Age = 45
            },
            new Student()
            {
                Id = 2021,
                FullName = "Avisa FirstChild",
                Age = 12
            },
            new Student()
            {
                Id = 2022,
                FullName = "Arvin Boy",
                Age = 7
            },
            new Student()
            {
                Id = 2023,
                FullName = "Avina Last daughter",
                Age = 4
            }
        };
}
