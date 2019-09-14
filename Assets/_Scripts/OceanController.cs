using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController : MonoBehaviour
{
    // speed of the ocean scroll
    public float verticalSpeed = 0.05f;

    public float resetPosition = 19.2f;
    public float checkPosition = -9.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }
    /// <summary>
    /// This method moves the ocean down the screen at verticalSpeed
    /// </summary>
    void Move()
    {
        //Vector2 newPosition = new Vector2(0.0f, verticalSpeed);
        transform.position -= new Vector3(0.0f,verticalSpeed,0.0f);
    }
    /// <summary>
    /// This method resets the ocean to the 
    /// </summary>
    void Reset()
    {
        transform.position = new Vector2(0.0f, resetPosition);
    }
    void CheckBounds()
    {
        if(transform.position.y <= checkPosition)
        {
            Reset();
        }
    }
}
