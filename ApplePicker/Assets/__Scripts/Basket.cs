using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos2D = Input.mousePosition;

        MousePos2D.z = -Camera.main.transform.position.z;

        Vector3 MousePos3D = Camera.main.ScreenToWorldPoint(MousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = MousePos3D.x;
        this.transform.position = pos;
    }
}
