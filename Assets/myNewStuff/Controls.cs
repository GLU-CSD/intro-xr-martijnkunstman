using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{    
    [SerializeField] private Transform childObject;

    // Input flags
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;  

    // Movement variables
    public Vector3 steeringForce = Vector3.zero;  // External forces applied to the object
    private Vector3 velocity = Vector3.zero;      // Current velocity of the object
    private Vector3 acceleration = Vector3.zero;  // Acceleration
    private Vector3 damping = new Vector3(0.8f, 0.8f, 0.8f); // Damping factor to reduce velocity over time

    // Movement speed
    public float maxForce = 0.001f;  // Maximum steering force
    public float maxSpeed = 5.0f;  // Maximum speed of the object

    void Update()
    {
        // Reset steering force
        steeringForce = Vector3.zero;

        // Apply input to steering force
        if (up) steeringForce += new Vector3(0, maxForce, 0);
        if (down) steeringForce += new Vector3(0, -maxForce, 0);
        if (left) steeringForce += new Vector3(-maxForce, 0, 0);
        if (right) steeringForce += new Vector3(maxForce, 0, 0);

        // Ensure steering force doesn't exceed maxForce
        steeringForce = Vector3.ClampMagnitude(steeringForce, maxForce);

        // Compute acceleration from steering force
        acceleration = steeringForce;

        // Update velocity using acceleration
        velocity += acceleration;

        // Clamp velocity to max speed
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        // Apply damping to velocity
        velocity = Vector3.Scale(velocity, damping);

        // Update position
        childObject.position += velocity * Time.deltaTime;

        // Optionally, debug log to observe values
        Debug.Log($"Velocity: {velocity}, Position: {childObject.position}");
    }

    // Button event handlers
    public void UpPressed() { up = true; }
    public void UpReleased() { up = false; }
    public void DownPressed() { down = true; }
    public void DownReleased() { down = false; }
    public void LeftPressed() { left = true; }
    public void LeftReleased() { left = false; }
    public void RightPressed() { right = true; }
    public void RightReleased() { right = false; }
}
