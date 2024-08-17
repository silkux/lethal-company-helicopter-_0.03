using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public float ascentSpeed = 5f;

    void Update()
    {
        // Movimiento básico hacia adelante y hacia atrás
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        // Movimiento hacia los lados
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Rotación del helicóptero
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);

        // Subir y bajar (Teclas Q y E)
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * ascentSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.down * ascentSpeed * Time.deltaTime);
        }
    }
}
