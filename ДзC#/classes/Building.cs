using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДзC_.classes
{
    internal class Building
    {
        Guid numBuilding;
        double heightBuilding;
        byte floorsAmount;
        byte apartsAmount;
        byte entranceAmount;

        internal Building() { }
        
        internal Building(Guid numBuilding)
        {
            this.numBuilding = numBuilding;
        }
        internal Building(Guid numBuilding, double heightBuilding)
        {
            this.numBuilding = numBuilding;
            this.heightBuilding = heightBuilding;
        }
        
        public Guid GetNumber()
        {
            return numBuilding;
        }
        public byte floorsamount
        {
            get { return floorsAmount; }
            set {  floorsAmount = value; }
        }
        public byte apartsamount
        {
            get { return apartsAmount; }
            set { apartsAmount = value; }
        }
        public byte entranceamount
        {
            get { return entranceAmount; }
            set { entranceAmount = value; }
        }

        public void GenUniqiueNum()
        {
            numBuilding = Guid.NewGuid();
        }
        public double FloorHeight()
        {
            return floorsAmount / heightBuilding;
        }
        public double AmountApartInEntrance()
        {
            return apartsAmount / entranceAmount;
        }
        public double AmountApartInFloor()
        {
            return apartsAmount / floorsAmount;
        }

        public void Print()
        {
            Console.WriteLine($"Номер здания:{numBuilding}\nВысота здания:{heightBuilding}\nКол-во этажей в здании:{floorsAmount}" +
                $"\nКол-во квартир в здании:{apartsAmount}\nКол-во подъездов в здании:{entranceAmount}\n");
            Console.WriteLine($"Высота этажа:{FloorHeight()}\nКол-во квартир в подъезде:{AmountApartInEntrance}\nКол-во квартир на этаж:{AmountApartInFloor}");
        }
    }
}
