using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color Colour;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickRandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame) {
        //    //PickRandomColour();
        //}
        

        //get the mouse posistion
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // is it over the shape
        if (spriteRenderer.bounds.Contains(mousPos))
        {
            spriteRenderer.color = Colour;
        }
        else {
            Colour = Color.grey;
        }
        //y set the color with our Colour variable
        //n set the color to hwhite
    }

    //void PickRandomColour() 
    //{
    //    spriteRenderer.color = Random.ColorHSV();
    //}
    void changetoSelectedColour() { 
    
    }
}
