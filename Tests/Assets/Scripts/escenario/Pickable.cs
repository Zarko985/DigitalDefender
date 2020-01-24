using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{

    public GameManager gm;

    

    public int Sumagranadas;


    // Start is called before the first frame update
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
            gm.escudo = gm.escudomax;

            gm.vida = gm.vidamax;

            gm.Granadasrestantes += Sumagranadas;

            Destroy(gameObject);
        }
    }
}
