using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_3._1
{
    class Employee(string Name, int Birth, double Number, string Email, string Work, string Descript)
    {
        public Employee() : this("Влад Чижов", 1990, 0987654321, "VladChizhov@gmail.com", "охранник", "охрана территории, мониторинг камер видеонаблюдления")
        {

        }
        /*
        public Employee(string Name, int Birth, double Number, string Email, string Work, string Descript) // Главный конструктор
        {
   
        }
        */
        public void SetName(string set_name)
        { 
            Name = set_name;
        }

        public void SetDate(int date)
        {
            Birth = date;
        }

        public void SetNumber(double phone)
        {
            Number = phone;
        }

        public void SetEmail(string mail)
        {
            Email = mail;
        }

        public void SetWork(string w)
        {
            Work = w;
        }

        public void SetDescript(string d)
        {
            Descript = d;
        }

        public string GetName => Name;
        public int GetBirth => Birth;
        public double GetNumber => Number;
        public string GetEmail => Email;
        public string GetWork => Work;
        public string GetDescript => Descript;



        public void PrintState()		// Распечатка текущих данных
        {
            Console.WriteLine("Имя сотрудника: {0}", Name);
            Console.WriteLine("Дата рождения: {0}", Birth);
            Console.WriteLine("Номер телефона: {0}", Number);
            Console.WriteLine("Электронная почта: {0}", Email);
            Console.WriteLine("Должность: {0}", Work);
            Console.WriteLine("Описание должностных обязанностей: {0}", Descript);
        }
    }
}
