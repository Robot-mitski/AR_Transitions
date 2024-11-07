using UnityEngine;

public class Plyground : MonoBehaviour
{
    public float rotationSpeed = 100f; // Скорость вращения
    public float zoomSpeed = 10f; // Скорость приближения
    public Camera camera; // Ссылка на камеру

    void Update()
    {
        // Вращение площадки
        if (Input.GetMouseButton(0)) // Проверка, нажата ли левая кнопка мыши
        {
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, -rotationX);
            transform.Rotate(Vector3.right, rotationY);
        }

        // Приближение объектов
        if (Input.GetMouseButton(1)) // Проверка, нажата ли правая кнопка мыши
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
            camera.fieldOfView -= scroll;
        }
    }
}
