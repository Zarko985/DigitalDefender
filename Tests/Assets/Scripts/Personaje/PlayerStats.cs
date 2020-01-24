using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm.escudo = gm.escudomax;
        gm.vida = gm.vidamax;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamagePlayer(int damage)
    {
        if(gm.escudo >= 1)
        {
            gm.escudo -= damage;
        }
        else
        {
            gm.vida -= damage;
        }
    }

    
}
