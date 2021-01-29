using System;

namespace HW_2._2_26_01_21
{
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public Employee(string name, string lastName, string position, int experience)
        {
            Name = name;
            LastName = lastName;
            Position = position;
            Experience = experience;
        }
        private static string[] ArrPosition = { "\n\t\tФермер", "\n\t\tИнженер", "\n\t\tЮвелир", "\n\t\tРежиссер", "\n\t\tМонтажер", "\n\t\tТестировщик",
                                                "\n\t\tПрограммист", "\n\t\tQA-инженер", "\n\t\tСтюардесса", "\n\t\tКосмонавт"};
        private static int[] Salary = { 3100, 4000, 2400, 1050, 2700, 4100, 6000, 1300, 2800, 2500 };
        private static int[] ArrExperience = { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900 };
        public void GetDataPerson()
        {
            System.Console.WriteLine($"\nИмя: {Name}\nФамилия: {LastName}\nДолжность: {Position}");
        }
        public void ListProf()
        {
            System.Console.Write("Виды профессии: ");
            for (int i = 0; i < ArrPosition.Length; i++)
            {
                if (i == ArrPosition.Length - 1)
                {
                    System.Console.Write(ArrPosition[i] + " ");
                }
                else
                {
                    System.Console.Write(ArrPosition[i] + ", ");
                }
            }
            System.Console.WriteLine();
        }
        public int ExperienceSum()
        {
            int sum = 0;
            for (int i = 0; i < ArrExperience.Length; i++)
            {
                if (ArrPosition[i] == Position)
                {
                    sum = sum + Salary[i];
                }
                if (Experience > ArrExperience.Length - 1 && i < 1)
                {
                    sum = sum + ArrExperience[ArrExperience.Length - 1];
                }
                else if (i == Experience)
                {
                    sum += ArrExperience[i];
                }
            }
            return sum;
        }
        
        public void GetSalary()
        {
            for (int i = 0; i < ArrPosition.Length; i++)
            {
                if (ArrPosition[i] == Position)
                {
                    System.Console.WriteLine($"У {ArrPosition[i]} зарплата = {Salary[i]}");
                }
            }
        }
        public void GetTax()
        {
            double salary = 0;
            for (int i = 0; i < ArrPosition.Length; i++)
            {
                if (ArrPosition[i] == Position)
                {
                    salary += Employee.Salary[i];
                }
                if (Experience > ArrExperience.Length - 1 && i < 1)
                {
                    salary += ArrExperience[ArrExperience.Length - 1];
                }
                else if (i == Experience)
                {
                    salary += ArrExperience[i];
                }
            }
            Console.WriteLine($"Размер зарплаты учитывая 13%({salary * 0.13} сомон) налога и 1%({salary * 0.01} сомон) пенсионного фонда с общей суммы");

            Console.WriteLine($"Выплате: {salary - ((salary * 0.13) + (salary * 0.01))}");
        }
        public Employee() { }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ListProf();
            System.Console.Write("Введите имя: ");
            employee.Name = Console.ReadLine();
            System.Console.Write("Введите фамиля: ");
            employee.LastName = Console.ReadLine();
            System.Console.Write("Введите профессию: ");
            employee.Position = Console.ReadLine();
            System.Console.Write("Введите стаж: ");
            employee.Experience = int.Parse(Console.ReadLine());
            employee.GetDataPerson();
            employee.GetSalary();
            Console.WriteLine($"Зарплата с учетом стажа работы = " + employee.ExperienceSum());
            employee.GetTax();
        }
    }
}
