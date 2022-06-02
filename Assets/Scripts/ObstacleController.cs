using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float moveSpeed = 2f;

    // ABSTRACTION
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); 
    }
}


