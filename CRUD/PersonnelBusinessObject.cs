using CRUD.Model;
using System;
using System.Collections.Generic;

namespace CRUD
{
     class PersonnelBusinessObject
    {
        List<Employee> Employees { get; set; }

        public PersonnelBusinessObject()
        {
            Employees = DatabaseLayer.GetEmployeeFromDatabase();
        }

        public List<Employee> GetEmployees()
        {
            return Employees = DatabaseLayer.GetEmployeeFromDatabase();
        }
    }
}