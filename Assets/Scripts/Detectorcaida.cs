using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para reiniciar la escena

public class DetectorCaida : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Si el objeto que entra al trigger es la pelota
        if (collision.CompareTag("Pelota") || collision.gameObject.name == "Pelota")
        {
            // Recargamos la escena actual para reiniciar el juego
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}