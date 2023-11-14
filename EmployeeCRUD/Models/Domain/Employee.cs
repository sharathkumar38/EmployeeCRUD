﻿namespace EmployeeCRUD.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public long Salary{ get; set; }

        public DateTime DOB { get; set;}

        public string Department { get; set; }
    }
}
