using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : BulletBehavior
{
    public override void ReturnToPool()
    {
        Debug.Log("Return a bullet");
        EnemyBulletManager.Instance.ReturnBullet(transform.gameObject);
    }
}
