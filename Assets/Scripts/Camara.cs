using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camara : MonoBehaviour
{
    float rotacionx = 0f;
    float rotaciony = 0f;
    bool camaraON;
    public GameObject botonCamara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoverCamara()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            rotacionx += mouseX;
            rotaciony += mouseY;

            transform.eulerAngles = new Vector3(-rotaciony, rotacionx, 0);
            camaraON = true;
        }
        else
        {
            camaraON = false;
            //transform.position = new Vector3(551, 6.9, -3.1);
        }
    }
}
