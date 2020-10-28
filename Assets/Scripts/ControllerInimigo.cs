using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInimigo : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 3;
    // Start is called before the first frame update
   
    void FixedUpdate() {
        Vector3 direcao = Jogador.transform.position - transform.position;      
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);
        Quaternion novaRotacao = Quaternion.LookRotation(direcao);// calcula a rotação para o zumbi sempre olhar em direcao ao jogador
        GetComponent<Rigidbody>().MoveRotation(novaRotacao); // rotaciona o zumbi na direcao do personagem


        //Checa se a distancia entre o jogador e o inimigo é maior que 2.5, se for maior continua andando e não ataca, menor para e ataca
        if (distancia > 2.5){

            GetComponent<Rigidbody>().MovePosition( GetComponent<Rigidbody>().position + (direcao.normalized * Velocidade * Time.deltaTime)
            );

            GetComponent<Animator>().SetBool("Atacando", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Atacando", true);
        }
        
    }
}
