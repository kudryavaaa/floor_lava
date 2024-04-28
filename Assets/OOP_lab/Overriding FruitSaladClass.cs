using UnityEngine;
using System.Collections;

public class FruitSaladOverriding : MonoBehaviour
{
    void Start()
    {
        AppleOverriding myApple = new AppleOverriding();

        myApple.SayHello();
        myApple.Chop();


        FruitOverriding myFruit = new AppleOverriding();
        myFruit.SayHello();
        myFruit.Chop();
    }
}