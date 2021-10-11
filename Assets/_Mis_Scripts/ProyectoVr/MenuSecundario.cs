using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static BNG.InputBridge;
public class MenuSecundario : MonoBehaviour
{
    [SerializeField] private GameObject menuReportar;

    private bool _menuActivo = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Instance.RightTrigger > 0 && _menuActivo == false)
        {
            menuReportar.gameObject.SetActive(true);
            _menuActivo = true;
        } 
               
        /*if (Instance.RightTriggerUp && _menuActivo  == true)
        {
            menuReportar.gameObject.SetActive(false);
            _menuActivo = false;
        }
    
        Debug.Log("Menu Activo: " + _menuActivo);*/
       

    }
}
