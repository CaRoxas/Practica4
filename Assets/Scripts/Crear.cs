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
            Ray rayobjeto = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit objetillo;
            int mascara = LayerMask.GetMask("Suelo");
            if(Physics.Raycast(rayobjeto, out objetillo, mascara))
            {
               GameObject objetoCreado =  GameObject.Instantiate(Objetos[numeroSeleccionado],objetillo.point , Quaternion.Euler(-90 , 0, 0));

                if (numeroSeleccionado == 2)
                {
                    objetoCreado.transform.Rotate(180, -270, 90);
                    objetoCreado.transform.Translate(0.65f * Vector3.down);
                }
                if (numeroSeleccionado == 3)
                {
                    objetoCreado.transform.Rotate(180, -270, 90);
                    // transform.rotation = 
                    objetoCreado.transform.Translate(2.3f * Vector3.up); // pos -> (0,2.3,0)
                    // Vector3 pos = objetoCreado.transform.position
                    // pos.y = 2.3f
                    // objetoCreado.transform.position = pos
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
    public void CreacionEstanque()
    {
        numeroSeleccionado = 3;
    }
}
