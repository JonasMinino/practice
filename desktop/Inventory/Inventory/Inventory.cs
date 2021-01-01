using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory
{
    public static class Inventory
    {   //
        //Bool Has Run//
        //
        public static bool hasRun;
        //
        //Create Part Binding List//
        //
        public static BindingList<Part> parts = new BindingList<Part>();
        //
        //Create a Product Binding List//
        //
        public static BindingList<Product> products = new BindingList<Product>();
        //
        //
        //Create Associated Part Binding List//
        //
        public static BindingList<Part> asPart = new BindingList<Part>();
        //
        //Add a part to list//
        //        
        public static void AddPart(Part part)
        {
            parts.Add(part);            
        }
        //
        // Modify InHouse Part//
        //
        public static void ModifyInHousePart(int partID, InHouse inPart)
        {
            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i].GetType() == typeof(InHouse))
                {
                    InHouse newPart = (InHouse)parts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = inPart.Name;
                        newPart.Inventory = inPart.Inventory;
                        newPart.Price = inPart.Price;
                        newPart.Max = inPart.Max;
                        newPart.Min = inPart.Min;
                        newPart.MachineID = inPart.MachineID;
                    }
                }
            }
        }
        //
        //Modify Outsourced Part//
        //
        public static void ModifyOutsourcedPart(int partID, Outsourced outPart)
        {
            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i].GetType() == typeof(Outsourced))
                {
                    Outsourced newPart = (Outsourced)parts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = outPart.Name;
                        newPart.Inventory = outPart.Inventory;
                        newPart.Price = outPart.Price;
                        newPart.Max = outPart.Max;
                        newPart.Min = outPart.Min;
                        newPart.CompanyName = outPart.CompanyName;
                    }
                }
            }
        }
        //
        //Search Part//
        //
        public static Part SearchPart (int id)
        {
            foreach(Part p in parts)
            {
                if (p.PartID == id)
                {
                    return p;
                }
            }

            return null;
        }
        
       //Add Product//
       //
       public static void ProductAdd(Product product)
        {
            products.Add(product);
        }
        //
        //Product Add Associated Part//
        //
        public static void AsPartAdd(Part part)
        {
            asPart.Add(part);
        }
        //
        //Populate Associated Parts//
        //
        public static void populateAssociated()
        {
            Part part1 = Inventory.parts[0];
            Part part2 = Inventory.parts[1];
            Part part3 = Inventory.parts[2];
            Part part4 = Inventory.parts[3];
            Part part5 = Inventory.parts[4];
            Part part6 = Inventory.parts[5];
            Part part7 = Inventory.parts[6];

            if (!hasRun)
            {
                foreach (Product pro in Inventory.products)
                {
                    MainScreen ms = new MainScreen();
                    int id = pro.ProductID;

                    switch (id)
                    {
                        case 1:
                            Inventory.asPart.Add(part1);
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part5);

                            break;

                        case 2:
                            Inventory.asPart.Add(part1);
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part4);
                            Inventory.asPart.Add(part5);
                            break;

                        case 3:
                            Inventory.asPart.Add(part1);
                            Inventory.asPart.Add(part2);
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part7);
                            break;

                        case 4:
                            Inventory.asPart.Add(part1);
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part5);
                            Inventory.asPart.Add(part6);
                            break;

                        case 5:
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part5);
                            Inventory.asPart.Add(part6);
                            break;

                        case 6:
                            Inventory.asPart.Add(part1);
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part4);
                            Inventory.asPart.Add(part5);
                            break;

                        case 7:
                            Inventory.asPart.Add(part1);
                            Inventory.asPart.Add(part2);
                            Inventory.asPart.Add(part3);
                            Inventory.asPart.Add(part4);
                            Inventory.asPart.Add(part5);
                            Inventory.asPart.Add(part6);
                            Inventory.asPart.Add(part7);
                            break;

                    }

                    break;
                }

                hasRun = true;
            }

        }



    }
}
