using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespuestaCorrecta : MonoBehaviour
{
    private int puntuaciónTotal = 0;
    string a = "respuesta";
    //Script para comprobar si una respuesta correcta
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a == "respuesta")
        {
            Debug.Log("respeusta correcta");
        }
    }
}
