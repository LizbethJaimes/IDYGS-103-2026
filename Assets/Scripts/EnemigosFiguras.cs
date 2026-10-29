using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemigosFiguras : MonoBehaviour
{
    public float speed = 4f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.linearVelocity = randomDirection * speed;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("¡El Player fue tocado! Reiniciando nivel...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
