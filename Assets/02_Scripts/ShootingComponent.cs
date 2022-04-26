using UnityEngine;

public class ShootingComponent : MonoBehaviour
{
    [SerializeField] bool isPhysicsMovement = false;
    
    [Header("References")]
    [SerializeField] Transform[] muzzles = new Transform[2];
    [SerializeField] GameObject bulletPrefab = null;

    [Header("Physics Movement")]
    [SerializeField] float thrust = 200;

    [Header("Transform Movement")]
    [SerializeField] float speed = 20;

    void Update()
    {
        // If Space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < muzzles.Length; i++)
            {
                // Spawn bullet foreach muzzle position
                GameObject newBullet = Instantiate(bulletPrefab, muzzles[i].position, muzzles[i].rotation);
                
                if (isPhysicsMovement)
                {
                    // Start physics movement
                    newBullet.GetComponent<Bullet>().StartPhysicsMovement(thrust);
                }
                else
                {
                    // Start transform movement
                    newBullet.GetComponent<Bullet>().StartTransformMovement(speed);
                }
            }
        }
    }
}
