using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

//TODO: ADD MP3 MUSIC COMPATIBILITY

namespace PokeFight
{
    class Program
    {
        static private string[] PCPrefixes = { "ELITE TRAINER ", "OLD MAN ", "FISHERMAN ", "TEAM ROCKET MEMBER " };
        static private string[] PCNames = { "BROCK", "DWAYNE", "JONES", "SKIPPER", "JACKSON", "TOMMY", "LEROY" };
        static private string pName;
        static private int pSize;
        static private bool winner=false;
        static private int bLevel;
        static private Monster[] standIn;
        static private Random rng = new Random();
        static private Trainer Player, CPU;
        static SoundPlayer button = new SoundPlayer();
        static void Main(string[] args)
        {

            //set up game play
            drawTitleCard();
            SetUp();
            /*Player = new Trainer("TEST",1);
            Player.setParty(new Monster(9, 50),0);
            CPU = new Trainer("CPU", 1);
            CPU.setParty(new Monster(26, 50), 0);*/
            for (int x = 0; x < 1; x++)
                Player.Health += Player.getMember(x).getHP();
            for (int x = 0; x < 1; x++)
                CPU.Health += CPU.getMember(x).getHP();
            Battle();
            if(winner)
            {
                SoundPlayer start = new SoundPlayer();
                /*start.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\victory.wav";
                start.Play();*/
                Console.Clear();
                Console.WriteLine("Congratulations on winning and thank you for playing!!");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Better luck next time {Player.getName()}.\nMaybe come back and try again after studying some more on Pokémon typing advantages and battle strategies.");
                Console.ReadKey();
            }
        }

        public static void SetUp()
        {
            //plays oak's music
            SoundPlayer start = new SoundPlayer();
            /*start.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\profOak.mp3";
            start.PlayLooping();*/

            Console.Write("Please enter your trainer Name: ");
            pName = Console.ReadLine();
            Console.Clear();

            //set party size
            Console.Write("Please enter party size (1-6): ");
            while (true)
            {
                try
                {
                    pSize = Int32.Parse(Console.ReadLine());
                    if (pSize > 0)
                        if (pSize <= 6)
                            break;
                        else
                            Console.Write("That number was too Large. Try again.\n\nPlease enter party size (1-6): ");
                    else
                        Console.Write("That number was too small. Try again.\n\nPlease enter party size (1-6): ");
                }
                catch (FormatException)
                {
                    Console.Write("That wasn't an integer between or equal to 1 and 6. Try again.\n\nPlease enter party size (1-6): ");
                }
            }
            standIn = new Monster[pSize];
            Console.Clear();

            //set pokemon's levels
            Console.Write("Please enter the battle Level (1-100): ");
            while (true)
            {
                try
                {
                    bLevel = Int32.Parse(Console.ReadLine());
                    if (bLevel > 0)
                        if (bLevel <= 100)
                            break;
                        else
                            Console.Write("That number was too Large. Try again.\n\nPlease enter the battle Level (1-100): ");
                    else
                        Console.Write("That number was too small. Try again.\n\nPlease enter the battle Level (1-100): ");
                }
                catch (FormatException)
                {
                    Console.Write("That wasn't an integer between or equal to 1 and 100. Try again.\n\nPlease enter the battle Level (1-100): ");
                }
            }
            Console.Clear();

            //register info
            Player = new Trainer(pName, pSize);
            CPU = new Trainer(PCPrefixes[rng.Next(0, 4)] + PCNames[rng.Next(0, 7)], pSize);
            Console.WriteLine($"Welcome to the world of Pokémon, {Player.getName()}! You will take on a battle against {CPU.getName()}.\nYou should probably pick your team first, huh?\nIf you'd like your Pokémon choosen randomly, pick index number 0.");
            Console.ReadKey();
            Console.Clear();

            //player party select
            for (int member = 0; member < pSize; member++)
            {
                while (true)
                {
                    Console.Write($"Please enter the Pokédex number of your {member + 1} pick (type 'dex' followed by (1-8)): ");
                    string result = Console.ReadLine();
                    if (result.Contains("dex"))
                    {
                        try
                        {
                            int page = Int32.Parse("" + result[3]);
                            if(page > 0 && page < 9)
                            {
                                page -= 1;
                                Console.Clear();
                                Console.WriteLine($"Pokédex\n---------------------------------------\nPage {page + 1}:");
                                for (int x = page * 20; x < (page * 20) + 20; x++)
                                {
                                    if (x > 150)
                                        break;
                                    try
                                    {
                                        Monster display = new Monster(x + 1, 1);
                                        Console.WriteLine($"#{x + 1}:\t {display.getName()}");
                                    }
                                    catch
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine($"----------PAGE END------------");
                            }
                            else
                                Console.WriteLine("Invalid page number");
                        }
                        catch
                        {
                            Console.Write("Keyword 'dex' used with invalid page number.\n\n");
                        }
                    }
                    else
                    {
                        try
                        {
                            int dexNum = Int32.Parse(result);
                            if (dexNum > 0)
                                //have to set to largest number of pokemon when adding more
                                if (dexNum <= 151)
                                {
                                    Player.setParty(new Monster(dexNum, bLevel), member);
                                    break;
                                }
                                else
                                    Console.Write("That number was too Large. Try again.\n\n");
                            else if (dexNum == 0)
                            {
                                while(true)
                                {
                                    Player.setParty(new Monster(rng.Next(1, 152), bLevel), member);
                                    if (Player.getMember(member).getName() != null)
                                        break;
                                } 
                                break;
                            }
                            else
                                Console.Write("That number was too small. Try again.\n\n");
                        }
                        catch (FormatException)
                        {
                            Console.Write("Invalid input. Try again.\n\n");
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine(Player.disParty(member));
            }
            Console.ReadKey();
            //sets CPU party
            for (int x = 0; x < pSize; x++) 
            {
                CPU.setParty(new Monster(rng.Next(1, 152), bLevel), x);
                if (CPU.getMember(x).getName() == null)
                    --x;
            }
                
            Console.Clear();
            Console.WriteLine($"{CPU.getName()}'s party:\n{CPU.disParty()}");
            Console.ReadKey();
            for (int x = 0; x < pSize; x++)
                Player.Health += Player.getMember(x).getHP();
            for (int x = 0; x < pSize; x++)
                CPU.Health += Player.getMember(x).getHP();
            start.Stop();
        }
        public static void Battle()
        {
            SoundPlayer start = new SoundPlayer();
            /*start.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\battle.mp3";
            start.PlayLooping();*/
            //stay battling until someone completely loses
            int swappy = 0;
            while(Player.Health>0 || CPU.Health > 0)
            {
                //swap or battle select
                while (true)
                {
                    drawBattleScreen();
                    Console.Write("Swap Pokémon ('swap') or Attack ('attack')");
                    string response = Console.ReadLine();
                    if (response.ToLower().Equals("swap"))
                    {
                        while(true)
                        {
                            Console.Clear();
                            Console.WriteLine(Player.disParty());
                            Console.Write("Select which Pokémon to swap (type 'cancel' to cancel): ");
                            response = Console.ReadLine();
                            if (response.ToLower().Equals("cancel"))
                                break;
                            else
                            {
                                try
                                {
                                    int partNum = Int32.Parse(response)-1;
                                    if (Player.getMember(partNum).getHP()>0)
                                    {
                                        Player.rotate(partNum);
                                        //CPU still attacks on player's swap
                                        CPU.getMember(0).TryAttack(Player.getMember(0), CPU.CPUAttack(Player));
                                        break;
                                    }
                                    else
                                        Console.Write($"{Player.getMember(partNum).getName()} has already fainted. Pick a different Pokémon. ");
                                }
                                catch { Console.Write("Invalid party position integer. Try again. "); }
                            }
                        }
                        if(response.ToLower() != "cancel")
                            break;
                    }
                    else if(response.ToLower().Equals("attack"))
                    {
                        //move select
                        while (true)
                        {
                            drawBattleScreen();
                            //draws move set
                            drawMoveSet();
                            Console.SetCursorPosition(0, Console.WindowHeight - 1);
                            //prompts user input
                            Console.Write("Select which move to attack with (1-4 or 'cancel' to cancel): ");
                            //set string to input
                            response = Console.ReadLine();                            
                            if (response.ToLower().Equals("cancel"))
                                //returns to menu if cancel is chosen
                                break;
                            else
                            {
                                //tries to parse input value to int
                                try
                                {
                                    int partNum = Int32.Parse(response)-1; //corrects user input to array location
                                    if (partNum > 4 || partNum < 0)
                                        Console.Write("Invalid party position integer. Try again. ");//entered an integer value too high or low
                                    else if (Player.getMember(0).getMove(partNum).PP > 0)//checks if player's pick has PP left 
                                    {
                                        if (Player.getMember(0).getSpeed() > CPU.getMember(0).getSpeed()) //checks player's current pokemon speed against CPU's
                                        {
                                            Player.getMember(0).TryAttack(CPU.getMember(0), Player.getMember(0).getMove(partNum));//player has faster speed so attacks first 
                                            Console.Clear();
                                            drawBattleScreen();
                                            if (CPU.getMember(0).getHP() > 0)//checks if second attacker fainted
                                                CPU.getMember(0).TryAttack(Player.getMember(0), CPU.CPUAttack(Player));//second attacker didnt fait so they attack 
                                            else//computer swapping out fainted pokemon
                                            {
                                                Console.Clear();
                                                CPU.getMember(0).infoBox(0,0);
                                                for (int x = 0; x < pSize; x++)
                                                {
                                                    if (CPU.getMember(x).getHP() > 0)
                                                    { CPU.rotate(x); swappy = x; break; }
                                                }
                                                Player.getMember(0).infoBox(Console.WindowWidth-25, Console.WindowHeight - 5);
                                                Console.SetCursorPosition(20, 20);
                                                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                                                if (CPU.getMember(0).getHP() > 0)
                                                {
                                                    Console.Write($"{CPU.getName()}'s {CPU.getMember(swappy).getName()} fainted... {CPU.getName()} sends out {CPU.getMember(0).getName()}!");
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                        else//player lost/tied speed check so CPU attacks first 
                                        {
                                            CPU.getMember(0).TryAttack(Player.getMember(0), CPU.CPUAttack(Player));//CPU attacks
                                            if (Player.getMember(0).getHP() > 0)//checks player's pokemon faint status
                                                Player.getMember(0).TryAttack(CPU.getMember(0), Player.getMember(0).getMove(partNum));//player pokemon alive and attacks
                                            else//player prompted to switch pokemon 
                                            {
                                                Player.Health = 0;
                                                for (int x = 0; x < pSize; x++)
                                                    Player.Health += Player.getMember(x).getHP();
                                                if(Player.Health>0)
                                                {
                                                    drawBattleScreen();
                                                    Console.SetCursorPosition(20, 20);
                                                    Console.SetCursorPosition(0, Console.WindowHeight - 1);
                                                    Console.Write($"{Player.getName()}'s {Player.getMember(0).getName()} fainted... Who will {Player.getName()} send out next? ");
                                                    Console.ReadKey();
                                                    while (true)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine(Player.disParty());
                                                        Console.Write("Select which Pokémon to swap (type 'cancel' to cancel): ");
                                                        response = Console.ReadLine();
                                                        try
                                                        {
                                                            partNum = Int32.Parse(response) - 1;
                                                            if (partNum < 1 || partNum > pSize)
                                                                Console.Write("Invalid party position integer. Try again. ");//entered an integer value too high or low
                                                            else if (Player.getMember(partNum).getHP() > 0)
                                                            {
                                                                Player.rotate(partNum);
                                                                break;
                                                            }
                                                            else
                                                                Console.Write($"{Player.getMember(partNum).getName()} has already fainted. Pick a different Pokémon. ");
                                                        }
                                                        catch { Console.Write("Invalid party position integer. Try again. "); }//entered a non integer 
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    else//failed PP check and has to pick a different move (TO DO: GAME CAN SOFTLOCK FROM THIS... FIX THAT. Add struggle)
                                        Console.Write($"{Player.getMember(0).getMove(partNum).Name} is out of PP. Pick a different move. ");
                                }
                                catch { Console.Write("Invalid move position integer. Try again. "); }//input wasn't an int
                            }
                        }
                        if (response.ToLower() != "cancel")//player canceled attack back to menu or chose to play attack and it continues on to check health
                            break;
                    }
                }
                //checks poison status
                if (Player.getMember(0).poison)
                    Player.getMember(0).setHP(Player.getMember(0).getHP() - Player.getMember(0).getMHP() / 16);
                if (CPU.getMember(0).poison)
                    CPU.getMember(0).setHP(CPU.getMember(0).getHP() - CPU.getMember(0).getMHP() / 16);


                if (Player.getMember(0).getHP() < 0)
                {
                    drawBattleScreen();
                    Console.SetCursorPosition(20, 20);
                    Console.SetCursorPosition(0, Console.WindowHeight - 1);
                    Console.Write($"{Player.getName()}'s {Player.getMember(0).getName()} fainted... Who will {Player.getName()} send out next? ");
                    Console.ReadKey();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine(Player.disParty());
                        Console.Write("Select which Pokémon to swap: ");
                        string response = Console.ReadLine();
                        try
                        {
                            int partNum = Int32.Parse(response) - 1;
                            if (partNum < 1 || partNum > pSize)
                                Console.Write("Invalid party position integer. Try again. ");//entered an integer value too high or low
                            else if (Player.getMember(partNum).getHP() > 0)
                            {
                                Player.rotate(partNum);
                                break;
                            }
                            else
                                Console.Write($"{Player.getMember(partNum).getName()} has already fainted. Pick a different Pokémon. ");
                        }
                        catch { Console.Write("Invalid party position integer. Try again. "); }//entered a non integer 
                    }
                }
                if(CPU.getMember(0).getHP() < 0)
                {
                    Console.Clear();
                    CPU.getMember(0).infoBox(0,0);
                    for (int x = 0; x < pSize; x++)
                    {
                        if (CPU.getMember(x).getHP() > 0)
                        { CPU.rotate(x); swappy = x; }

                    }
                    Player.getMember(0).infoBox(Console.WindowWidth - 25, Console.WindowHeight - 5);
                    Console.SetCursorPosition(20, 20);
                    Console.SetCursorPosition(0, Console.WindowHeight - 1);
                    if(CPU.getMember(0).getHP() > 0)
                    {
                        Console.Write($"{CPU.getName()}'s {CPU.getMember(swappy).getName()} fainted... {CPU.getName()} sends out {CPU.getMember(0).getName()}!");
                        Console.ReadKey();
                    }
                }
                
                //check health at the end of the turn to exit or not
                if (CPU.getMember(0).getHP() <= 0)
                {
                    Console.Clear();
                    drawBattleScreen();
                    Console.SetCursorPosition(1, (Console.WindowHeight / 3) * 2);
                    Console.WriteLine($"{CPU.getName()} is out of Pokémon... YOU'RE A CHAMPION!");
                    winner = true;
                    Console.ReadKey();
                    start.Stop();
                    button.Play();
                    break;
                }   
                if (Player.getMember(0).getHP() <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{Player.getName()} is out of Pokémon... {Player.getName()} blacked out!");
                    winner = false;
                    Console.ReadKey();
                    start.Stop();
                    button.Play();
                    break;
                }
            }
        }
        static void drawBattleScreen()
        {
            Console.Clear();
            CPU.getMember(0).infoBox(0,0);
            Player.getMember(0).infoBox(Console.WindowWidth - 25, Console.WindowHeight - 6);
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
        }
        static void drawTitleCard()
        {
            SoundPlayer start = new SoundPlayer();
            
            /*start.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\song.mp3";
            start.PlayLooping();*/
            Console.WriteLine("\t\t\t                                  ,'\\");
            Console.WriteLine("\t\t\t    _.----.        ____         ,'  _\\   ___    ___     ____");
            Console.WriteLine("\t\t\t_,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.");
            Console.WriteLine("\t\t\t\\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |");
            Console.WriteLine("\t\t\t \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |");
            Console.WriteLine("\t\t\t   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |");
            Console.WriteLine("\t\t\t    \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |");
            Console.WriteLine("\t\t\t     \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |");
            Console.WriteLine("\t\t\t      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |");
            Console.WriteLine("\t\t\t       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |");
            Console.WriteLine("\t\t\t        \\_.-'       |__|    `-._ |              '-.|     '-.| |   |");
            Console.WriteLine("\t\t\t                                `'                            '-._|");
            Console.WriteLine("                                             Press any key to continue...");
            Console.WriteLine("\t\t\t\t\t             `;,;.;,;.;.'");
            Console.WriteLine("\t\t\t\t\t              ..:;:;::;: ");
            Console.WriteLine("\t\t\t\t\t        ..--''' '' ' ' '''--.  ");
            Console.WriteLine("\t\t\t\t\t      /' .   .'        '.   .`\\");
            Console.WriteLine("\t\t\t\t\t     | /    /            \\   '.|");
            Console.WriteLine("\t\t\t\t\t     | |   :             :    :|");
            Console.WriteLine("\t\t\t\t\t   .'| |   :             :    :|");
            Console.WriteLine("\t\t\t\t\t ,: /\\ \\.._\\ __..===..__/_../ /`.");
            Console.WriteLine("\t\t\t\t\t|'' |  :.|  `'          `'  |.'  ::.");
            Console.WriteLine("\t\t\t\t\t|   |  ''|    :'';          | ,  `''\\");
            Console.WriteLine("\t\t\t\t\t|.:  \\/  | /'-.`'   ':'.-'\\ |  \\,   |");
            Console.WriteLine("\t\t\t\t\t| '  /  /  | / |...   | \\ |  |  |';'|");
            Console.WriteLine("\t\t\t\t\t \\ _ |:.|  |_\\_|`.'   |_/_|  |.:| _ |");
            Console.WriteLine("\t\t\t\t\t/,.,.|' \\__       . .      __/ '|.,.,\\");
            Console.WriteLine("\t\t\t\t\t     | ':`.`----._____.---'.'   |");
            Console.WriteLine("\t\t\t\t\t      \\   `:\"\"\"------ - '\"\"' |   | ");
            Console.Write("\t\t\t\t\t       ',-,-',             .'-=,=,");
            Console.SetCursorPosition(Console.WindowWidth-1, Console.WindowHeight-1);
            Console.ReadKey();
            start.Stop();
            button.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\button.wav";
            button.Play();
            Task.WaitAll();
            Console.Clear();
        }
        static void drawMoveSet()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 7);
            for (int x = 0; x < Console.WindowWidth; x++)
                { Console.SetCursorPosition(x, Console.WindowHeight - 6); Console.Write("_"); }
            Console.SetCursorPosition(0, Console.WindowHeight-5);
            Console.Write($"1: {Player.getMember(0).getMove(0).Name}\t{Player.getMember(0).getMove(0).disPP()}");
            Console.SetCursorPosition(30, Console.WindowHeight - 5);
            Console.Write($"2: {Player.getMember(0).getMove(1).Name}\t{Player.getMember(0).getMove(1).disPP()}");
            Console.SetCursorPosition(0, Console.WindowHeight - 3);
            Console.Write($"3: {Player.getMember(0).getMove(2).Name}\t{Player.getMember(0).getMove(2).disPP()}");
            Console.SetCursorPosition(30, Console.WindowHeight - 3);
            Console.Write($"4: {Player.getMember(0).getMove(3).Name}\t{Player.getMember(0).getMove(3).disPP()}");
        }
    }
}
