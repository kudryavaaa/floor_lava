using UnityEngine;
using System.Collections;

public class WarBandMemberHiding : MonoBehaviour
{
    void Start()
    {
        HumanoidMemberHiding human = new HumanoidMemberHiding();
        HumanoidMemberHiding enemy = new EnemyMemberHiding();
        HumanoidMemberHiding orc = new OrcMemberHiding();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}