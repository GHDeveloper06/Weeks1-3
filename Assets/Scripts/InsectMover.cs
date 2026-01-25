using UnityEngine;
using UnityEngine.InputSystem;

public class InsectMover : MonoBehaviour
{
    //start position
    public float pointA = -10f;
    //end position
    public float pointB = 10f;
    //speed that sprite moves between points
    public float speed = 0f;

    //public bool cursorTouch = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //increase X value multiplied by time to avoid stutters
        transform.position += transform.right * speed * Time.deltaTime;

        //if sprite position goes past camera borders, invert speed
        if (transform.position.x >= pointB)
        {
            speed = speed * -1;
            //transform.position.x = 9.99;
        }
        if (transform.position.x <= pointA)
        {
            speed = speed * -1;
            //transform.position.x = -9.99;
        }

        //get mouse position in pixels and covert it to world space (meters)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get distance between transform.position and mouse position
        float distance = Vector2.Distance(transform.position, mousePos);
        //if distance is small (<1) set mouseIsOverMe true
        if (distance < 1)
        {
            //cursorTouch = true;
            //rotateMe.speed = 0;
            transform.localScale = new Vector3(1f, 1f, 0.3f); 

        }
        else
        {
            //otherwise set mouseIsOverMe to false
            //cursorTouch = false;
            //rotateMe.Speed = 100;
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
    }
}
