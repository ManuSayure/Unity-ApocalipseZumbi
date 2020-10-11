using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBala : MonoBehaviour
{

    // Update is called once per frame
    public float Velocidade = 20;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition( 
            ( 
                GetComponent<Rigidbody>().position 
                + transform.forward
            )
            * Velocidade 
            * Time.deltaTime
        );
        
    }
}
