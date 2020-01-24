using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CodeLock : MonoBehaviour
{

    public Text code;
    string codeValue ="";
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        code.text = codeValue;

        if(codeValue == "2813")
        {
            Destroy(door);
        }
        if (codeValue.Length >=4)
        {
            codeValue = "";
        }


        
    }

    public void addDigit(string number)
    {
        codeValue += number;
    }

}
