using BookiAPI.DataAccessLayer;
using BookiAPI.RESTfulService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookiAPI.RESTfulService.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly EmployeeRepository _EmployeeRepository;

        public EmployeesController()
        {
            _EmployeeRepository = new EmployeeRepository();
        }

        public IEnumerable<EmployeeResponse> Get()
        {
            return _EmployeeRepository.GetEmployees().Select(employee => new EmployeeResponse
            {
                Id = employee.Id,
                Phone = employee.Phone,
                Name = employee.Name
            });
        }

        /*public IEnumerable<EmployeeResponse> Get(int id)
        {
            return _EmployeeRepository.GetEmployees(id).Select(employee => new EmployeeResponse
            {
                Id = employee.Id,
                Phone = employee.Phone,
                Name = employee.Name
            });
        }*/

        /*public void Put(int id, string employee)
        {
            _EmployeeRepository.RentCar(id, employee);
        }*/
    }
}
