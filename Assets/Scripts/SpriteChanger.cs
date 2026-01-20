using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using Unity.Collections;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color Colour;
    public List<Sprite> barrels;
    public int randomNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickRandomColour
    }

    // Update is called once per frame
    void Update()
    {
       if (Keyboard.current.anyKey.wasPressedThisFrame == true) {
            //PickRandomColour();
            Debug.Log("Try to change the sprite renderer");
            if (barrels.Count > 0)
            {
                pickRandomSprite();
            }
       }
        

        //get the mouse posistion
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        // is it over the shape
        if (spriteRenderer.bounds.Contains(mousPos)==true)
        {
            spriteRenderer.color = Colour;
        }
        else {
            Colour = Color.grey;
        }
        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0) 
        {
            barrels.RemoveAt(0);
        }
        //y set the color with our Colour variable
        //n set the color to hwhite
    }

    //void PickRandomColour() 
    //{
    //    spriteRenderer.color = Random.ColorHSV();
    //}
    //void changetoSelectedColour() { 

    //}
    void pickRandomSprite()
    {
        //spriteRenderer.sprite = mySprite; 

        //pick a random number
        randomNum = Random.Range(0, barrels.Count);
        spriteRenderer.sprite = barrels[randomNum];
    }
}
