using UnityEngine;
/*      __  _____    ____  ____ 
       / / / /   |  / __ \/ __ \
      / /_/ / /| | / /_/ / / / /
     / __  / ___ |/ _, _/ /_/ / 
    /_/_/_/_/__|_/_/_|_/_____/_ 
      / ____/ __ \/ __ \/ ____/ 
     / /   / / / / / / / __/    
    / /___/ /_/ / /_/ / /___    
    \____/\____/_____/_____/ 
        アンフェタミンを燃料
*/
public class MovementComponent : MonoBehaviour
{
    #region Field Declarations
    
    [SerializeField] private float speed = 10f;
    
    #endregion
    
    private void Update()
    {
        MoveShip();
    }
    
    private void MoveShip()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(-verticalInput, horizontalInput , 0);
        
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
