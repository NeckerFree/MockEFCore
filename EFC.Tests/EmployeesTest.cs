using EFC.API.Models;
using Microsoft.EntityFrameworkCore;
using Moq.EntityFrameworkCore;

namespace EFC.Tests
{
    public class EmployeesTest
    {



        [Fact]
        public async Task GetEmployees_WhenCalled_ReturnsEmployeeListAsync()
        {
            // Arrange
            var employeeContextMock = new Mock<EmployeeContext>();
            employeeContextMock.Setup<DbSet<Employee>>(x => x.Employees)
                .ReturnsDbSet(TestDataHelper.GetFakeEmployeeList());

            //Act
            EmployeesController employeesController = new(employeeContextMock.Object);
            var employees = (await employeesController.GetEmployees()).Value;

            //Assert
            Assert.NotNull(employees);
            Assert.Equal(2, employees.Count());
        }
    }
}
