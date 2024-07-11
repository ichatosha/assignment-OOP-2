//using assignment_OOP_2;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//namespace assignment_OOP_2
//{

//    #region Part 1 
    

//    public struct Person
//    {
//        public string Fname { get; set; }
//        public string Lname { get; set; }

//        public Person(string firstname, string lastname)
//        {
//            firstname = Fname;
//            lastname = Lname;

//        }
//        public override string ToString()
//        {
//            return $"{Fname} {Lname}";
//        }
//    }


//    public class Employee
//    {
//        private int id; // private field 

//        private Person person;

//        public Employee (int id, string firstName , string lastName)
//        {
//            this.id = id;
//            person = new Person (firstName, lastName);
//        }

//        public int Id
//        {
//            get { return id; }
//            protected set { id = value; } // protected setter
//        }

//        private Person Person
//        {
//            get { return person; }
//             set { person = value; }         
//        }

//        public override string ToString()
//        {
//            return $"ID : {id} , Name : {Person}"; 
//        }
//    }
    
//}

//    // inheritance 

//public class Manager : Employee
//{
//    public string? Department { get; set; }     // maybe null here ! 

//    public Manager(int id, string firstName , string lastName , string? department ): base (id , firstName ,lastName)
//    {
//        department = Department; 
//    }

//    public override string ToString()
//    {
//        return base.ToString() + $", department : {Department}";
//    }

//    #endregion



//}