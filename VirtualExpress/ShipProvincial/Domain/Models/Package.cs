﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualExpress.ShipProvincial.Domain.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public EPriority Priority { get; set; }
        public EState State { get; set; }
        public string Weight { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public int FerightId { get; set; }
        public Freight Freight { get; set; }
        public int DispatcherId { get; set; }
        public Dispatcher Dispatcher { get; set; }
    }
}
