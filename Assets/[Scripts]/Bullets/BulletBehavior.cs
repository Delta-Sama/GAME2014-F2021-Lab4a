using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed = 0.0f;
    public GameBounds bulletBounds;

    public BulletDirection bulletDirection;

    private Vector3 direction = Vector2.down;
    private Vector2[] directions =
        {
            new Vector2(0, 1),  // UP
            new Vector2(1, 0),  // RIGHT
            new Vector2(0, -1), // DOWN
            new Vector2(-1, 0)  // LEFT
        };

    public void Start()
    {
        direction = directions[(int)bulletDirection];
    }

    private void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.y > bulletBounds.max || transform.position.y < bulletBounds.min)
        {
            ReturnToPool();
        }
    }

    public virtual void ReturnToPool() { }

}
