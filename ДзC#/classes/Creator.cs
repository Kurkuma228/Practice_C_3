using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДзC_.classes
{
    internal class Creator
    {
        private static Hashtable buildings = new();

        private Creator() { }
        static Guid CreateBuliding()
        {
            Guid number = Guid.NewGuid();
            Building building = new Building(number);
            buildings.Add(building.GetNumber(), building);
            return number;  
        }

        static Guid CreateBuliding(double height)
        {
            Guid number = Guid.NewGuid();
            Building building = new Building(number, height);
            buildings.Add(building.GetNumber(), building);
            return number;
        }
        static public void Remover(Guid num)
        {
            if (!buildings.ContainsKey(num))
            {
                Console.WriteLine("Такого здания нет");
            }
            buildings.Remove(num);
        }
    }
}
