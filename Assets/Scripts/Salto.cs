using UnityEngine;

public class Salto : MonoBehaviour
{
    public float fuerzaSalto = 7f;
    private Rigidbody2D rb;

    void Start()
    {
        // Obtenemos el Rigidbody2D del mismo GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detectamos el instante en que se presiona la barra espaciadora para saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Aplicamos un impulso vertical instantáneo
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
}


