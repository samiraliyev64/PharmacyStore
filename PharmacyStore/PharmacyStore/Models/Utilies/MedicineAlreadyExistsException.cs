using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyStore.Models.Utilies
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string msg):base(msg)
        {

        }
    }
}
