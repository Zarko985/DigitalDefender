using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Verde;
    public GameObject Rojo;

    public bool Green = true;
    public bool Red = false;


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
}
