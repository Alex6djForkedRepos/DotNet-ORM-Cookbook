﻿using System;

namespace Recipes.RepoDB.Models
{
    public class EmployeeClassificationWithCount : IEmployeeClassificationWithCount
    {
        public int EmployeeClassificationKey { get; set; }
        public string? EmployeeClassificationName { get; set; }
        public int EmployeeCount { get; set; }
    }
}
