using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float boundary = 4.4f;
    private float flyForce = 0.5f;

    public bool alive { get; private set; }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        alive = true;
    }

    // ABSTRACTION
    void FixedUpdate()
    {
        Jump();
        StayInBounds();
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * flyForce, ForceMode2D.Impulse);
        }
    }

    void StayInBounds()
    {
        if (transform.position.y > boundary)
        {
            transform.position = new Vector2 (transform.position.x, boundary);
            rb.velocity = Vector2.zero;
        }

        if (transform.position.y < -boundary - 1)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(gameObject);
        alive = false;  
    }
}
