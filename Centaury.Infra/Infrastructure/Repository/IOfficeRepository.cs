﻿using Centaury.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaury.Infra.Infrastructure.Repository
{
    public interface IOfficeRepository
    {
        Task<IList<Office>> GetOfficesAsync();
    }
}
