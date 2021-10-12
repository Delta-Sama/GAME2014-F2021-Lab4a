using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed = 0.0f;
    public Vector2 direction = Vector2.down;
    public GameBounds bulletBounds;

    private BulletManager bulletManager;

    private void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y > bulletBounds.max || transform.position.y < bulletBounds.min)
        {
            bulletManager.ReturnBullet(transform.gameObject);
        }
    }
}
