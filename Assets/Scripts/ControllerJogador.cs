using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJogador : MonoBehaviour
{
    public float Velocidade = 10;  
   

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal"); // move com as teclas (left e rigth) e  (a , d)
        float eixoZ= Input.GetAxis("Vertical"); // move com as teclas (up, down) e (s , w)
        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        float tempoPorSegundo = Time.deltaTime; // tempo por segundo para mover um quadradinho no cenário
        transform.Translate(direcao * Velocidade * tempoPorSegundo );
        bool movendo = false;
        if(direcao != Vector3.zero){
            movendo = true;

        }else{
           movendo = false;
        }
        GetComponent<Animator>().SetBool("Movendo", movendo);
        
    }
}
