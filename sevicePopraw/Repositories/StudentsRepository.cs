using sevicePopraw.models;

namespace sevicePopraw.Repositories;

public class StudentsRepository : IStudentsRepository
{
    
    private static readonly List<Student> _students = new()
    {
        new Student
        {
            IdStudent = 1, FirstName = "jan", LastName = "ss", Address = "waw", Email = "asdsd", IndexNumber = 1
        },
        new Student
        {
            IdStudent = 2, FirstName = "hg", LastName = "uiui", Address = "fghgfh", Email = "xxxxx", IndexNumber = 2
        },
        new Student
        {
            IdStudent = 3, FirstName = "xcg", LastName = "nnns", Address = "gfhfgh", Email = "vmv", IndexNumber = 3
        }
    };
    
    public IEnumerable<Student> FetchStudents()
    {
        return _students;
    }
}