using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Student>> GetAll() => _repo.GetAll();
        public Task<Student> Get(int id) => _repo.GetById(id);
        public Task Add(Student student) => _repo.Add(student);
        public Task Update(Student student) => _repo.Update(student);
        public Task Delete(int id) => _repo.Delete(id);

    }
}
