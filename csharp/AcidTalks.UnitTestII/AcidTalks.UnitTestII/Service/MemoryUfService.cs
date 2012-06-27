using System;
using System.Collections.Generic;

namespace AcidTalks.UnitTestII.Service
{
    public class MemoryUfService
    {
        private readonly IDictionary<DateTime, decimal> _ufs;
        public MemoryUfService(IDictionary<DateTime, decimal> ufs)
        {
            _ufs = ufs;
        }
        
        public decimal GetUfValue(DateTime date)
        {
            return _ufs[date];
        }
    }
}