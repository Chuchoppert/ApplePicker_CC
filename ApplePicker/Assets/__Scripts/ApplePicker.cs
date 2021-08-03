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
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;


        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        
    }
    private void FixedUpdate()
    {
        if (Random.value < ChanceToChangeDirections)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(ApplePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", 2f);
    }
}
