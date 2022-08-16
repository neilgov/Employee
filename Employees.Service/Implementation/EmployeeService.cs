using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Entity;
using Employees.Persistence;

namespace Employees.Service.Implementation
{
   public class EmployeeService : IEmployeeService

    {

        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)

        {
            _context = context;
        }
        public async Task CreateAsync(associate newEmployee)
        {
            await _context.Employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();
        }
        public associate GetById(int employeeId) =>
            _context.Employees.Where(e => e.Id == employeeId).FirstOrDefault();   
        
            
        
        public async Task Delete(int employeeid)
        {
            var employee = GetById(employeeid);
            _context.Remove(employee);
            await _context.SaveChangesAsync();
        }

       

        public async Task UpdateAsync(associate employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var employee = GetById(id);
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<associate> Getall() => _context.Employees;

        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
