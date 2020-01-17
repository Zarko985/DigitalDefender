using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickController : MonoBehaviour
{
    public GameObject Objeto;
    public GameObject parent;
    public Transform guide;
    public float Fuerza = 400;
    bool llevandoAlgo;

    public GameObject ChangerWeapon;

    public float range = 2;

    // Use this for initialization
    void Start()
    {
        Objeto.GetComponent<Rigidbody>().useGravity = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (llevandoAlgo == false)
        {
            if (Input.GetKeyDown(KeyCode.E) && (guide.transform.position - transform.position).sqrMagnitude < range * range)
            {
                pickup();
                llevandoAlgo = true;
            }
        }
        else if (llevandoAlgo == true)
        {
            ChangerWeapon.SetActive(false);
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChangerWeapon.SetActive(true);

                drop();

                llevandoAlgo = false;
            }
        }
    }
    void pickup()
    {
        Objeto.GetComponent<Rigidbody>().useGravity = false;
        Objeto.GetComponent<Rigidbody>().isKinematic = true;
        Objeto.transform.position = guide.transform.position;
        Objeto.transform.rotation = guide.transform.rotation;
        Objeto.transform.parent = parent.transform;
    }
    void drop()
    {
        Objeto.GetComponent<Rigidbody>().useGravity = true;
        Objeto.GetComponent<Rigidbody>().isKinematic = false;
        Objeto.GetComponent<Rigidbody>().AddForce(transform.forward * Fuerza);
        Objeto.transform.parent = null;
        Objeto.transform.position = guide.transform.position;
    }
}
