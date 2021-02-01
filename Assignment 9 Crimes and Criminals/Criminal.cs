using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Criminal
    {
        private string Name;
        private int Age;
        private Crime[] CrimesCommitted;

        public Criminal(string name, int age)
        {
            Name = name;
            Age = age;
            CrimesCommitted = new Crime[10]; // creates 10 empty slots

        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public bool AddCrime(Crime CrimeToAdd)
        {
            int CrimesCount = CountCrimes();
            if (CrimesCount < CrimesCommitted.Length)
            {

                CrimesCommitted[CrimesCount] = CrimeToAdd;
                return true;
                
            }
            return false;
        }

        public int CountCrimes()
        {
            int NumberOfCrimes = 0;
            for (int i = 0; i < CrimesCommitted.Length; i++)
            {
                if (CrimesCommitted[i] != null) return i;
            }
            return CrimesCommitted.Length;
        }

        public Crime GetCrime(int i)
        {
            if (CountCrimes() < i)
            {
                return CrimesCommitted[i];
            }
            else
            {
                return null;
            }
        }
    }
}
