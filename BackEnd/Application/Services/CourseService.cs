public class CourseService
{
    CourseRepository courseRepository;

    public CourseService()
    {
        courseRepository = new CourseRepository();
    }

    public async Task<List<Course>> GetAllCourses()
    {
        return await courseRepository.GetAll();
    }

    public async Task<Course> GetCourseById(int id)
    {
        return await courseRepository.GetById(id);
    }

    public async Task<int> AddCourse(Course Course)
    {
        await courseRepository.Add(Course);
        return Course.Id;
    }

    public async Task<int> EditCourse(Course Course)
    {
        return await courseRepository.Edit(Course);
    }

    public async Task RemoveCourse(int id)
    {
        await courseRepository.Remove(id);
    }

}

