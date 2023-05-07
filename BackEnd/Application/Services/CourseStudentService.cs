public class CourseStudentService
{
    CourseStudentRepository courseStudentRepository;

    public CourseStudentService()
    {
        courseStudentRepository = new CourseStudentRepository();
    }

    public async Task<List<CourseStudent>> GetAllCourseStudents()
    {
        return await courseStudentRepository.GetAll();
    }

    public async Task<CourseStudent> GetCourseStudentById(int courseId, int studentId)
    {
        return await courseStudentRepository.GetById(courseId, studentId);
    }

    public async Task<int> AddCourseStudent(CourseStudent CourseStudent)
    {
        await courseStudentRepository.Add(CourseStudent);
        return CourseStudent.StudentId;
    }

    public async Task<int> EditCourseStudent(CourseStudent CourseStudent)
    {
        return await courseStudentRepository.Edit(CourseStudent);
    }

    public async Task RemoveCourseStudent(int courseId, int studentId)
    {
        await courseStudentRepository.Remove(courseId, studentId);
    }

}

