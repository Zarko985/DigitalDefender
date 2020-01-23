using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public float delay = 3f;

    float CuentaAtras;

    bool haExplotado = false;

    public float radio;

    public float damage;

   

    public GameObject Explosion;

    // Start is called before the first frame update
    void Start()
    {
      CuentaAtras = delay;
    }

    // Update is called once per frame
    void Update()
    {
        CuentaAtras -= Time.deltaTime;
        if(CuentaAtras <= 0f && !haExplotado)
        {
            explota();
        }
    }

    void explota()
    {
        Instantiate(Explosion, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radio);

       foreach(Collider nearbyObject in colliders)
       {
            EnemyStats scriptEnemigo = nearbyObject.GetComponent<EnemyStats>();
            if (scriptEnemigo != null)
            {
                scriptEnemigo.HurtEnemy(damage);
            }
       }



        Destroy(gameObject);
    }
}
