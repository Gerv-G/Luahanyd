﻿using System.Collections.Generic;
using BitDev.DataTransferObjects;
using BitDev.DomainEntities;

namespace BitDev.DomainServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
