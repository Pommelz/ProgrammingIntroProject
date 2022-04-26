using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] List<Material> materialList = new List<Material>();
    MeshRenderer meshRend;

    // Start is called before the first frame update
    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
    }


    public void BlinkOnHit()
    {

    }

    //public IEnumerator BlinkForDuration()
    //{
    //    meshRend.material.color
    //    yield return new WaitForSeconds
    //    yield return null;
    //}
}
