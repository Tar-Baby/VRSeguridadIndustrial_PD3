using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static BNG.InputBridge;
public class MenuSecundario : MonoBehaviour
{
    [SerializeField] private GameObject menuReportar;

    private bool _menuActivo = false;
   
    [SerializeField] GameObject BotonRiesgoFisico;
    [SerializeField] GameObject BotonRiesgoErgonomico;
    [SerializeField] GameObject BotonReportar;

    
    

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
            
            BotonReportar.gameObject.SetActive(true);
            BotonRiesgoErgonomico.gameObject.SetActive(false);
            BotonRiesgoFisico.gameObject.SetActive(false);
            
            _menuActivo = true;
        }

    }

}
