using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Disparo : MonoBehaviour
{

    [Header("Arma")]
    public float FireRate;
    public GameObject Balaprefab;
    public Transform Cañon;
    public int ammoMax;

    [Header("HUD")]
    public int ammo;
    public int ammoTotal;
    public Text Municion;


    private float nextTimeToShoot = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ammo > 0)
        {
            if (Input.GetButton("Fire1") && Time.time >= nextTimeToShoot)
            {
                nextTimeToShoot = Time.time + 1f / FireRate;
                ammo--;

                Shoot();
            }
        }



        recarga();
        TextoAmmo();
        
    }

    void recarga()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Invoke("reload", 1f);
           
        }
    }

    void TextoAmmo()
    {
        Municion.text = ammo + "/" + ammoTotal;
    }

    void Shoot()
    {
        
        Instantiate(Balaprefab, Cañon.position, Cañon.rotation);

    }

    void reload()
    {
        ammo = ammoMax;
        ammoTotal -= ammoMax;
    }

    

}
