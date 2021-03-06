﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saafi.Core.Model;

namespace Saafi.Core.Contracts.Repository
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetAllServices();

        Task<Service> GetServiceById(int serviceId);
    }
}

