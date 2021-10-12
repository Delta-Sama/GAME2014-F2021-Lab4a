using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [Range(0.0f,1.0f)] public float slowDown = 0.0f;
    public GameBounds bounds;
    public float speed = 0.0f;

    private float horizontal;
    private Rigidbody2D rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Debug.Log("update");

    }

    private void FixedUpdate()
    {
        rBody.AddForce(new Vector3(horizontal, 0, 0) * speed * Time.deltaTime);

        rBody.velocity *= slowDown;

        CheckBounds();
    }

    private void CheckBounds()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bounds.min, bounds.max), transform.position.y,0);
    }
}
