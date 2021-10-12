using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletManager : BulletManager
{
    public static PlayerBulletManager Instance;

    private void Start()
    {
        base.Start();

        Instance = this;
    }

    protected override void AddBullet()
    {
        base.AddBullet();

        GameObject bullet = BulletFactory.Instance.CreateBullet(BulletType.PLAYER);

        bulletPool.Enqueue(bullet);
    }
}
