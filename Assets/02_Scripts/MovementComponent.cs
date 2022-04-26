using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    #region Field Declarations

    [SerializeField] private float speed = 10f;

    private void Update()
    {
        MoveShip();
    }

    private void MoveShip()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x: -verticalInput, y: horizontalInput, z: 0);

        transform.Translate(translation: direction * speed * Time.deltaTime);
    }

    #endregion
}
