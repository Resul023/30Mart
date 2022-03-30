using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private double _salary;

        public string NameTool
        {
            get
            {
                return _name;
            }
            set
            {
                int count = 0;
                int countTwo = 0;

                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]) && char.IsUpper(value[0]) && count < 1)
                    {
                        count++;
                    }
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) && countTwo < 1)
                    {
                        countTwo++;
                    }

                }
                if (count + countTwo < 2)
                {
                    this._name = value;
                }


            }
        }
        public string SurNameTool
        {
            get
            {
                return _surname;
            }
            set
            {
                int count = 0;
                int countTwo = 0;

                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLetter(value[i]) && char.IsUpper(value[0]) && count < 1)
                    {
                        count++;
                    }
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) && countTwo < 1)
                    {
                        countTwo++;
                    }

                }
                if (count + countTwo < 2)
                {
                    this._surname = value;
                }


            }
        }
        public double SalaryTool
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 250)
                {
                    this._salary = value;
                }
                else
                {
                    Console.WriteLine("This salary is less from limit");
                }
            }
        }

    }
}
