using UnityEngine;
using System.Collections;

public class GameProperties : MonoBehaviour
{
    void Start()
    {
        PlayerProperties myPlayer = new PlayerProperties();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}