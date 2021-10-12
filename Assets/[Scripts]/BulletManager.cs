using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [HideInInspector] public Queue<GameObject> bulletPool;
    public int bulletNumber;

    public static BulletManager Instance;

    private void Start()
    {
        Instance = this;

        bulletPool = new Queue<GameObject>();

        BuildBulletPool();
    }

    public void BuildBulletPool()
    {
        for (int i = 0; i < bulletNumber; i++)
            AddBullet();
    }

    private void AddBullet()
    {
        GameObject bullet = BulletFactory.Instance.CreateBullet();

        bulletPool.Enqueue(bullet);
    }

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
