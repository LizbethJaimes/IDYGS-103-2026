using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaSegura : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("¡El Player ha llegado a la zona segura!");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}