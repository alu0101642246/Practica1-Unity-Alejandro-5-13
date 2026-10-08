using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            vertical = 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            vertical = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = 1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = -1;
        }

        transform.Translate(horizontal * speed, 0, vertical * speed, Space.World);
    }
}