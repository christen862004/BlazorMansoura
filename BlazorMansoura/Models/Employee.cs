using System.ComponentModel.DataAnnotations;

namespace BlazorMansoura.Models
{
    public class Employee
    {
        public int Id { get; set; }
        //[UniqueId]   
        [MinLength(3,ErrorMessage ="Name Must be More Than 3 chars")]
        [MaxLength(20,ErrorMessage ="Name Must be Less Than 20 Char")]
        public string Name { get; set; }

        [Range(6000,25000,ErrorMessage ="Salary Between 6000 : 25000")]
        public int Salary { get; set; }
        
        [RegularExpression(@"\w+\.(jpg|png)",ErrorMessage ="Image Must Be JPG | PNG")]
        public string ImagURl { get; set; }

        public int Dept_Id { get; set; }


    }
}
