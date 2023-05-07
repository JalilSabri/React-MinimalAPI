public class CourseRepository
{
    public async Task<List<Course>> GetAll()
    {
        return await Task.Run(() => FillCoursesInfo.lstCourses);
    }

    public async Task<Course> GetById(int id)
    {
        return FillCoursesInfo.lstCourses.FirstOrDefault(s => s.Id == id) ?? default!;
    }

    public async Task Add(Course Course)
    {
        await Task.Run(() => FillCoursesInfo.lstCourses.Add(Course));
    }

    public async Task<int> Edit(Course Course)
    {
        int result = 0;
        Course? newCourse = FillCoursesInfo.lstCourses.FirstOrDefault(s => s.Id == Course.Id);
        if (newCourse != null)
        {
            newCourse.Title = Course.Title;
            newCourse.Description = Course.Description;
            result = newCourse.Id;
        }
        return await Task.Run(() => result);
    }

    public async Task Remove(int id)
    {
        await Task.Run(() => FillCoursesInfo.lstCourses.RemoveAll(s => s.Id == id));
    }

}
