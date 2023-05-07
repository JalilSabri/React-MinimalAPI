public interface IStudentRepository
{
    public Task<List<Student>> GetAll();
    public Task<Student> GetById(int id);
    public Task AddStudent(Student student);
    public Task EditStudent(Student student);
    public Task DeleteStudent(int id);
}
