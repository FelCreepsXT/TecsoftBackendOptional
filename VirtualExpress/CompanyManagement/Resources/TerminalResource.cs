﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualExpress.CompanyManagement.Domain.Models;

namespace VirtualExpress.CompanyManagement.Resources
{
    public class TerminalResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public int CityId { get; set; }
    }
}
