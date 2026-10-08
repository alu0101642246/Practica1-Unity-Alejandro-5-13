using UnityEngine;

public class Desplazamiento : MonoBehaviour
{
    public Vector3 desplazamiento;
    bool bloqueado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool pulsado = Input.GetAxis("Desplazamiento") > 0;

        if (pulsado && !bloqueado)
        {
            transform.position += desplazamiento;
            bloqueado = true;
        }

        if (!pulsado)
        {
            bloqueado = false;
        }
    }
}
