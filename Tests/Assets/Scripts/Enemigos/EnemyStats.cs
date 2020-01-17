using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    // Start is called before the first frame update
    public float Vida;
    public float vidaMax = 1;

    Color objAlpha;
    void Start()
    {
        Vida = vidaMax;

        objAlpha = GetComponent<MeshRenderer>().material.color;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        decoloracion();
        Muerte();

        //if (Vida >= 100)
        //{
        //    objAlpha.a = 1;
        //    GetComponent<MeshRenderer>().material.color = objAlpha;

        //}
        //if ((Vida <= 75)&&(Vida >= 40))
        //{
        //    objAlpha.a = 0.5f;
        //    GetComponent<MeshRenderer>().material.color = objAlpha;

        //}
        //if ((Vida <= 39) && (Vida >= 10))
        //{
        //    objAlpha.a = 0.2f;
        //    GetComponent<MeshRenderer>().material.color = objAlpha;

        //}
    }

    public void decoloracion()
    {
        objAlpha.a = Vida;
        GetComponent<MeshRenderer>().material.color = objAlpha;
    }
    public void HurtEnemy(float damage)
    {
        Vida -= damage;
    }


    public void Muerte()
    {
        if( Vida <= 0.01f)
        {
            Destroy(gameObject);
        }
    }

}
