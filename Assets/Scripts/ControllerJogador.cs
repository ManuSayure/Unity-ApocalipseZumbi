using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJogador : MonoBehaviour
{
    // Start is called before the first frame update
    
   

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal"); // move com as teclas (left e rigth) e  (a , d)
        float eixoZ= Input.GetAxis("Vertical"); // move com as teclas (up, down) e (s , w)
        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao);
        
    }
}
