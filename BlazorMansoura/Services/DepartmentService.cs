
namespace BlazorMansoura.Services
{
    public class DepartmentService : IService<Department>
    {
        List<Department> Depts { get; set; } 
            = new List<Department>();
        public DepartmentService()
        {
            Depts.Add(new Department() { Id = 1, Name = "SD" });
            Depts.Add(new Department() { Id = 2, Name = "Web & Mobile" });
            Depts.Add(new Department() { Id = 3, Name = "2D" });
            Depts.Add(new Department() { Id = 4, Name = "Digital Marketing" });

        }
        public List<Department> GetAll()
        {
            return Depts;
        }

        public Department GetById(int id)
        {
            return Depts.FirstOrDefault(d => d.Id == id);
        }
    }
}
