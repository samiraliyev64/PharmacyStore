using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyStore.Models.Utilies
{
    class NotFoundException:Exception
    {
        public NotFoundException(string msg):base(msg)
        {

        }
    }
}
