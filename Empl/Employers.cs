using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empl
{
    internal class Employers
    {
        private string name;
        private double salary;
        private string position;
        private string filed;
        private string? email ="n/a";
        private int age = -1;

        public string Name
        { 
            get 
            { return name; 
            } 
            set 
            { 
                name = value;
            } 
        }
        public double Salary
        { 
            get 
            { 
                return salary; 
            } 
            set
            {
                salary = value;
            } 
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        public string Filed
        {
            get
            {
                return filed;
            }
            set
            {
                filed = value; 
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Employers(string name,double salary,string filed,string? email, string? email1, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Filed = filed;
            if(email!=null)this.Email = email;
            if (age != 0) this.Age = age;
        }
        public Employers()
        {

        }

        public void PrintMe()
        {
            Console.WriteLine($"Name: {name}, Salary: {salary}, Email: {email}, Age: {age}");
        }
    }
}
