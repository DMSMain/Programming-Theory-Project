using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : EnemyController
{
    Vector2 moveVector = new Vector2 (-1,1);

    private void Start()
    {
        
    }

    public override void Move()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime); 
    }
}
