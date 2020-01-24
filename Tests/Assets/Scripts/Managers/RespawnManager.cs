using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public Transform player;
    public Transform Respawn;

    
    public GameManager gm;


    // Start is called before the first frame update

    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.vida < 0)
        {
            player.transform.position = Respawn.position;
            gm.vida = gm.vidamax;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Ha chocado");
            player.transform.position = Respawn.position;
        }
    }


}
