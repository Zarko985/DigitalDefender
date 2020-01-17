using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Llave")
        {
            Debug.Log("Puerta Abierta");
            Destroy(Door);

        }

    }



}
