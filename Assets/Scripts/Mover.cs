using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 0;
    public float xMax = 10;
    public float xMin = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //float speed = 0.01f; 
        

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveXpos = transform.position;
        moveXpos.x = moveXpos.x + speed;
        transform.position = moveXpos;
        if (moveXpos.x >= xMax)
        {
            speed = -speed;
        }
        if (moveXpos.x <= xMin) { 
            speed = speed * -1;
        }
    }
}
