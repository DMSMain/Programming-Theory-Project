using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Enemy2 : EnemyController
{
    Vector2 moveVector = new Vector2 (-1,1);

    // POLYMORPHISM
    public override void Move()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime); 
    }
}
