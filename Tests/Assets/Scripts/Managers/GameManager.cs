using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("VISION")]
    public GameObject Verde;
    public GameObject Rojo;

    public bool Green = true;
    public bool Red = false;

    [Header("Granada")]
    public Text Granadas;
    public int Granadasrestantes;

    [Header("VidaYEscudo")]

    public int escudo;
    public int escudomax = 50;

    public int vida;
    public int vidamax = 100;

    public Slider barraVida;
    public Slider barraEscudo;








    // Start is called before the first frame update
    void Start()
    {
        Verde = GameObject.Find("Verde");
        Rojo = GameObject.Find("Rojo");
        Verde.SetActive(true);
        Rojo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        vision();
        grenadeCantity();
        slidersEV();
    }

    void vision()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if ((Green == true) && (Red == false))
            {

                Green = false;
                Verde.SetActive(false);
                Red = true;
                Rojo.SetActive(true);

            }
            else
            if ((Green == false) && (Red == true))
            {
                GameObject.Find("GuardaObjetos2");
                Green = true;
                Verde.SetActive(true);
                Red = false;
                Rojo.SetActive(false);

            }
        }
    }

    void grenadeCantity()
    {
        Granadas.text = "Granadas:" + Granadasrestantes;

    }

    void slidersEV()
    {

        {
            barraVida.value = vida;
            barraEscudo.value = escudo;
        }


    }
}




