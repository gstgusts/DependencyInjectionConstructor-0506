using System.Collections.Generic;
namespace DependencyInjectionDesignPattern
{
    //Service Class or Dependency Object
    //Dependency Object should be Interface-Based
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}