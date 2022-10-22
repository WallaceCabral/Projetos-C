using System;
using Course.Entities.Enums;


namespace Course.Entities
{
    class Worker
    {
        public string  Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void RomoveContract (HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income (int year, int month)
        {
            Double sum = BaseSalary;
            foreach(HourContract contract in Contract)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }




}
