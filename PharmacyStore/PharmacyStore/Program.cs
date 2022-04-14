using PharmacyStore.Models;
using System;

namespace PharmacyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicine1 = new Medicine("derman1",20,5,false);
            Medicine medicine2 = new Medicine("derman2", 40, 8, false);
            Medicine medicine3 = new Medicine("derman3", 60, 80, false);
            Medicine medicine4 = new Medicine("derman4", 70, 12, false);
            Medicine medicine5 = new Medicine("derman5", 100, 12, false);

            Pharmacy pharmacy1 = new Pharmacy(8);
            pharmacy1.AddMedicine(medicine1);
            pharmacy1.AddMedicine(medicine2);
            pharmacy1.AddMedicine(medicine3);
            pharmacy1.AddMedicine(medicine4);

            //pharmacy1.GetAllMedicines();
            //pharmacy1.GetMedicineById(1);

            //pharmacy1.FilterMedicinesByPrice(30,60);
            //pharmacy1.DeleteMedicineById(2);
            //Console.WriteLine(Pharmacy.medicineList[1].IsDeleted);

            //pharmacy1.EditMedicineEmail(2, "men");
            //pharmacy1.GetAllMedicines();

           
        }
    }
}


