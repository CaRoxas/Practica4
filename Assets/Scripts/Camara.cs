using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camara : MonoBehaviour
{
    float rotacionx = 0f;
    float rotaciony = 0f;
    Rigidbody rb;
    bool camaraON;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Button.Clickon)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            rotacionx += mouseX;
            rotaciony += mouseY;

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //camaraON == true;
        }
        
    }
}
