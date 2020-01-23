using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sucidio : MonoBehaviour
{
    // Start is called before the first frame update
    public float radio;
    public int damage;
    public GameObject Explosion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            explota();

        }
    }

    void explota()
    {
        Instantiate(Explosion, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radio);

        foreach (Collider nearbyObject in colliders)
        {
            PlayerStats StatsJugador = nearbyObject.GetComponent<PlayerStats>();

            if (StatsJugador != null)
            {
                StatsJugador.DamagePlayer(damage);
            }
        }



        Destroy(gameObject);
    }
}
