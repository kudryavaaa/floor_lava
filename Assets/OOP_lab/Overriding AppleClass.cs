using UnityEngine;
using System.Collections;

public class AppleOverriding : FruitOverriding
{
    public AppleOverriding()
    {
        Debug.Log("1st Apple Constructor Called");
    }


    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}
