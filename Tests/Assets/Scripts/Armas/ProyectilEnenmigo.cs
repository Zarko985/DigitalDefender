using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilEnenmigo : MonoBehaviour
{
    public float speed;

    public float Destruccion;

    public float damage;

    public GameObject explosion;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        DestroyGameObject();

        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {




    }

    void DestroyGameObject()
    {

        Destroy(gameObject, Destruccion);


    }
}
