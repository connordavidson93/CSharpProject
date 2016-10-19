using System;

public class Powerup{
    public int power = 10;
    public float duration = 2;
    public void RunPowerUp(){
        Console.WriteLine("PowerUp Ran");
    }
    public void RechargePowerUp(int _power){
        power += _power;
        Console.WriteLine("Recharge PowerUp to " + power);
    }
}