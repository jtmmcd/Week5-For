using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            Console.WriteLine("Sisetage kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage salasõna:");
            string userPassword = Console.ReadLine();

            // AND 
            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
        }
    }
}
