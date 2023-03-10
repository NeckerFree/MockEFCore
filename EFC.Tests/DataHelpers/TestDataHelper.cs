using EFC.API.Models;

namespace EFC.Tests.DataHelpers
{
    internal class TestDataHelper
    {
        internal static List<Employee> GetFakeEmployeeList()
        {
            return new List<Employee>()
    {
        new Employee
        {
             EmployeeId= 1,
             Email ="email1@test.com",
             DateOfBirth= new DateTime(2000, 12, 27),
             FirstName   ="Juana",
             LastName="Brigth",
             PhoneNumber="3456789098765"

        },
        new Employee
        {
            EmployeeId= 2,
            Email ="email2@test.com",
            DateOfBirth= new DateTime(1954, 12, 27),
            FirstName   ="Diego",
            LastName="Stefan",
            PhoneNumber="3456789098765"
        }
    };
        }
    }
}