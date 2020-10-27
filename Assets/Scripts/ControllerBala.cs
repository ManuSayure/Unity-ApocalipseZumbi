using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBala : MonoBehaviour
{

    // Update is called once per frame
    public float Velocidade = 10;
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(
            (
                GetComponent<Rigidbody>().position
                + (transform.forward * Velocidade * Time.deltaTime))
        );

    }
    //Funcao para destruir zumbi atingido pela bala e em seguida destruir a bala
    void OnTriggerEnter(Collider objetoDeColisao)
    {
        if(objetoDeColisao.tag == "inimigo")
        {
            Destroy(objetoDeColisao.gameObject);
        }
        Destroy(gameObject);
        
    }
}
