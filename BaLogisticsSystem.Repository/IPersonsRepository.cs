﻿using System;
using BaLogisticsSystem.Models;
using BaLogisticsSystem.Repository.Common;

namespace BaLogisticsSystem.Repository
{
    public interface IPersonsRepository : IGenericRepository<PersonEntity>
    {
        PersonEntity GetSingle(Guid userId);
        PersonEntity GetSingle(string email);
    }
}
