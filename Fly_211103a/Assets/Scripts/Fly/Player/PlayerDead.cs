using UnityEngine;

public class PlayerDead : FlightOnDead
{
    // if player dead 
    public override void OnDead(GameObject killer)
    {
        // if player dead call GameOver in GameManager
        GameManager gamemanger = (GameManager)GameObject.FindObjectOfType(typeof(GameManager));
        gamemanger.GameOver();
        base.OnDead(killer);
    }
}
