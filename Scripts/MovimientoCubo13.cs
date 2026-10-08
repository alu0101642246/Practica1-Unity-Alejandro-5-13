using UnityEngine;

public class MovimientoCubo13 : MonoBehaviour
{
    public float speed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * 100 * Time.deltaTime, 0);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        Debug.DrawRay(transform.position, transform.forward, Color.red);
    }
}