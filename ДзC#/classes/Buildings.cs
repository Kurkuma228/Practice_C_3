using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ДзC_.classes;

namespace ДзC_.classes
{
    internal class Buildings
    {
        Building[] buildings = new Building[10];
        Building CreateBuilding()
        {
            Building building = new Building();

            building.GenUniqiueNum();

            Console.WriteLine("Введите высоту здания");
            building.heightbuilding = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество этажей в здании");
            building.floorsamount = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество квартир в здании");
            building.apartsamount = byte.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов в здании");
            building.entranceamount = byte.Parse(Console.ReadLine());

            return building;
        }
        public void SetBuildings()
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i] = CreateBuilding();
            }
        }
        public Building this[int index]
        {
            get 
            {
                if (index <= buildings.Length - 1 && index >= 0)
                    return buildings[index];
                else
                    return null;
            }
        }
    }
}
