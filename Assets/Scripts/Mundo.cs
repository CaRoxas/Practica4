using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo : MonoBehaviour
{
    public GameObject camara;
    bool activado = false;
    public GameObject BotonCamara;
    public GameObject BotonCrear;
    public GameObject BotonTotal;
    public GameObject BotonBorrar;
    public GameObject BotonLimpieza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Global()
    {
        if (activado == false)
        {
            activado = true;
            camara.transform.position = new Vector3 (551, 20, -15);
            BotonCamara.SetActive(false);
            BotonCrear.SetActive(false);
            BotonTotal.SetActive(false);
            BotonBorrar.SetActive(false);
            BotonLimpieza.SetActive(false);
        }
        else
        {
            activado = false;
            camara.transform.position = new Vector3(551, 7, -1);
            BotonCamara.SetActive(true);
            BotonCrear.SetActive(true);
            BotonTotal.SetActive(true);
            BotonBorrar.SetActive(true);
            BotonLimpieza.SetActive(true);
        }

    }
}
