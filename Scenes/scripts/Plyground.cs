using UnityEngine;

public class Plyground : MonoBehaviour
{
    public float rotationSpeed = 100f; 
    public float zoomSpeed = 10f; 
    public Camera camera; 

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, -rotationX);
            transform.Rotate(Vector3.right, rotationY);
        }

        if (Input.GetMouseButton(1))
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
            camera.fieldOfView -= scroll;
        }
    }
}
