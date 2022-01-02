using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti(cpu) ja kasutaja(user);
            //mõlmad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, võidab mängu;
            //*täringuid visatakse 3 korda;
            //programm kuulutab võitja;
            
            
            int cpuScore = 0;
            int userScore = 0;
            
            
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                int cpuRandom = rnd.Next(1, 7); //arvuti vise
                int userRandom = rnd.Next(1, 7); // kasutaja vise

                

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");




                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            
            if (cpuScore < userScore)
            {
                Console.WriteLine("Kokkuvõttes võitis mängu kasutaja.");
            }
            else if (cpuScore > userScore)
            {
                Console.WriteLine("Kokkuvõttes võitis mängu arvuti.");
            }
            else
            {
                Console.WriteLine("Kokkuvõttes jäi mäng viiki.");
            }
           
        }
    }
}
