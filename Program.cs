// Global Variables
using System.Globalization;

int globalTextDelay = 50;
int textSpacing = 2;
// int chips = 0;

// Data & Constants
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

// Random rnd = new Random();
//     for(int i = 0; i < 13; i++){int randomVal = rnd.Next(1, 13); Console.WriteLine(cards[randomVal]);} await Task.Delay(100); Console.Clear(); Console.ReadLine(); 

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
    int dealerInitTotal = dealerCardOne + dealerCardTwo;
        if(dealerCardOne + dealerCardTwo == 21){
            for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
                Console.WriteLine("Dealer Blackjack!"); await Task.Delay(100); Console.ReadLine();
                    goto Start;
        }

Console.WriteLine("Your Card: " + playerCardOne);
Console.WriteLine("Dealers Card: " + dealerCardOne);
    await Task.Delay(100);

Choice:
Console.WriteLine("");
Console.WriteLine("1: Hit | 2: Stand");
int choiceSelect = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}

    if(choiceSelect == 1){ // HIT
        goto Hit;
    } else if(choiceSelect == 2){ // STAND
        for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
            Console.WriteLine("You Stand!");
        goto STD;
    } else if(choiceSelect != 1 && choiceSelect != 2){
        for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
            Console.WriteLine("Invalid!"); Console.Clear();
        goto Choice;
    }

Hit:
    for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
        Console.WriteLine("You Hit!"); Console.WriteLine("");
    Random randSnd = new Random();
        int playerCardTwoRand = randSnd.Next(1, 13);
        int playerCardTwo = int.Parse(cards[playerCardTwoRand]);
    Console.WriteLine("Your Second Card: " + playerCardTwo);
        int playerCardTotal = playerCardOne + playerCardTwo;
    Console.WriteLine("Your Total = " + playerCardTotal);
    
    if(playerCardTotal == 21){
        for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
            Console.WriteLine("Blackjack!"); await Task.Delay(100); Console.ReadLine();
        goto Start;
    }

    for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
        Console.WriteLine("Hit Again?"); Console.WriteLine("");
    int hitAgain = Convert.ToInt32(Console.ReadLine());
        if(hitAgain == 1){
            Console.WriteLine("You Hit Again!");
                Random trdCard = new Random();
                int playerCardThreeRand = trdCard.Next(1, 13);
                int playerCardThree = int.Parse(cards[playerCardThreeRand]);
            Console.WriteLine("Your Third Card: " + playerCardThree);
                int newPlayerCardTotal = playerCardOne + playerCardTwo + playerCardThree;
            Console.WriteLine("Your Total = " + newPlayerCardTotal);
                if(newPlayerCardTotal > 21){
                    for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
                        Console.WriteLine("You Went Over 21!"); await Task.Delay(100); Console.ReadLine();
            } else if(hitAgain == 2){
                await Task.Delay(100); goto STD;
            }
                if(newPlayerCardTotal < 21){
                    for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
                        Console.WriteLine("Hit Again?");
                    int thirdHit = Convert.ToInt32(Console.ReadLine());
                        if(thirdHit == 1){
            Console.WriteLine("You Hit Again!");
                Random fourthCard = new Random();
                int playerCardFourRand = fourthCard.Next(1, 13);
                int playerCardFour = int.Parse(cards[playerCardFourRand]);
            Console.WriteLine("Your Third Card: " + playerCardThree);
                int PlayerCardTotal3 = playerCardOne + playerCardTwo + playerCardThree + playerCardFour;
            Console.WriteLine("Your Total = " + PlayerCardTotal3);
                if(PlayerCardTotal3 > 21){
                    for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
                        Console.WriteLine("You Went Over 21!"); await Task.Delay(100); Console.ReadLine();
                }
                } else if(thirdHit == 2){
                    await Task.Delay(100); goto STD;
                }
            }
        }

STD:
for(int i = 0; i < textSpacing; i++){Console.WriteLine("");}
    Console.WriteLine("You Stand!"); await Task.Delay(100);
// if(dealerInitTotal == 17){
// }
// Random finalDealer = new Random();
//     int dealerNextCard = finalDealer.Next(1, 13);
//     int dealerCardThree = int.Parse(cards[dealerNextCard]);

// Console.Read();
// ADD BLACKJACK FEATURE DOWN HERE