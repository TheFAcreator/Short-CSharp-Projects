class checkerApp
{
    static void Checker(ref int idCardsLeft)
    {
        Console.WriteLine("Enter resident name (and press Enter):");
        string name = Console.ReadLine();
        Console.WriteLine("Enter code:");
        int code = int.Parse(Console.ReadLine());
        switch(name)
        {
            case "David Green":
                if (code == 349810)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 8 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
            break;
            case "Miko Mias":
                if (code == 812097)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 4 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Gary Bobbins":
                if (code == 381320)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 1 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Kate Flaberry":
                if (code == 087654)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 3 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Miro Johnson":
                if (code == 987002)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 5 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Violet Blue":
                if (code == 448903)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 2 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Jessie Adventuress":
                if (code == 873612)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 6 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Simon Simpson":
                if (code == 198420)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 7 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Juliet Minks":
                if (code == 300123)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 9 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Jack Russle":
                if (code == 489320)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 10 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
                // day 2
            case "Jane Cowgirl":
                if (code == 721304)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 1 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Lady Kaka":
                if (code == 176032)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 2 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Karina Marina":
                if (code == 489103)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 3 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Felix Simpson":
                if (code == 448910)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 10 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Mikos Gazis":
                if (code == 112734)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 7 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Kate Bingo":
                if (code == 789011)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 6 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            case "Mira Gines":
                if (code == 333331)
                {
                    Console.WriteLine("Valid ID card\nPlease give entry card number 8 to the resident.");
                    idCardsLeft--;
                    Console.WriteLine("Entry cards left: " + idCardsLeft);
                }
                break;
            default:
                Console.WriteLine("Invalid resident name or code.");
                Console.WriteLine("Entry cards left: " + idCardsLeft);
                Checker(ref idCardsLeft);
                break;
        }
    }
    static void Main(string[] args)
    {
        int idCardsLeft = 10;
        Console.WriteLine("WELCOME!");
        Console.WriteLine("Read the instructions on the list first to begin.\nWhen you're ready open your door, clap twice with your hands and the lights will turn on.\nDon't forget to keep the door always closed!");
        Console.WriteLine("When a resident gives you their ID card, enter its details here and they will be checked!\nIf the details are valid the app will tell you which entry card to give them.");
        Console.WriteLine("You must enter the two names of a resident like this: (example) Michael Gates");
        Console.WriteLine("Let's begin! Good luck!");
        Console.WriteLine("Entry cards left: " + idCardsLeft);
        while(idCardsLeft > 0) Checker(ref idCardsLeft);
        Console.WriteLine("All cards given away for today! You can go home now.");
    }
}