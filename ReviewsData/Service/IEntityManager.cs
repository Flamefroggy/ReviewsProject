﻿using ReviewsData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsData.Service
{
    public interface IEntityManager
    {
        List<BaseEntity> Get();
    }
}
