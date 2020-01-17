using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float FireRate;
    public GameObject Balaprefab;
    public Transform Cañon;


    private float nextTimeToShoot = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToShoot)
        {
            nextTimeToShoot = Time.time + 1f / FireRate;

            Shoot();
        }
    }

    void Shoot()
    {
        
        Instantiate(Balaprefab, Cañon.position, Cañon.rotation);

    }

}
