using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Total : MonoBehaviour
{
    public GameObject[] cositas;
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
        cositas = GameObject.FindGameObjectsWithTag("Arbol");
        cositas = GameObject.FindGameObjectsWithTag("Frutal");
        cositas = GameObject.FindGameObjectsWithTag("Granero");
        cositas = new GameObject[cositas.Length];

    }
    public void Cuentas()
    {
        if (On == false)
        {
            On = true;
            BotonCamara.SetActive(false);
            BotonCrear.SetActive(false);
            BotonMundo.SetActive(false);
            calculo.text = cositas.ToString();
        }
        else
        {
            On = false;
            BotonCamara.SetActive(true);
            BotonCrear.SetActive(true);
            BotonMundo.SetActive(true);
        }

    }
}
