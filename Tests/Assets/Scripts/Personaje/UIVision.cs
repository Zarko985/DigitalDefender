using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIVision : MonoBehaviour
{

    public Image Visiones;

    public GameManager manager;

    

    // Start is called before the first frame update
    void Start()
    {

 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            if ((manager.Green == false)&&(manager.Red == true))
            {
                Visiones.color = new Color(0,255,0, 0.1f);
            }

            if ((manager.Green == true) && (manager.Red == false))
            {
                Visiones.color = new Color(255, 0,0, 0.1f);
            }
        }
        


    }
}
