using StudentManagementAPI.Models;

namespace StudentManagementAPI.Service
{
    public interface IStudentService    
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Get(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(int id);

    }
}
