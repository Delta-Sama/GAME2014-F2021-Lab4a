using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject playerBullet;
    public GameObject enemyBullet;

    public static BulletFactory Instance;

    private void Start()
    {
        Instance = this;
    }

    public GameObject CreateBullet(BulletType type = BulletType.ENEMY)
    {
        GameObject bullet = null;
        switch (type)
        {
            case BulletType.PLAYER:
                bullet = Instantiate(playerBullet);
                break;
            case BulletType.ENEMY:
                bullet = Instantiate(enemyBullet);
                break;
        }

        bullet.transform.parent = transform;
        bullet.SetActive(false);

        return bullet;
    }
}

public enum BulletType
{
    PLAYER,
    ENEMY
}