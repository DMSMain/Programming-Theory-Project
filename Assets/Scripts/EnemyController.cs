using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f;

    // ABSTRACTION
    void FixedUpdate()
    {
        Move();
    }

    public virtual void Move()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); 
    }
}
