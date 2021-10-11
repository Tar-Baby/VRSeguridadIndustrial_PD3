using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuestas : MonoBehaviour
{
     [SerializeField] public int respuestaCorrecta = 0;
     //[SerializeField] private bool respuestaCorrecta;
     [SerializeField] GameObject PointsManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void DevolverRespuestaCorrecta(int r)
    {
        if (r == respuestaCorrecta)
        {
            Debug.Log("Respuesta Correcta");
        }
        else
        {
            Debug.Log("Respuesta Incorrecta");
        }
    }



}
