using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.EventSystems;

public class Crear : MonoBehaviour
{
    public GameObject[] Objetos = new GameObject[4];
    public GameObject Panel;
    public TMP_Text Back;
    bool crearON = false;
    public GameObject BotonCamara;
    public GameObject BotonTotal;
    public GameObject BotonMundo;
    static int numeroSeleccionado = 0;
    // Update is called once per frame
    void Update()
    {
        if (crearON == true)
        {
            CreacionElemento();
        }
    }
    public void ActivarCrear() 
    {
        if (crearON == false)
        {
            crearON = true;
            Panel.SetActive(true);
            BotonCamara.SetActive(false);
            BotonTotal.SetActive(false);
            BotonMundo.SetActive(false);
            Back.text = "Atrás";
        }
        else
        {
            crearON = false;
            BotonCamara.SetActive(true);
            BotonTotal.SetActive(true);
            BotonMundo.SetActive(true);
            Panel.SetActive(false);
            Back.text = "Crear";
        }
    }
    // PERSONAJE
    public void CreacionElemento()
    {

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray rayobjecto = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit objetillo;
            int mascara = LayerMask.GetMask("Suelo");
            if(Physics.Raycast(rayobjecto, out objetillo, mascara))
            {
               GameObject objetoCreado =  GameObject.Instantiate(Objetos[numeroSeleccionado],objetillo.point , Quaternion.Euler(-90 , 0, 0));

                if (numeroSeleccionado == 2)
                {
                   objetoCreado.transform.Rotate(90, -90, 0);
                }

            }
         
        }
    }


    // BOTONES
    public void CreacionArbol()
    {
        numeroSeleccionado = 0;
    }
    public void CreacionFrutal()
    {
        numeroSeleccionado = 1;
    }
    public void CreacionGranero()
    {
        numeroSeleccionado = 2;
    }
    public void CreacionLago()
    {
        numeroSeleccionado = 3;
    }
}
