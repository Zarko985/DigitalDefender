using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public float FireRate;
    public GameObject Balaprefab;
    public Transform Cañon;

    public float shootRadius = 4f;

    Transform target;
    private float nextTimeToShoot = 0f;

   

    

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;

    }

    private void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= shootRadius)
        {
            Shoot();
        }



    }
    // Start is called before the first frame update



    public void Shoot()
    {
        if(Time.time >= nextTimeToShoot)
        {
            nextTimeToShoot = Time.time + 1f / FireRate;

            Instantiate(Balaprefab, Cañon.position, Cañon.rotation);
        }

        

    }
    private void OnDrawGizmosSelected()
    {
      

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, shootRadius);

    }




}
