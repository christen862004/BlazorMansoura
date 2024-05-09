using Microsoft.AspNetCore.Components;

namespace BlazorMansoura.Pages.EmployeePages
{
    public partial class EditEmployeeComponent
    {
        [Parameter]
        public int id { get; set; }

        public Employee EmpObj { get; set; }

        public List<Department> DeptList { get; set; }

        [Inject]
        public IService<Department> DeptService { get; set; }
        public bool ISvalid { get; set; } = true;
        // [Inject]
        // public IService<Employee> EmpService { get; set; }

        [Inject]
        public NavigationManager NavManager { get; set; }//built service already register IOC 

        protected override void OnInitialized()
        {
            EmpObj = EmpService.GetById(id);
            DeptList = DeptService.GetAll();
            base.OnInitialized();
        }
        private void SaveData()
        {
            Console.WriteLine("Data Saved");
            NavManager.NavigateTo("/Employees");
        }
        private void InvalidMethod()
        {
            ISvalid = false;
            Console.WriteLine("Invalid Employee Data");
        }
    }
}
