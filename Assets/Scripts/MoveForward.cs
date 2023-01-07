using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private int moveSpeed = 10;
    
    
    
    public void Move()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }

    public void Update()
    {
        Move();
    }
}
