using UnityEngine;
using System.Collections;

public class OrcMemberHiding : EnemyMemberHiding
{

    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
