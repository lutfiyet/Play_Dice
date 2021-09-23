using System;

namespace Play_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App for Dice Rolling");
            MainScreen:
            Console.WriteLine("Don't Roll the Dice > Roll the Dice > ");
            Console.WriteLine(" Don't Stop the App > Stop ");
            string option = Console.ReadLine();
            if (option=="Roll the Dice") 
            {
                RolltheDice:
                Console.WriteLine("To Roll the Dice with Single > OneDice");
                Console.WriteLine("To Roll the Dice with Double > DoubleDices");
                Console.WriteLine("To Turn Main Screen >MainScreen");
                string option2 = Console.ReadLine();
               
                if (option2 == "OneDice")
                {
                    Console.Write("Please Tell a number the number of your Dice ");
                    OneDice();
                    goto RolltheDice;
                }
                else if (option2 == "DoubleDices")
                {
                    Console.Write("Please Tell the number the sum of your Dices,until 12 ");
                    DoubleDices();
                    goto RolltheDice;
                }
                else if (option2 == "MainScreen")
                {
                    goto MainScreen;
                }
                else
                {
                    Console.WriteLine("Please choose an option!");
                    goto MainScreen;
                }
            }
            else if (option == "Stop")
            {
                goto bitis;
            }
            else 
            {
                Console.WriteLine("Please choose an option!");
                goto MainScreen;
            }
        bitis:
            Console.WriteLine("The End if App");
        }
        public static void OneDice()
        {
            Random NmbrOneDice = new Random();
            int Single = NmbrOneDice.Next(1, 6);
            int DiceUser = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("incoming number is: {0}", Single);
            if (Single == DiceUser)
            {
                Console.WriteLine("Congrats! You win");
            }
            else
            {
                Console.WriteLine("try More!");
            }
               
        }
        public static void DoubleDices()
        {
            Random NmbrDoubleDice = new Random();
            int Double1 = NmbrDoubleDice.Next(1, 6);
            int Double2 = NmbrDoubleDice.Next(1, 6);
            int DiceUser2 = Convert.ToInt32(Console.ReadLine());
            int sum = Double1 + Double2;
            Console.WriteLine("incoming numbers are : {0} - {1}", Double1, Double2);
            if (sum == DiceUser2)
            {
                Console.WriteLine("Congrats! You win");
            }
            else
            {
                Console.WriteLine("try More!");
            }
           
        }

    }
}
