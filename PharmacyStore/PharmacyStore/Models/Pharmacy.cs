using PharmacyStore.Models.Utilies;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyStore.Models
{
    class Pharmacy
    {
        //Fields
        public static int MedicineLimit;
        public static List<Medicine> medicineList;

        //Constructor
        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
            medicineList = new List<Medicine>();
        }

        //Methods

        //AddMedicine method
        public void AddMedicine(Medicine medicineObj)
        {
            if(MedicineLimit < medicineList.Count)
            {
                throw new CapacityLimitException("list is overflowed");
            }
            foreach (var item in medicineList)
            {
                if(item.Name == medicineObj.Name)
                {
                    throw new MedicineAlreadyExistsException("item exists");
                }
            }
           
            medicineList.Add(medicineObj);
        }

        //GetAllMedicines method
        public void GetAllMedicines()
        {
            foreach (var item in medicineList)
            {
                if(item.IsDeleted == false) 
                {
                    Console.WriteLine($"Id : {item.Id}\nName : {item.Name}\nPrice : {item.Price}\nCount : {item.Count}\nIs Deleted : {item.IsDeleted}");
                }
            }
        }

        //FilterMedicinesByPrice method
        public void FilterMedicinesByPrice(int minPrice, int maxPrice)
        {
            foreach (var item in medicineList)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    Console.WriteLine($"Id : {item.Id}\nName : {item.Name}\nPrice : {item.Price}\nCount : {item.Count}\nIs Deleted : {item.IsDeleted}");
                }
            }
        }

        //GetMedicineById method
        public void GetMedicineById(int? id)
        {
            if(id == null)
            {
                throw new NullReferenceException("id is null");
            }
            else
            {
                foreach (var item in medicineList)
                {
                    if(item.Id == id && item.IsDeleted == false)
                    {
                        Console.WriteLine($"Id : {item.Id}\nName : {item.Name}\nPrice : {item.Price}\nCount : {item.Count}\nIs Deleted : {item.IsDeleted}");
                    }
                }
            }
        }

        //DeleteMedicineById method
        public void DeleteMedicineById(int? id)
        {
            bool isExist = false;
            if(id == null)
            {
                throw new NullReferenceException("id is null");
            }

            else
            {
                foreach (var item in medicineList)
                {
                    if(item.Id == id && item.IsDeleted == false)
                    {
                        item.IsDeleted = true;
                        isExist = true;
                    }
                }
                if (isExist == false)
                {
                    throw new NotFoundException("item is not found");
                }
                
            }
        }

        //EditMedicineEmail method
        public void EditMedicineEmail(int? id,string name)
        {
            bool isExist2 = false;
            if(id is null || name is null)
            {
                throw new NullReferenceException("id or name is null");
            }
            else
            {
                foreach (var item in medicineList)
                {
                    if(item.Id == id && item.IsDeleted == false)
                    {
                        item.Name = name;
                        isExist2 = true;
                    }
                }
                if(isExist2 == false)
                {
                    throw new NotFoundException("item is not found");
                }
            }
        }




    }
}
