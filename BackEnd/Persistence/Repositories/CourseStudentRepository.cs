public class CourseStudentRepository
{
    public async Task<List<CourseStudent>> GetAll()
    {
        return await Task.Run(() => FillCourseStudentsInfo.lstCourseStudents);
    }

    public async Task<CourseStudent> GetById(int courseId, int studentId)
    {
        return FillCourseStudentsInfo.lstCourseStudents.FirstOrDefault(cs => cs.CourseId == courseId && cs.StudentId == studentId) ?? default!;
    }

    public async Task Add(CourseStudent CourseStudent)
    {
        await Task.Run(() => FillCourseStudentsInfo.lstCourseStudents.Add(CourseStudent));
    }

    public async Task<int> Edit(CourseStudent CourseStudent)
    {
        int result = 0;
        CourseStudent? newCourseStudent = FillCourseStudentsInfo.lstCourseStudents.FirstOrDefault(cs => cs.CourseId == CourseStudent.CourseId & cs.StudentId == CourseStudent.StudentId);
        if (newCourseStudent != null)
        {
            newCourseStudent.CurrentStudentNumber = CourseStudent.CurrentStudentNumber;
            newCourseStudent.Description = CourseStudent.Description;
            result = newCourseStudent.StudentId;
        }
        return await Task.Run(() => result);
    }

    public async Task Remove(int courseId, int studentId)
    {
        await Task.Run(() => FillCourseStudentsInfo.lstCourseStudents.RemoveAll(cs => cs.CourseId == courseId && cs.StudentId == studentId));
    }

}
