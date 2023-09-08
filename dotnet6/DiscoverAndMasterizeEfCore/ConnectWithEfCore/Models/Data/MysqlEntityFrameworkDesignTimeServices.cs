﻿using Microsoft.EntityFrameworkCore.Design;
using MySql.EntityFrameworkCore.Extensions;

namespace ConnectWithEfCore.Models.Data
{
    public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddEntityFrameworkMySQL();
            new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
                .TryAddCoreServices();
        }
    }

}