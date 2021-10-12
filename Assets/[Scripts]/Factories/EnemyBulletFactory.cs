using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletFactory : BulletFactory
{
    public static EnemyBulletFactory Instance;

    public void Start()
    {
        Instance = this;
    }
}
