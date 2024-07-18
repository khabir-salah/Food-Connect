﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class Auditables
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
