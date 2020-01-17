using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
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
      //  transform.Translate(Vector3.forward * speed);
       
    }

    private void OnTriggerEnter(Collider other)
    {

        

        if ((other.gameObject.tag == "Enemy")||(other.transform.tag == "Suelo"))
        {

            Debug.Log("llega");
            //EnemyStats scriptEnemigo = other.gameObject.GetComponent<EnemyStats>();
            //if (scriptEnemigo != null)
            //{
            //    scriptEnemigo.HurtEnemy(damage);
            //}

            other.gameObject.SendMessage("HurtEnemy", damage, SendMessageOptions.DontRequireReceiver);

            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);

        }
      

    }

    void DestroyGameObject()
    {
        
        Destroy(gameObject, Destruccion);


    }
}

