using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Total : MonoBehaviour
{
    public GameObject[] cositas;
    public TMP_Text calculo;
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
        calculo.text = cositas.ToString();
    }
}
