using System;


    public class Program
    {
        public static Powerup Health = new Powerup();
        public static Powerup Ammo = new Powerup();
        public static void Main(string[] args)
        {
            Health.duration = 10;
            Health.RunPowerUp();
            Console.WriteLine(Health.duration);
            Ammo.RunPowerUp();

            Health.RechargePowerUp(20);
            Ammo.RechargePowerUp(300);
        }
    }
