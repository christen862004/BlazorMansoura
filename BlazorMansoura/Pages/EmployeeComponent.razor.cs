namespace BlazorMansoura.Pages
{
    public partial class EmployeeComponent
    {
        public Employee EmpObj { get; set; }

        public EmployeeComponent()
        {
            
            EmpObj = new Employee()
            {
                Id = 1,
                Name = "Ahmed",
                Salary = 17000,
                ImagURl = "Man.png"
            };

        }
    }
}
