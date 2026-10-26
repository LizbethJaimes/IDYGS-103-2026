using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Mover a la izquierda con la tecla A
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        // Mover a la derecha con la tecla D
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}