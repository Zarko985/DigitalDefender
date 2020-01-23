using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarGranada : MonoBehaviour
{

    public float Fuerza;
    public GameObject Granada;
    public  GameManager gameManager;
    public Transform Lanzamiento;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            Lanzar();
        }
        
    }

    void Lanzar()
    {
       GameObject granada = Instantiate(Granada, Lanzamiento.position, Lanzamiento.rotation);
        Rigidbody rb = granada.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * Fuerza, ForceMode.VelocityChange);
        gameManager.Granadasrestantes--; 
    }
}
