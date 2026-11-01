using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposMorkav
{
    internal class Person
    {
        passport passport;
        public string email;
        public string phone;
        public double salary;
        public double hours;
        public Person(passport passport, string email, string phone, double salary, double hours)
        {
            this.passport = passport;
            this.email = email;
            this.phone = phone;
            this.salary = salary;
            this.hours = hours;
        }
        public passport GetPassport()
        {
            return this.passport;
        }
        public void SetPassport(passport passport)
        {
            this.passport = passport;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetPhone()
        {
            return this.phone;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public double GetSalary()
        {
            return this.salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetHours()
        {
            return this.hours;
        }
        public void SetHours(double hours)
        {
            this.hours = hours;
        }


        public double CalculateSalary()
        {
            return (this.salary * this.hours) * 0.689;
        }

        public override string ToString()
        {
            return $"Name: {passport.getName()} {passport.getSurname()}, Email: {email}, Phone: {phone}, Salary: {salary}, Hours: {hours}, Total Salary: {calculateSalary()}";
        }

    }
    
}
