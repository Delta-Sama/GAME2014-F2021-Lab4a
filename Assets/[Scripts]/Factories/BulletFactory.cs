using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class BulletFactory : MonoBehaviour
{
    [Header("Bullet Type")]
    public GameObject Bullet;

    public GameObject CreateBullet()
    {
        GameObject bullet = Instantiate(Bullet);

        bullet.transform.parent = transform;
        bullet.SetActive(false);

        return bullet;
    }
}