using UnityEngine;
using UnityEngine.InputSystem;

public class Rollover : MonoBehaviour
{
    //public RotateMe rotateMe;
    public bool mouseIsOverMe = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position in pixels and covert it to world space (meters)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //get distance between transform.position and mouse position
        float distance = Vector2.Distance(transform.position, mousePos);
        //if distance is small (<1) set mouseIsOverMe true
        if (distance < 1)
        {
            mouseIsOverMe = true;
            //rotateMe.speed = 0;

        }
        else
        { 
            //otherwise set mouseIsOverMe to false
            mouseIsOverMe= false;
            //rotateMe.Speed = 100;
        }
    }
}
