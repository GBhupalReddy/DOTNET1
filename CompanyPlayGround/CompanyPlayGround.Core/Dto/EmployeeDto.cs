﻿using CompanyPlayGround.Core.Entities;

namespace CompanyPlayGround.Core.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
