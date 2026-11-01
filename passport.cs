using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposMorkav
{
    internal class passport
    {
        public string name;
        public string surname;
        public string nationality;
        public string dateOfBirth;
        public string placeOfBirth;
        public string passportNumber;
        public string expirationDate;
        public string placeOfLive;
        public string maritalStatus;
        string[] childIds = new string[3];

        public passport(string name, string surname, string nationality, string dateOfBirth, string placeOfBirth, string passportNumber, string expirationDate, string placeOfLive, string[] childIds, string maritalStatus)
        {
            this.name = name;
            this.surname = surname;
            this.nationality = nationality;
            this.dateOfBirth = dateOfBirth;
            this.placeOfBirth = placeOfBirth;
            this.passportNumber = passportNumber;
            this.expirationDate = expirationDate;
            this.placeOfLive = placeOfLive;
            this.childIds = childIds;
            this.maritalStatus = maritalStatus;
        }
        
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetSurname()
        {
            return this.surname;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string GetNationality()
        {
            return this.nationality;
        }
        public void SetNationality(string nationality)
        {
            this.nationality = nationality;
        }
        public string GetDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public void SetDateOfBirth(string dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public string GetPlaceOfBirth()
        {
            return this.placeOfBirth;
        }
        public void SetPlaceOfBirth(string placeOfBirth)
        {
            this.placeOfBirth = placeOfBirth;
        }
        public string GetPassportNumber()
        {
            return this.passportNumber;
        }
        public void SetPassportNumber(string passportNumber)
        {
            this.passportNumber = passportNumber;
        }
        public string GetExpirationDate()
        {
            return this.expirationDate;
        }
        public void SetExpirationDate(string expirationDate)
        {
            this.expirationDate = expirationDate;
        }
        public string GetPlaceOfLive()
        {
            return this.placeOfLive;
        }
        public void SetPlaceOfLive(string placeOfLive)
        {
            this.placeOfLive = placeOfLive;
        }
        public string GetMaritalStatus()
        {
            return this.maritalStatus;
        }
        public void SetMaritalStatus(string maritalStatus)
        {
            this.maritalStatus = maritalStatus;
        }
        public string[] GetChildIds()
        {
            return this.childIds;
        }
        public void SetChildIds(string[] childIds)
        {
            this.childIds = childIds;
        }

        public void AddChildId(string childId)
        {
            for (int i = 0; i < this.childIds.Length; i++)
            {
                if (this.childIds[i] == null)
                {
                    this.childIds[i] = childId;
                    break;
                }
            }
        }
        public void RemoveChildId(string childId, int age)
        {
            if (age > 15)
            {
                for (int i = 0; i < this.childIds.Length; i++)
                {
                    if (this.childIds[i] == childId)
                    {
                        this.childIds[i] = null;
                        break;
                    }
                }
            }
        }
    }
}
