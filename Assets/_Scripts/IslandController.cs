using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour
{
    // speed of the ocean scroll
    public float verticalSpeed = 0.05f;

    public float resetPosition = 2.71f;
    public float checkPosition = -2.71f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
        Move();
    }
    /// <summary>
    /// This method moves the ocean down the screen at verticalSpeed
    /// </summary>
    void Move()
    {
        //Vector2 newPosition = new Vector2(0.0f, verticalSpeed);
        transform.position -= new Vector3(0.0f, verticalSpeed, 0.0f);
    }
    /// <summary>
    /// This method resets the ocean to the 
    /// </summary>
    void Reset()
    {
        float randomXPosition = Random.Range(-2.88f, 2.88f);
        transform.position = new Vector2(randomXPosition, resetPosition);
    }
    /// <summary>
    /// Checks when the ocean needs to reset back to the top
    /// </summary>
    void CheckBounds()
    {
        if (transform.position.y <= checkPosition)
        {
            Reset();
        }
    }
}
