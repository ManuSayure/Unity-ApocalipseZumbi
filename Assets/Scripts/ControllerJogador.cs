using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJogador : MonoBehaviour
{
    public float Velocidade = 10;  
    Vector3 direcao;
    

    // Update is called once per frame    
    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal"); // move com as teclas (left e rigth) e  (a , d)
        float eixoZ= Input.GetAxis("Vertical"); // move com as teclas (up, down) e (s , w)
        direcao = new Vector3(eixoX, 0, eixoZ);
         // tempo por segundo para mover um quadradinho no cenário
        //transform.Translate(direcao * Velocidade * tempoPorSegundo );        
    
        bool movendo = false;
        if(direcao != Vector3.zero){
            movendo = true;

        }else{
           movendo = false;
        }
        GetComponent<Animator>().SetBool("Movendo", movendo);
        
    }
    void FixedUpdate() {
        float tempoPorSegundo = Time.deltaTime;
        Vector3 posicaoJogador = GetComponent<Rigidbody>().position;
        
        GetComponent<Rigidbody>().MovePosition
            ( posicaoJogador +  (direcao * Velocidade *tempoPorSegundo ));
    }
}
