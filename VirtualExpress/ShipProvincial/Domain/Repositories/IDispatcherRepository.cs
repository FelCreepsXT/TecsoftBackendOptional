﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualExpress.ShipProvincial.Domain.Models;

namespace VirtualExpress.ShipProvincial.Domain.Repositories
{
    public interface IDispatcherRepository
    {
        Task<IEnumerable<Dispatcher>> ListAsync();
        Task AddAsync(Dispatcher Dispatcher);
        Task<Dispatcher> FindById(int id);
        void Update(Dispatcher Dispatcher);
        void Remove(Dispatcher Dispatcher);
    }
}
