using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInimigo : MonoBehaviour
{
    public GameObject Jogador;
    public float Velocidade = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        Vector3 direcao = Jogador.transform.position - transform.position;      
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);

        if(distancia > 2.5){
            GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position 
            + (direcao.normalized * Velocidade * Time.deltaTime));

            
            Quaternion novaRotacao = Quaternion.LookRotation(direcao);// calcula a rotação para o zumbi sempre olhar em direcao ao jogador
            GetComponent<Rigidbody>().MoveRotation(novaRotacao); // rotaciona o zumbi na direcao do personagem

        }
        
    }
}
