using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Total : MonoBehaviour
{
    public GameObject[] Arboles;
    public GameObject[] Frutales;
    public GameObject[] Graneros;
    public GameObject[] Estanques;
    public int cositasCount;
    public GameObject Panel;
    public TMP_Text calculo;
    public GameObject BotonCamara;
    public GameObject BotonCrear;
    public GameObject BotonMundo;
    bool On = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Arboles = GameObject.FindGameObjectsWithTag("Arbol");
        Frutales = GameObject.FindGameObjectsWithTag("Frutal");
        Graneros = GameObject.FindGameObjectsWithTag("Granero");
        Estanques = GameObject.FindGameObjectsWithTag("Estanque");
        cositasCount = Arboles.Length + Frutales.Length + Graneros.Length;

    }
    public void Cuentas()
    {
        if (On == false)
        {
            On = true;
            BotonCamara.SetActive(false);
            BotonCrear.SetActive(false);
            BotonMundo.SetActive(false);



            calculo.text = "Numero de Arboles: " + Arboles.Length.ToString() + "\n";
            calculo.text = calculo.text + " Numero de Frutales: " + Frutales.Length.ToString() +"\n";
            calculo.text = calculo.text + "Numero de Graneros: " + Graneros.Length.ToString() + "\n";
            //calculo.text = calculo.text + "Numero de Estanques: " + Estanques.Length.ToString();
            Panel.SetActive(true);
        
        }
        else
        {
            On = false;
            BotonCamara.SetActive(true);
            BotonCrear.SetActive(true);
            BotonMundo.SetActive(true);
            Panel.SetActive(false);
        }

    }
}
