using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        MoveShip();
    }

    private void MoveShip()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(verticalInput, horizontalInput, 0);

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
