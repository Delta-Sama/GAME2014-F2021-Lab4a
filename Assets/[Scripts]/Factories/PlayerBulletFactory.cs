using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletFactory : BulletFactory
{
    public static PlayerBulletFactory Instance;

    public void Start()
    {
        Instance = this;
    }
}
