using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new();

        myPlayer.Experience = 5;
        int exp = myPlayer.Experience;
        int lvl = myPlayer.Level;
    }
}