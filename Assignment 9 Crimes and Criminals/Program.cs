using System;

namespace Assignment_9_Crimes_and_Criminals
{
    class Program
    {
        static void Main(string[] args)
        {
            Criminal[] criminals = new Criminal[3];
            criminals[0] = new Criminal("Joel", 31);
            criminals[1] = new Criminal("Jesus", 51);
            criminals[2] = new Criminal("John", 26);

            criminals[0].AddCrime(new Crime(DateTime.Parse("1/2/2021"), "Ascot", "Armed Robbery"));

            //=========================================================================

            //hw = add crimes to all 3 criminals
            //     write a for loop below that loops through all 3 criminals and 
            //     loops thorugh each crime for each criminal and prints all of the info.

            //extention: if they have max crimes (10), print msg "due for execution"

            criminals[1].AddCrime(new Crime(DateTime.Parse("19/1/2021"), "7-11", "Damaging goods"));
            criminals[2].AddCrime(new Crime(DateTime.Parse("23/1/2021"), "book store", "Arson"));



            for (int i = 0; i < criminals.Length; i++)
            {
                string criminalName = criminals[i].GetName();
                int criminalAge = criminals[i].GetAge();
                Console.WriteLine("criminal no. "+i+ " "+criminalName+" age:"+criminalAge);


                string crimeAddress = criminals[i].GetLocation();
                DateTime crimeDate = criminals[i].GetDate();
                string crimeCommitted = criminals[i].GetAct();

                Console.WriteLine("Commited "+crimeCommitted+" at "+crimeAddress+ " on the "+crimeDate);
            }
        }
    }
}
