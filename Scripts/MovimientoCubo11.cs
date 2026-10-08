using UnityEngine;

public class MovimientoCubo11 : MonoBehaviour
{
    public float speed = 3f;
    GameObject esfera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GameObject.FindGameObjectWithTag("Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = esfera.transform.position - transform.position;
        direccion.y = 0;
        direccion = direccion.normalized;
        transform.Translate(direccion * speed * Time.deltaTime, Space.World);
    }
}