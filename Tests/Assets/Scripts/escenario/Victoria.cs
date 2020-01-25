using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject texto;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            texto.SetActive(true);

            Invoke("desactivar", 4f);

        }

    }


    void desactivar()
    {
        texto.SetActive(false);
    }
}
