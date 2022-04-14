using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyStore.Models.Utilies
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string msg):base(msg)
        {

        }
    }
}
