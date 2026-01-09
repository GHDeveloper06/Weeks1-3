using UnityEngine;
using UnityEngine.InputSystem;


public class MouseFollow : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldmousePos = gameCamera.ScreenToWorldPoint(mousePos);
        worldmousePos.z = 0;
        transform.position = worldmousePos;
    }
}
