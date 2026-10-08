using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed;
    public bool movimientoMundial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movimientoMundial)
        {
            transform.Translate(moveDirection * speed, Space.World);
        }
        else
        {
            transform.Translate(moveDirection * speed, Space.Self);
        }
    }
}
