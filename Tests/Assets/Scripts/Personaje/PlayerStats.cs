using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    
    public int escudo;
    int escudomax = 50;

    public int vida;
    public int vidamax = 100;

    public Slider barraVida;
    public Slider barraEscudo;


    // Start is called before the first frame update
    void Start()
    {
        escudo = escudomax;
        vida = vidamax;
     
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.value = vida;
        barraEscudo.value = escudo;
    }

    public void DamagePlayer(int damage)
    {
        if(escudo >= 1)
        {
            escudo -= damage;
        }
        else
        {
            vida -= damage;
        }
    }

    
}
