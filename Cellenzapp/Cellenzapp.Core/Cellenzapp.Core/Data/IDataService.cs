﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cellenzapp.Core.Model;

namespace Cellenzapp.Core.Data
{
    public interface IDataService
    {
        IEnumerable<CellExpert> CellExperts { get; set; }

        Task<IEnumerable<CellExpert>> TryLoadCellExpertsAsync();
    }
}
