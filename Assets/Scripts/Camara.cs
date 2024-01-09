using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Camara : MonoBehaviour
{
    static bool camaraON = false;
    bool pulsando = false;
    public GameObject BotonCrear;
    public GameObject BotonMundo;
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
        if (camaraON == true)
        {
            MoverCamara();
        }
    }

    public void ActivarCamara() 
    {
        if (camaraON == false)
        {
            camaraON = true;
            // desactivar
            BotonCrear.SetActive(false);
            BotonTotal.SetActive(false);
            BotonMundo.SetActive(false);
            BotonBorrar.SetActive(false);
            BotonLimpieza.SetActive(false);
        }
        else
        {
            camaraON = false;
            // activar botons
            BotonCrear.SetActive(true);
            BotonTotal.SetActive(true);
            BotonMundo.SetActive(true);
            BotonBorrar.SetActive(true);
            BotonLimpieza.SetActive(true);
        }
    }
    public void MoverCamara()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pulsando = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pulsando = false;
        }


        if (pulsando == true) 
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            Debug.Log(mouseX + " " + mouseY);

            transform.position = new Vector3(transform.position.x - mouseX * 0.2f, transform.position.y, transform.position.z - mouseY * 0.2f);
        }
    }
}
