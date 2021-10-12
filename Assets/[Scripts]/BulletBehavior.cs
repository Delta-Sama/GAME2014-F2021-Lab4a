using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed = 0.0f;
    public GameBounds bulletBounds;

    public BulletDirection bulletDirection;

    private BulletManager bulletManager;
    private Vector3 direction = Vector2.down;

    private void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();

        switch(bulletDirection)
        {
            case BulletDirection.UP:
                direction = new Vector2(0, 1);
                break;
            case BulletDirection.RIGHT:
                direction = new Vector2(1, 0);
                break;
            case BulletDirection.DOWN:
                direction = new Vector2(0, -1);
                break;
            case BulletDirection.LEFT:
                direction = new Vector2(-1, 0);
                break;
        }
    }

    private void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.y > bulletBounds.max || transform.position.y < bulletBounds.min)
        {
            bulletManager.ReturnBullet(transform.gameObject);
        }
    }
}
