using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{

    public Transform target;
    public float DistanciaDisparo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance <= DistanciaDisparo)
            {
                transform.LookAt(target);
            }
            else
            {
                InitialPosition();
            }

        }
        else
        {
            InitialPosition();
        }

    }

    void InitialPosition()
    {

        Quaternion lerpRotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector3.zero), 0.05f);
        transform.rotation = lerpRotation;
    }
}
