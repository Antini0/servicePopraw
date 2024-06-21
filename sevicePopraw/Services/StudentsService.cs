using sevicePopraw.models;
using sevicePopraw.Repositories;

namespace sevicePopraw.Services;

public class StudentsService : IStudentsService
{

    private readonly IStudentsRepository _studentsRepository;

    public StudentsService(IStudentsRepository studentsRepository)
    {
        _studentsRepository = studentsRepository;
    }

    public IEnumerable<Student> GetStudents()
    {
        var data = _studentsRepository.FetchStudents();
        return data;
    }

    public int CreateStudent(Student student)
    {
        _students.Add(student);
        return 1;
    }
}