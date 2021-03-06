using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject BasketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14;
    public float basketSpacingY = 2;

    // Start is called before the first frame update
    void Start()
    {
       for (int i =0; i < numBaskets; i++)
        {
            GameObject tbasketGO = Instantiate<GameObject>(BasketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tbasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }

}
