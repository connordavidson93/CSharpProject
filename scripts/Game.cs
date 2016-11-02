using System;
public class Game {
    public static bool canPlay = true;
    public Game (){
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
        UnderWater.objects = new string[]{"Seaweed", "Coral", "Fish", "Shark"};
    }

    //Runs at the start of the game
    public void Start(){
        Console.WriteLine("Please type in your name.");
        name = Console.ReadLine();
        Console.WriteLine("Your Player Name is " + name);
        Cave.Enter();
       while(Game.canPlay){
           GameTimer();
           Play();
       }
       Console.WriteLine("You died.");
       Console.WriteLine("Game Over");
    }

    public string gameState;

    private void Play(){
        Console.WriteLine("Play commands: play, end, help");
        gameState = Console.ReadLine();

        if(gameState == "end"){
            Console.WriteLine("Game Over");
            Environment.Exit(0);
        }

        if(gameState == "help"){
            Console.WriteLine("What do you need help for? If you can't play this game, you have issues.");
            Play();
        }

        if(gameState != "help" && gameState != "play" && gameState != "end"){
            Console.WriteLine(gameState + " is not a valid option.");
            Play();
        }
        Random randomNum = new Random();
        Cave.Encounter(randomNum.Next(0, Cave.objects.Length));
        
    }

    public static void GameTimer(){
        System.Threading.Thread.Sleep(2000);
    }
    //Game Levels
    private LevelBase Cave = new LevelBase();
    public static LevelBase UnderWater = new LevelBase();


    //Game PowerUps
    public PowerUpBase Health = new PowerUpBase();
    public PowerUpBase Ammo = new PowerUpBase();


    //Game Weapons
    private WeaponBase Gun = new WeaponBase();
    private WeaponBase Rifle = new WeaponBase();
    private WeaponBase Knife = new WeaponBase();

    
    public string name;
    private int score;
}
 /*
        After prompt the game for a name we:
        Enter a cave.
        Find Health.
        Meet a dragon. (need an enemy class)
        Pick a weapon.
        Battle dragon. (need battle class)
        If we win: get Health and ammo
        If dragon wins: Lose Health;
        */