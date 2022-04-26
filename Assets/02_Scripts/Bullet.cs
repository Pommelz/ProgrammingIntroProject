using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rigidbody;
    bool startTransformMovement = false;
    float transformMovementSpeed = 10;

    private void Awake()
    {
        // Reference physics body
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void StartPhysicsMovement(float thrust)
    {
        // Add impulsive force to body in local upper direction
        rigidbody.AddForce(this.transform.up * thrust, ForceMode2D.Impulse);
    }

    public void StartTransformMovement(float newSpeed)
    {
        // Store new speed value
        transformMovementSpeed = newSpeed;
        // Disable physics body 
        rigidbody.isKinematic = true;
        // Start movement
        startTransformMovement = true;
    }

    private void Update()
    {
        // If movement started
        if (startTransformMovement)
        {
            // Move to the right every frame
            transform.position += this.transform.up * transformMovementSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            Debug.Log("BAM ENEMY HIT!");
        }
    }
}
