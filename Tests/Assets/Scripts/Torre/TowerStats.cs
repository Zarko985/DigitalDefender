using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStats : MonoBehaviour
{

    public float Vida;
    public float vidaMax = 1;
    // Start is called before the first frame update
    void Start()
    {
        Vida = vidaMax
;    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HurtEnemy(float damage)
    {
        Vida -= damage;
    }
    public void Muerte()
    {
        if (Vida <= 0.01f)
        {
            Destroy(gameObject);
        }
    }
}
