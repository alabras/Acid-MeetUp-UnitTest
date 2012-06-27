using System;
using AcidTalks.UnitTestII.Service;

namespace AcidTalks.UnitTestII
{
    public class Convert
    {
        public decimal PesoToUf(decimal pesos)
        {
            var ufService = new SbifUfService();
            var ufValue = ufService.GetUfValue(DateTime.Now);

            return pesos / ufValue;
        }

        public decimal UfToPeso(decimal uf)
        {
            var ufService = new SbifUfService();
            var ufValue = ufService.GetUfValue(DateTime.Now);

            return uf*ufValue;
        } 
    }
}