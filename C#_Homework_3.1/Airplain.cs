using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_3._1
{
    class Airplane(string Name, string Manufacturer, int Year, string Type)
    {
        public Airplane() : this("Boeing 747", "Boeing", 1969, "passenger")
        {

        }
  
        public void SetName(string nm)
        {
            Name = nm;
        }

        public void SetManufacturer(string mnfct)
        {
            Manufacturer = mnfct;
        }

        public void SetYear(int date)
        {
            Year = date;
        }

        public void SetType(string tp)
        {
            Type = tp;
        }

        public string GetName => Name;
        public string GetManufacturer => Manufacturer;
        public int GetYear => Year;
        public string GetType => Type;



        public void PrintState()	
        {
            Console.WriteLine("Самолёт: {0}", Name);
            Console.WriteLine("Производитель: {0}", Manufacturer);
            Console.WriteLine("Год выпуска: {0}", Year);
            Console.WriteLine("Тип: {0}", Type);
        }
    }
}
