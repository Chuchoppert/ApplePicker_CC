using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject       ApplePrefab;
    public float            speed =1;
    public float            leftAndRightEdge = 10f; //Distance to not touch the edge
    public float            ChanceToChangeDirections = 0.1f;
    public float            secondsBetweenAppleDrops = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
