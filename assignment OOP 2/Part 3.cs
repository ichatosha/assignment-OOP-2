using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_OOP_2
{
    public class Employee
    {
        private int id;
        private string name;
        private decimal salary;
        private int securityLevel;
        private DateTime hireDate;
        private string gender;


        // Constructor : 

        public Employee(int id, string name, string gender, decimal salary, DateTime hireDate, int securityLevel)
        {
            this.id = id;
            this.name = name;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }

        //  Properties : 

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }


        public override string ToString()
        {
            return $"ID : {id} , Name : {name} , Security Level : {securityLevel} , Salary : {salary} , Gender : {gender} , hire date : {hireDate}";
        }



        public class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }


            public HireDate(int day, int month, int year)
            {
                if (day < 1 || day > 31)
                    throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31");
                if (month < 1 || month > 12)
                    throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");
                if (year < 1900 || year > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1900 and current year");

                this.Day = day;
                this.Month = month;
                this.Year = year;

            }
            public override string ToString()
            {
                return $"{Day}/{Month}/{Year}";
            }

        }
        public enum Gender
        {
            Male,
            Female
        }


        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }

        public class Employeee : IComparable<Employeee>
        {
            // Private fields
            private int id;
            private string name;
            private SecurityLevel securityLevel;
            private decimal salary;
            private HireDate hireDate;
            private Gender gender;

            // Constructor
            public Employeee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, Gender gender)
            {
                this.id = id;
                this.name = name;
                this.securityLevel = securityLevel;
                this.salary = salary;
                this.hireDate = hireDate;
                this.gender = gender;
            }

            // Properties
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public SecurityLevel SecurityLevel
            {
                get { return securityLevel; }
                set { securityLevel = value; }
            }

            public decimal Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public HireDate HireDate
            {
                get { return hireDate; }
                set { hireDate = value; }
            }

            public Gender Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            // Override ToString() method to display employee details
            public override string ToString()
            {
                return string.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                                     id, name, securityLevel, salary, hireDate, gender);
            }

            // Implement IComparable<Employee> for sorting
            public int CompareTo(Employeee other)
            {
                return new DateTime(this.hireDate.Year, this.hireDate.Month, this.hireDate.Day)
                    .CompareTo(new DateTime(other.hireDate.Year, other.hireDate.Month, other.hireDate.Day));
            }





        }
    }
}
