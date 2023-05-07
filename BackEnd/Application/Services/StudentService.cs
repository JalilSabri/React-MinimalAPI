public class StudentService
{
    StudentRepository studentRepository;

    public StudentService()
    {
        studentRepository = new StudentRepository();
    }

    public async Task<List<Student>> GetAllStudents()
    {
        return await studentRepository.GetAll();
    }

    public async Task<Student> GetStudentById(int id)
    {
        return await studentRepository.GetById(id);
    }

    public async Task<int> AddStudent(Student student)
    {
        await studentRepository.Add(student);
        return student.Id;
    }

    public async Task<int> EditStudent(Student student)
    {
        return await studentRepository.Edit(student);
    }

    public async Task RemoveStudent(int id)
    {
        await studentRepository.Remove(id);
    }

}

