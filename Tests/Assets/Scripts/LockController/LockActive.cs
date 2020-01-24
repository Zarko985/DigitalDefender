using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockActive : MonoBehaviour
{

    public GameObject PanelCodigo;
    
    // Start is called before the first frame update
    void Start()
    {
        PanelCodigo.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.Find("First Person Player/Main Camera").GetComponent<MouseLook>().enabled = false;
           
            Cursor.lockState = CursorLockMode.None;
            
            PanelCodigo.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("First Person Player/Main Camera").GetComponent<MouseLook>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
           
            PanelCodigo.SetActive(false);
        }
    }
}
