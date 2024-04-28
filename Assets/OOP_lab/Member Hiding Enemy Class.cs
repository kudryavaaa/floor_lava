using UnityEngine;
using System.Collections;

public class EnemyMemberHiding : HumanoidMemberHiding
{
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
