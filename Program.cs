// Global Variables
int globalTextDelay = 50;
string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

// Init Screen
Console.Write("\n \n \n \n \n \n \n \n \n \n \t \t \t \t \t \t ");
string titleText = "Blackjack";
    foreach(char c in titleText){
        Console.Write(c);
            await Task.Delay(globalTextDelay);
    } Console.ReadLine(); Console.Clear();

Random rnd = new Random();
    for(int i = 0; i < 13; i++){rnd.Next(1, 13); Console.WriteLine(cards[i]);} await Task.Delay(100); Console.Clear(); Console.ReadLine(); 

