using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    public GameObject[] arboles = new GameObject[3];
    public GameObject Panel;
    bool crearON = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (crearON == true)
        {
            Creacion();
        }
    }
    public void PanelOn() 
    {
        Panel.SetActive(true);
    }
    public void ActivarCrear() 
    {
        if (crearON == false)
        {
            crearON = true;
        }
        else
        {
            crearON = false;
        }
    }
    void Creacion()
    {

        if (Input.GetMouseButtonDown(0))
        {            
           
            Ray rayobjecto = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit objetillo;
            if(Physics.Raycast(rayobjecto, out objetillo))
            {
                GameObject.Instantiate(arboles[0],objetillo.point , Quaternion.identity);
            }
         
        }
    }
}
