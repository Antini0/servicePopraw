using sevicePopraw.models;

namespace sevicePopraw.Services;

public interface IStudentsService
{
    IEnumerable<Student> GetStudents();
    int CreateStudent(Student student);
}