public static class FillCourseStudentsInfo
{
    public static List<CourseStudent> lstCourseStudents { get; set; }
    = new List<CourseStudent>() {
            new CourseStudent()
            {
                CourseId = 101,
                StudentId = 2020,
                CurrentStudentNumber = 1,
                Description = "First Semester"
            },
            new CourseStudent()
            {
                CourseId = 101,
                StudentId = 2023,
                CurrentStudentNumber = 2,
                Description = "Second Semester"
            },
            new CourseStudent()
            {
                CourseId = 303,
                StudentId = 2021,
                CurrentStudentNumber = 14,
            },
            new CourseStudent()
            {
                CourseId = 303,
                StudentId = 2023,
                CurrentStudentNumber = 18,
                Description = "It will be start in next year"
            }
        };
}
