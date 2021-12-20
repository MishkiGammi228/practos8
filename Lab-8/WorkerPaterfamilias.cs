using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8
{
    class WorkerPaterfamilias : Ipaterfamilias,Iworker,IComparable,ICloneable
    {
        public string _name;
        public string _surname;
        public string _patronymic;
        public string _position;
        public int _children;
        public int _age;

        public WorkerPaterfamilias(string initName, string initSurname, string initPatronymic,
            int initChildren, string initPosition, int initAge )
        {
            _name = initName;
            _surname = initSurname;
            _patronymic = initPatronymic;
            _children = initChildren;
            _position = initPosition;
            _age = initAge;
        }

        public WorkerPaterfamilias()
        {
            _name = "gvj";
            _surname = "blj";
            _patronymic = "hvljh";
            _position = "jblj";
            _children = 23;
            _age = 12;
        }

        public string Name { get; set; }

        public string Surname {get;set;}

        public string Patronymic { get;set;}

        public int Children { get;set;}

        public string Position { get;set;}

        public int Age { get; set; }

        public string EmployeeInformation()
        {
            string info = $"Фамилия {_surname} \n Имя {_name} \n Отчество {_patronymic}" +
                $" \n Количество детей {_children} \n Должность {_position} \n Возрост {_age}";
            return info;
        }

        public WorkerPaterfamilias WorkerClone()
        {
            return (WorkerPaterfamilias)this.MemberwiseClone();
        }

        public object Clone()
        {
            WorkerPaterfamilias worker = new WorkerPaterfamilias();
            worker._name = this._name;
            worker._surname = this._surname;
            worker._patronymic = this._patronymic;
            worker._children = this._children;
            worker._position = this._position;
            worker._age = this._age;
            return worker;
        }

        public int CompareTo(object obj)
        {
            WorkerPaterfamilias surname = (WorkerPaterfamilias)obj;
            if (this._surname.Length > surname._surname.Length) return 1;
            if (this._surname.Length < surname._surname.Length) return -1;
            return 0;
        }
    }
}
