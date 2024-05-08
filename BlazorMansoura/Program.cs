using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorMansoura
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            //display conent
            builder.RootComponents.Add<App>("#app");
            //Change title
            builder.RootComponents.Add<HeadOutlet>("head::after");
            //inject Day3
            builder.Services.AddScoped<IService<Department>, DepartmentService>();

            builder.Services.AddScoped<IService<Employee>, EmployeeService>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
