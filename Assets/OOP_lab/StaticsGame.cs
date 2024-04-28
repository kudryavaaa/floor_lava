using UnityEngine;
using System.Collections;

public class GameStatics
{
    void Start()
    {
        EnemyStatics enemy1 = new EnemyStatics();
        EnemyStatics enemy2 = new EnemyStatics();
        EnemyStatics enemy3 = new EnemyStatics();

        //You can access a static variable by using the class name
        //and the dot operator.
        int x = EnemyStatics.enemyCount;
    }
}
