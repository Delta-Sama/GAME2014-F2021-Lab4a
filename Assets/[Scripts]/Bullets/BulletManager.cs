using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [HideInInspector] public Queue<GameObject> bulletPool;
    public int bulletNumber;

    public void Start()
    {
        bulletPool = new Queue<GameObject>();
    }

    protected virtual void AddBullet() { }

    public GameObject GetBullet(Vector2 position)
    {
        if (bulletPool.Count < 1)
        {
            AddBullet();
            bulletNumber++;
        }

        GameObject bullet = bulletPool.Dequeue();
        bullet.transform.position = position;
        bullet.SetActive(true);

        return bullet;
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPool.Enqueue(bullet);
    }
}
