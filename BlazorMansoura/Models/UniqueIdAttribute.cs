using System.ComponentModel.DataAnnotations;

namespace BlazorMansoura.Models
{
    public class UniqueIdAttribute:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            //api id =>obj
            return base.IsValid(value);
        }
    }
}
