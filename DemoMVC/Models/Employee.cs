
namespace DemoMVC.Models;
public class Employee : Person
{
    public string EmployeeID { get; set; }
    public int Age { get; set; }

    internal static string? FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }

    internal static void Remove(string employee)
    {
        throw new NotImplementedException();
    }
}