using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camara : MonoBehaviour
{
    static bool camaraON = false;
    bool pulsando = false;
  
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
        }
        else
        {
            camaraON = false;
        }
    }
    public void MoverCamara()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pulsando=true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pulsando = false;
            //transform.position = new Vector3(551, 6.9f, -3.1f);
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
