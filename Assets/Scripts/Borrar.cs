using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Borrar : MonoBehaviour
{
    public TMP_Text Retroceso;
    public GameObject[] Borrado;
    public GameObject BotonCamara;
    public GameObject BotonCrear;
    public GameObject BotonTotal;
    public GameObject BotonMundo;
    public GameObject BotonLimpieza;
    public GameObject Panelito;
    public GameObject[] Arboles;
    public GameObject[] Frutales;
    public GameObject[] Graneros;
    public GameObject[] Estanques;
    bool borrarOn = false;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarBorrar()
    {
        if (borrarOn == false)
        {
            borrarOn = true;
            
            BotonCamara.SetActive(false);
            BotonCrear.SetActive(false);
            BotonTotal.SetActive(false);
            BotonMundo.SetActive(false);
            BotonLimpieza.SetActive(false);
            Panelito.SetActive(true);
            Retroceso.text = "Atrás";
        }
        else
        {
            borrarOn = false;
            BotonCamara.SetActive(true);
            BotonCrear.SetActive(true);
            BotonTotal.SetActive(true);
            BotonMundo.SetActive(true);
            BotonLimpieza.SetActive(true);
            Panelito.SetActive(false);
            Retroceso.text = "Borrar";
        }
    }
    public void BorrarArbol()
    {
        Arboles = GameObject.FindGameObjectsWithTag("Arbol");
        //Destroy(Arboles);
    }
    public void BorrarFrutal()
    {
        if (gameObject.tag == "Frutal")
        {
            Destroy(gameObject);
        }
    }
    public void BorrarGranero()
    {
        if (gameObject.tag == "Granero")
        {
            Destroy(gameObject);
        }
    }
    public void BorrarEstanque()
    {
        if (gameObject.tag == "Estanque")
        {
            Destroy(gameObject);
        }
    }
}
