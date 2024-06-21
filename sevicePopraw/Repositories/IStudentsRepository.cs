using sevicePopraw.models;

namespace sevicePopraw.Repositories;

public interface IStudentsRepository
{
    IEnumerable<Student> FetchStudents();
}