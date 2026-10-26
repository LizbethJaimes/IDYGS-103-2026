using UnityEngine;

public class PelotaSaltar : MonoBehaviour
{
    public float velocidadHorizontal = 3f;
    public float fuerzaImpulso = 5f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // Velocidad inicial opcional
        rb.linearVelocity = new Vector2(velocidadHorizontal, 0f);
    }

    void Update()
    {
        // Salto opcional con la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * fuerzaImpulso, ForceMode2D.Impulse);
        }
    }

}