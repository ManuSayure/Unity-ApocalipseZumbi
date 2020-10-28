using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJogador : MonoBehaviour
{
    public float Velocidade = 10;  
    Vector3 direcao;
    public LayerMask mascaraChao;
    

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
    /* Funcao FixedUpdate é usada sempre que precisamos aplicar física nos gameObjects*/
    void FixedUpdate() {
        float tempoPorSegundo = Time.deltaTime;
        Vector3 posicaoJogador = GetComponent<Rigidbody>().position;
        
        GetComponent<Rigidbody>().MovePosition( posicaoJogador +  (direcao * Velocidade * tempoPorSegundo ));

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 100, Color.red);
        RaycastHit impacto; // guardar posicao onde raio toca o chao do cenario

        if(Physics.Raycast(raio, out impacto, 100, mascaraChao)) {
            Vector3 posicaoMiraJogador = impacto.point - transform.position; // posicao em relação ao jogador            
            posicaoMiraJogador.y = transform.position.y;//Jogando a posicaoMiraJogador para o mesmo ponto y do jogador
            Quaternion novaRotacao = Quaternion.LookRotation(posicaoMiraJogador); //cria uma nova rotacao a partir da posicaoMiraJogador
            GetComponent<Rigidbody>().MoveRotation(novaRotacao); //nova rotacao do jogador

        }

    }
}
