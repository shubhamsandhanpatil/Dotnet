using System.ComponentModel.DataAnnotations;

namespace BOL
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        private Department department;
        private DateOnly date;

        public Employee()
        {
            
        }

        public Employee(int id, string name, int age, Department department, DateOnly date)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.department = department;
            this.date = date;
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       

        /*
        public int Id
        {
            get { return id; }
            set { id = value; }
        }*/
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        { 
            get { return age; } 
            set {  age = value; } 
        }
        public Department DEPARTMENT
        {
            get { return department; }
            set { department = value; }
        }
        public DateOnly Date
        {
            get { return date; }
            set { date = value; }
        }
        public override string ToString()
        {
            string data = String.Format("Id ={ 1},Name ={ 2},Age ={ 3},Department ={ 4},Date ={ 5}", this.id, this.name, this.age, this.department, this.date);
            return data;
        }

    }
    public enum Department
    {
        HR,MARKETING,SALES,ADMINISTRATION
    }
}