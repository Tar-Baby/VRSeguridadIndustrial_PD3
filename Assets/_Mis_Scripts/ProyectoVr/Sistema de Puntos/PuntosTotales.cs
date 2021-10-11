using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosTotales : MonoBehaviour
{
    //Contador de puntos global, los puntos se suman para ser mostrados
    //al final del recorrido.

    private int contadorDePuntos = 0;
    private string respuestaCorrecta;
    
    // Start is called before the first frame update
    void Start()
    {
        contadorDePuntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
        
        
    }
    
    private void contarPuntos()
    {
        if (respuestaCorrecta == "v")
        {
            contadorDePuntos += 1;
        }
    }
    
    
    
}
