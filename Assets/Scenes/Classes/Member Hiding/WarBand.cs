using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new();
        Humanoid enemy = new Enemy_();
        Humanoid orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}