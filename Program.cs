// Global Variables
int globalTextDelay = 50;
string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

// Init Screen
string titleText = "Blackjack";
    foreach(char c in titleText){
        Console.Write(c);
            await Task.Delay(globalTextDelay);
    } Console.ReadLine();

