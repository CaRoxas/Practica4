using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo : MonoBehaviour
{
    public GameObject camara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Global()
    {
        camara.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        //camara.transform.rotation = (0, 0, 0);
    }
}
