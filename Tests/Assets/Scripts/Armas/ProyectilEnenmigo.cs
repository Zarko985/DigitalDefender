using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilEnenmigo : MonoBehaviour
{
    public float speed;

    public float Destruccion;

    public int damage;

   

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



        if ((other.gameObject.tag == "Player") || (other.transform.tag == "Suelo"))
        {

            Debug.Log("llega");
           PlayerStats StatsJugador = other.gameObject.GetComponent<PlayerStats>();
           
            if (StatsJugador != null)
            {
                StatsJugador.DamagePlayer(damage);
            }

            //other.gameObject.SendMessage("HurtEnemy", damage, SendMessageOptions.DontRequireReceiver);

            Destroy(gameObject);

        }


    }



    void DestroyGameObject()
    {

        Destroy(gameObject, Destruccion);


    }
}
