public class StudentRepository
{
    public async Task<List<Student>> GetAll()
    {
        return await Task.Run(() => FillStudentsInfo.lstStudents);
    }

    public async Task<Student> GetById(int id)
    {
        return FillStudentsInfo.lstStudents.FirstOrDefault(s => s.Id == id) ?? default!;
    }

    public async Task Add(Student student)
    {
        await Task.Run(() => FillStudentsInfo.lstStudents.Add(student));
    }

    public async Task<int> Edit(Student student)
    {
        int result = 0;
        Student? newStudent = FillStudentsInfo.lstStudents.FirstOrDefault(s => s.Id == student.Id);
        if (newStudent != null)
        {
            newStudent.FullName = student.FullName;
            newStudent.Age = student.Age;
            result = newStudent.Id;
        }
        return await Task.Run(() => result);
    }

    public async Task Remove(int id)
    {
        await Task.Run(() => FillStudentsInfo.lstStudents.RemoveAll(s => s.Id == id));
    }

}
