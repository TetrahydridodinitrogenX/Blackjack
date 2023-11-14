// Global Variables
int globalTextDelay = 50;
int textSpacing = 2;
// int chips = 0;
string[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
cards[10] = "10";
cards[11] = "10";
cards[12] = "10";

Start:
// Init Screen
Console.Write("\n \n \n \n \n \n \n \n \n \n \t \t \t \t \t \t ");
string titleText = "Blackjack";
    foreach(char c in titleText){
        Console.Write(c);
            await Task.Delay(globalTextDelay);
    } Console.ReadLine(); Console.Clear();

Random rnd = new Random();
    for(int i = 0; i < 13; i++){int randomVal = rnd.Next(1, 13); Console.WriteLine(cards[randomVal]);} await Task.Delay(100); Console.Clear(); Console.ReadLine(); 

// chips = chips + 100;
// Console.Write($"You Have" + chips);
// Console.Write(" Chips");

Random rand = new Random();
    int playerCardOneRand = rand.Next(1, 13);
    int playerCardOne = int.Parse(cards[playerCardOneRand]);
    int dealerCardOneRand = rand.Next(1, 13);
    int dealerCardTwoRand = rand.Next(1, 13);
    int dealerCardOne = int.Parse(cards[dealerCardOneRand]);
    int dealerCardTwo = int.Parse(cards[dealerCardTwoRand]);
        if(dealerCardOne + dealerCardTwo == 21){
            for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
                Console.WriteLine("Dealer Blackjack!");
                    goto Start;
        }

Console.WriteLine("Your Card: " + playerCardOne);
Console.WriteLine("Dealers Card: " + dealerCardOne);
    await Task.Delay(100);

Console.WriteLine("");
Console.WriteLine("1: Hit | 2: Stand");
int choiceSelect = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}

Console.Read();