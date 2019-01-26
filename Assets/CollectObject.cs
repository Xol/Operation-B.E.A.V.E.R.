using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public GameObject currentInterObject = null;
    public Collider2D collider;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("objectTree"))
        {
            currentInterObject = collider.gameObject;
        }


        if (collider.CompareTag("objectBarrage"))
        {
            currentInterObject = null;
        }
    }
}
