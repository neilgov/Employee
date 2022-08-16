using Employees.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Service
{
   public interface IEmployeeService
    {
        Task CreateAsync(associate newEmployee);
        associate GetById(int employeeId);

        Task UpdateAsync(associate employee);

        Task UpdateAsync(int id);

        Task Delete(int employeeid);

        IEnumerable<associate> Getall();
        object GetAll();
    }
}
