using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Tooltip("Defines how long does it takes to destroy this object")]
    [SerializeField] float destroyDelay = 3f;

    void Start()
    {
        // Start timer
        StartCoroutine(DestroyTimer());
    }

    IEnumerator DestroyTimer()
    {
        // Wait for destroyDelay seconds
        yield return new WaitForSeconds(destroyDelay);
        // & destroy this object
        Destroy(this.gameObject);
    }
}
