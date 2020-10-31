using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTes
{
    class Student
    {
        string department;
        string id;
        string name;
        float cgpa;
        public void setName(String Name)
        {
            name = Name;
        }
        public string getName()
        {
            return name;
        }
        public void setId(String Id)
        {
            id = Id;
        }
        public string getId()
        {
            return Id;
        }
        public void setDepartment(String Department)
        {
            department = Department;
        }
        public int getdepartment()
        {
            return Department;
        }
        public void setCgpa(float Cgpa)
        {
            cgpa = Cgpa;
        }
        public float getCgpa()
        {
            return cgpa;
        }
    
        public void ShowInfo()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }
    }
}
