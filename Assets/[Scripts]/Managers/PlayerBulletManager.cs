using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletManager : BulletManager
{
    public static PlayerBulletManager Instance;

    public override void Start()
    {
        base.Start();

        Instance = this;
    }

    protected override void AddBullet()
    {
        base.AddBullet();

        GameObject bullet = PlayerBulletFactory.Instance.CreateBullet();

        bulletPool.Enqueue(bullet);
    }
}
