using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour

{
    public float fuerza = 10f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direccion = new Vector2(horizontal, vertical);

        // Mueve la plataforma usando el Rigidbody2D en modo Kinematic
        rb.MovePosition(rb.position + direccion * fuerza * Time.fixedDeltaTime);
    }
}