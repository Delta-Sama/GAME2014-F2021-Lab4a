using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletManager : BulletManager
{
    public static EnemyBulletManager Instance;

    private void Start()
    {
        base.Start();

        Instance = this;
    }

    protected override void AddBullet()
    {
        base.AddBullet();

        GameObject bullet = BulletFactory.Instance.CreateBullet(BulletType.ENEMY);

        bulletPool.Enqueue(bullet);
    }
}
