using UnityEngine;

public class MostrarVelocidad : MonoBehaviour
{
    public float velocidad = 0.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("Flecja Arriba: " + velocidad * vertical);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("Flecha Abajo: " + velocidad * vertical);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Flecha Izquierda: " + velocidad * horizontal);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("Flecha Derecha: " + velocidad * horizontal);
        }
    }
}
