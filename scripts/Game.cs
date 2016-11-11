using System;
public class Game
{
    public static bool canPlay = true;
    public Game()
    {
        Health.power = 100;
        Health.message = "You are getting stronger.";
        Ammo.message = "You have more ammo.";
        Cave.StartMessage = "You have entered a cave.";
        UnderWater.objects = new string[] { "Seaweed", "Coral", "Fish", "Shark" };
    }

    private string defineGameState = "Start";
    private GameState.GameStates toEnum;
    public void Play()
    {
        switch (toEnum)
        {
            case GameState.GameStates.Start:
                Console.WriteLine("Please type in your name.");
                name = Console.ReadLine();
                Console.WriteLine("Your Player Name is " + name);
                Console.WriteLine("Play commands: Play, End, Help");
                defineGameState = Console.ReadLine();
                if(Enum.TryParse(defineGameState, out toEnum))
                    Console.WriteLine(toEnum);
                Play();
                break;

            case GameState.GameStates.Died:
                Console.WriteLine("You died.");
                GameState.currentGameState = GameState.GameStates.End;
                Play();
                break;

            case GameState.GameStates.End:
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                break;

            case GameState.GameStates.Help:
                Console.WriteLine("What do you need help for? If you can't play this game, you have issues.");
                Play();
                break;

            case GameState.GameStates.Play:
                while (Game.canPlay)
                {
                    Cave.Enter();
                    Random randomNum = new Random();
                    Cave.Encounter(randomNum.Next(0, Cave.objects.Length), "walked");
                    GameTimer();
                    Play();
                }
                Play();
                break;

            default:
                Console.WriteLine(" is not a valid option.");
                Play();

                break;
        }
    }

    public static void GameTimer()
    {
        System.Threading.Thread.Sleep(2000);
    }
    //Game Levels
    private LevelBase Cave = new CaveLevel();
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
