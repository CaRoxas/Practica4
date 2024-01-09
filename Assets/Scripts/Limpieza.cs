using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Limpieza : MonoBehaviour
{
    public GameObject BotonCamara;
    public GameObject BotonCrear;
    public GameObject BotonTotal;
    public GameObject BotonMundo;
    public GameObject BotonBorrar;
    bool LimpiarOn = false;
    int mascara = 1 << 6;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivarLimpieza()
    {
        if (LimpiarOn == false)
        {
            LimpiarOn = true;
            BotonCamara.SetActive(false);
            BotonCrear.SetActive(false);
            BotonTotal.SetActive(false);
            BotonMundo.SetActive(false);
            BotonBorrar.SetActive(false);
        }
        else
        {
            LimpiarOn = false;
            BotonCamara.SetActive(true);
            BotonCrear.SetActive(true);
            BotonTotal.SetActive(true);
            BotonMundo.SetActive(true);
            BotonBorrar.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayoCamara = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit golpe;
            if (Physics.Raycast(rayoCamara, out golpe, mascara))
            {
                Destroy(golpe.collider.gameObject);
            }
        }
    }
}
