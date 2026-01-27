using UnityEngine;
using UnityEngine.InputSystem;

public class MGlassFollow : MonoBehaviour
{
    //count variable
    float t;
    //reference variable for Animation Curve
    public AnimationCurve ACpulse;

    //get game camera
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float c = ACpulse.Evaluate(t);
        //go through Animation Curve every frame
        t += Time.deltaTime;
        //reset after 1 second
        if (t > 1f) 
        {
            t = 0.1f;
        }
        //change scale based off of animation curve position
        transform.localScale = Vector3.one * c;

        //create vector2 to find current mouse position
        Vector2 mousePos = Mouse.current.position.ReadValue();
        //convert screen space to world space using Camera in hierarchy as reference
        Vector2 mpConvert = gameCamera.ScreenToWorldPoint(mousePos);
        //change position based off where the cursor is from the game camera view
        transform.position = mpConvert;
    }
}
