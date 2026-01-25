using UnityEngine;
using UnityEngine.InputSystem;

public class MGlassFollow : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create vector2 to find current mouse position
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector2 mpConvert = gameCamera.ScreenToWorldPoint(mousePos);
        transform.position = mpConvert;
    }
}
