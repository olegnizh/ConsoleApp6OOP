using System;

namespace ConsoleApp631
{
    class Program
    {
        static void Main(string[] args)
        {

            //Company com = new Company();
            var department = GetCurrentDepartment();
            if ((department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург"))
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
            //Console.WriteLine("Company name {0}", com.Name);
            //Console.WriteLine("У банка {0}", department?.Company?.Name);


            static Department GetCurrentDepartment()
            {
                // logic
                Department department = new Department();
                return department;
            }


        }

    }

    class Company
    {
        public string Type;
        public string Name;

        public Company()
        {
            Type = "Банк";
            Name = "Неизвестная компания";
        }
    }

    class Department
    {
        public Company Company;
        public City City;

        public Department()
        {
            Company = new Company();
            City = new City();
        }
    }

    class City
    {
        public string Name;

        public City()
        {
            Name = "Санкт-Петербург";
        }
    }


}

