using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [Header("Enemy Movement")]
    public GameBounds speedBounds;
    public GameBounds gameBounds;

    [Header("Bullet")]
    public GameObject BulletPrefab;
    public GameObject bulletSpawn;

    public BulletManager bulletManager;

    private float startingPoint = 0.0f;
    private float randomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(speedBounds.min, speedBounds.max);
        startingPoint = Random.Range(gameBounds.min + randomSpeed, gameBounds.max - randomSpeed);

        bulletManager = FindObjectOfType<BulletManager>();
    }

    private float lastBulletTime = 0.0f;
    private float BULLET_COOLDOWN = 0.25f;
    void Update()
    {
        if (lastBulletTime < Time.time)
        {
            lastBulletTime = Time.time + BULLET_COOLDOWN;
            BULLET_COOLDOWN = Random.Range(0.2f, 0.4f);

            bulletManager.GetBullet(transform.position);
        }

        transform.position = new Vector2(startingPoint + (Mathf.PingPong(Time.time, randomSpeed) * 2 - randomSpeed), transform.position.y);
    }

    private void FixedUpdate()
    {
        
    }
}
