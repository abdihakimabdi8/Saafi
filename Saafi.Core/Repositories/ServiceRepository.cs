﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Saafi.Core.Contracts.Repository;
using Saafi.Core.Model;

namespace Saafi.Core.Repositories
{
    public class ServiceRepository : BaseRepository, IServiceRepository
    {
        private static readonly List<Service> AllServices = new List<Service>
        {

            new Service
            {
                ServiceId = 0,
                ServiceName = "Select Service Type"
            },
            new Service
            {
                ServiceId = 1,
                ServiceName = "SaafiMoney"
            },
            new Service
            {
                ServiceId = 2,
                ServiceName = "Dahabshiil"
            },
            new Service
            {

                ServiceId = 3,
                ServiceName = "Kaah"
            },
           

        };

        public async Task<List<Service>> GetAllServices()
        {
            return await Task.FromResult(AllServices);
        }

        public async Task<Service> GetServiceById(int serviceId)
        {
            return await Task.FromResult(AllServices.FirstOrDefault(c => c.ServiceId == serviceId));
        }
    }
}
