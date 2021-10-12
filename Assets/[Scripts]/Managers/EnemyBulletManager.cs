using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletManager : BulletManager
{
    public static EnemyBulletManager Instance;

    public override void Start()
    {
        base.Start();

        Instance = this;
    }

    protected override void AddBullet()
    {
        base.AddBullet();

        GameObject bullet = EnemyBulletFactory.Instance.CreateBullet();

        bulletPool.Enqueue(bullet);
    }
}
