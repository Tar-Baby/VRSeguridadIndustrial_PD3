using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BNG;
using UnityEngine;

public class SpawnMenu : MonoBehaviour
{

    [SerializeField] private GameObject PlayerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf == true)
        {
            transform.LookAt(PlayerPosition.transform.position);
        }
    }
    //Macchina_Girl

}
