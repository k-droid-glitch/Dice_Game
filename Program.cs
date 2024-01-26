using System.Runtime.InteropServices;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen für die Würfel
            int playerRandomNUm;
            int enemyRandomNum;

            // Variablen für die gewonnenen Runden
            int playerPoints = 0;
            int enemyPoints = 0;

            // Erstellen die Variable für Random
            Random random = new Random();

            // Nun kommen die Würfeln
            for (int i = 0; i < 10; i++)
            {

                // Fordern den Spieler auf einen Knopf zu drücken
                Console.WriteLine("Press any key to roll the dice");
                Console.Read(); //damit das Programm wartet bis etwas gedrückt wurde

                // Vergeben die Zhalen für uns
                playerRandomNUm = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNUm);

                // Bauen eine Verzögerung ein für die generierung des Würfels vom Gegner, damit diese nicht direkt zeitnah aufploppt
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); //Das System schläft bzw setzt für 1000ms aus

                // Vergeben die Zahlen für den Gegner
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                // Checken für jede Schleife wer höher gewürfelt hat und erhöhren je nach dem den playerPoints Counter oder den enemyPoints Counter um 1
                if (playerRandomNUm > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else if (playerRandomNUm < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The Score is now - Player {0} to Enemy {1}.", playerPoints, enemyPoints);
            }
            // Werten das Endergebnis aus und geben es wieder
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You won with {0} Points", playerPoints);
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("Enemy has won with {0} Points", enemyPoints);
            }
            else{
                Console.WriteLine("Its a draw!");
            }
            Console.Read();
        }
    }
}
