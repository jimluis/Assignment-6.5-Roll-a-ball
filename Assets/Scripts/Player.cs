using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision.gameObject.name: "+ other.gameObject.name);

        if(other.gameObject.CompareTag("collectable"))
            Destroy(other.gameObject);

    }
}
