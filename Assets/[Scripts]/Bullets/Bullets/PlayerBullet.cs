using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : BulletBehavior
{
    public override void ReturnToPool()
    {
        PlayerBulletManager.Instance.ReturnBullet(transform.gameObject);
    }
}
