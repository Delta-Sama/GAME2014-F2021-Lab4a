using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [HideInInspector] public Queue<GameObject> bulletPool;
    public GameObject BulletPrefab;
    public int bulletNumber;

    private void Start()
    {
        bulletPool = new Queue<GameObject>();

        BuildBulletPool();
    }

    public void BuildBulletPool()
    {
        for (int i = 0; i < bulletNumber; i++)
        {
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }
    }

    public GameObject GetBullet(Vector2 position)
    {
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
