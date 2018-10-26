using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // The speed of the Player
    public float speed = 1.0f;
    private float y;

    private void Start()
    {
        y = transform.position.y;
    }

    // Player Movement
    void Update ()
    {
        // Stops the player from moving of the edge.
        if (transform.position.x <= -5.6f)
        {
            transform.position = new Vector3(-5.6f, y, 0);
        }
        if (transform.position.x >= 5.6f)
        {
            transform.position = new Vector3(5.6f, y, 0);
        }
        
        // Moves the player.
        transform.position += new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
    }
}
