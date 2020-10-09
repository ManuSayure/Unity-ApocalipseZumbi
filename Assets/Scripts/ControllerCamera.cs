using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    public GameObject Jogador;
    Vector3 distanciaJogadorCamera;
    // Start is called before the first frame update
    void Start()
    {
        distanciaJogadorCamera = transform.position - Jogador.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.position = Jogador.transform.position + distanciaJogadorCamera;
        
    }
}
